using Amazing.Ecommerce.Catalog.Entities;
using MongoDB.Driver;

namespace Amazing.Ecommerce.Catalog.Respositories;

public class TypeRepository : ITypeRepository
{
    private readonly IMongoCollection<ProductType> _types;

    public TypeRepository(IConfiguration configuration)
    {
        var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
        var db = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
        _types = db.GetCollection<ProductType>(configuration.GetValue<string>("DatabaseSettings:TypesCollectionName"));
    }
    public async Task<IEnumerable<ProductType>> GetAllAsync()
    {
        return await _types.Find(_ => true).ToListAsync();
    }

    public async Task<ProductType> GetByIdAsync(string id)
    {
        return await _types.Find(x => x.Id == id).FirstOrDefaultAsync();
    }
}