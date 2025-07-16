using Microsoft.EntityFrameworkCore;
using NovaInventory.Data;
using NovaInventory.Models.Entities;
using NovaInventory.Repositories.IRepositories;

namespace NovaInventory.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly NovaInventoryDbContext _NovaInventoryDbContext;

        public ProductRepository(NovaInventoryDbContext NovaInventoryDbContext)
        {
            _NovaInventoryDbContext = NovaInventoryDbContext;
        }

        public async Task AddProduct(Product product)
        {
            await _NovaInventoryDbContext.Products.AddAsync(product);
            await _NovaInventoryDbContext.SaveChangesAsync();
        }

        public async Task<Product?> GetProductByName(string productName)
        {
            return await _NovaInventoryDbContext.Products
                .FirstOrDefaultAsync(product => product.productName == productName);
        }

        public async Task<IEnumerable<Product>?> ObtainAllProducts()
        {
            return await _NovaInventoryDbContext.Products
                .ToListAsync();
        }

        public async Task RemoveClient(Product product)
        {
            _NovaInventoryDbContext.Remove(product);
            await _NovaInventoryDbContext.SaveChangesAsync();
        }

        public async Task UpdateProductStatus(Product product, int StatusId)
        {
            product.stateId = StatusId;
            _NovaInventoryDbContext.Update(product);
            await _NovaInventoryDbContext.SaveChangesAsync();
        }
    }
}