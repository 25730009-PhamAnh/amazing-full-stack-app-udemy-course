using Amazing.Ecommerce.Catalog.Entities;
using Amazing.Ecommerce.Catalog.Specifications;

namespace Amazing.Ecommerce.Catalog.Respositories;

public interface IProductRepository
{
    Task<Pagination<Product>> GetProductsAsync(int pageIndex, int pageSize);
    Task<IEnumerable<Product>> GetAllAsync();
    Task<IEnumerable<Product>> GetByTypeAsync(string name);
    Task<IEnumerable<Product>> GetByNameAsync(string name);
    Task<IEnumerable<Product>> GetByBrandAsync(string name);
    Task<Product> GetByIdAsync(string id);
    Task<Product> CreateAsync(Product product);
    Task<Product> UpdateAsync(Product product);
    Task<bool> DeleteAsync(string id);
}