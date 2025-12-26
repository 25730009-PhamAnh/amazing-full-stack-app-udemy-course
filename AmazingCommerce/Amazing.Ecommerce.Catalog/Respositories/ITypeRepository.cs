using Amazing.Ecommerce.Catalog.Entities;

namespace Amazing.Ecommerce.Catalog.Respositories;

public interface ITypeRepository
{
    Task<IEnumerable<ProductType>> GetAllAsync();
    Task<ProductType> GetByIdAsync(string id);
}