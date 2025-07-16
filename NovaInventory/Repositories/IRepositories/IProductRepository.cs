using NovaInventory.Data;
using NovaInventory.Models.Entities;

namespace NovaInventory.Repositories.IRepositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>?> ObtainAllProducts();
        Task<Product?> GetProductByName(string ClientName);
        Task AddProduct(Product product);
        Task RemoveClient(Product product);
        Task UpdateProductStatus(Product product, int StatusId);
    }   
}