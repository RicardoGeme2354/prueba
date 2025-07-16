using NovaInventory.Models.Entities;
using NovaInventory.Repositories.IRepositories;
using NovaInventory.Services.IServices;

namespace NovaInventory.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _IProductRepository;

        public ProductService(IProductRepository IProductRepository)
        {
            _IProductRepository = IProductRepository;
        }
        public async Task AddProduct(string ProductName)
        {
            Product NewProduct = new Product
            {
                productName = ProductName,
                stateId = 1
            };

            await _IProductRepository.AddProduct(NewProduct);
        }

        public async Task<Product?> GetProductByName(string ProductName)
        {
            return await _IProductRepository.GetProductByName(ProductName);
        }

        public async Task<IEnumerable<Product>?> ObtainAllProducts()
        {
            return await _IProductRepository.ObtainAllProducts();
        }

        public async Task RemoveProduct(Product product)
        {
            await _IProductRepository.RemoveClient(product);
        }

        public async Task UpdateProductStatus(Product product, int StatusId)
        {
            await _IProductRepository.UpdateProductStatus(product, StatusId);
        }
    }
}