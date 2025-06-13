

using Core.Entities;

namespace Core.Interfaces;

public interface IProductsRepository
{

    Task<IReadOnlyList<Product>> GetProductsAsync(string? brand, string? type, string? sort);
    Task<Product?> GetProductByIdAsync(int id);
    Task<IReadOnlyList<string>> GetBrandsAsync();
    Task<IReadOnlyList<string>> GetTypesAsync();

    void AddProduct(Product produce);

    void UpdateProduct(Product product);

    void DeleteProduct(Product product);

    bool ProductExists(int id);
    Task<bool> SaveChangesAsync();

}
