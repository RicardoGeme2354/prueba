using NovaInventory.Models.Entities;

namespace NovaInventory.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<Product>?> ObtainAllProducts();
        Task<Product?> GetProductByName(string ProductName);
        Task AddProduct(string ProductName);
        Task RemoveProduct(Product product);
        Task UpdateProductStatus(Product product, int StatusId);
    }
}