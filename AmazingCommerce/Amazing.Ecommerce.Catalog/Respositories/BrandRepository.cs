using Amazing.Ecommerce.Catalog.Entities;
using MongoDB.Driver;

namespace Amazing.Ecommerce.Catalog.Respositories;

public class BrandRepository : IBranchRepository
{
    private readonly IMongoCollection<ProductBrand> _brands;
    public BrandRepository(IConfiguration configuration)
    {
        var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
        var db = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
        _brands = db.GetCollection<ProductBrand>(configuration.GetValue<string>("DatabaseSettings:BrandsCollectionName"));
    }
    public async Task<IEnumerable<ProductBrand>> GetAllAsync()
    {
        return await _brands.Find(_ => true).ToListAsync();
    }

    public async Task<ProductBrand> GetByIdAsync(string id)
    {
        return await _brands.Find(x => x.Id == id).FirstOrDefaultAsync();
    }
}