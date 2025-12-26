using Amazing.Ecommerce.Catalog.Entities;

namespace Amazing.Ecommerce.Catalog.Respositories;

public interface IBranchRepository
{
    Task<IEnumerable<ProductBrand>> GetAllAsync();
    Task<ProductBrand> GetByIdAsync(string id);
}