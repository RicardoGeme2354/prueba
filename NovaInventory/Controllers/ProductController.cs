using Microsoft.AspNetCore.Mvc;
using NovaInventory.Services.IServices;

namespace NovaInventory.Controllers
{
    [Route("api/[Controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _ProductService;

        public ProductController(IProductService ProductService)
        {
            _ProductService = ProductService;
        }

        [HttpGet("find-all-products")]
        public async Task<IActionResult> FindAllProducts()
        {
            var AllProducts = await _ProductService.ObtainAllProducts();

            if (AllProducts == null || !AllProducts.Any())
            {
                return NotFound("No se encontraron productos!");
            }

            return Ok(AllProducts);
        }

        [HttpPost("add-product/{ProductName}")]
        public async Task<IActionResult> AddProduct(string ProductName)
        {
            await _ProductService.AddProduct(ProductName);

            return Ok();
        }

        [HttpDelete("delete-product/{Product}")]
        public async Task<IActionResult> DeleteProduct(string Product)
        {
            var FindProduct = await _ProductService.GetProductByName(Product);

            if (FindProduct == null)
            {
                return NotFound("No se encontro el producto!");
            }

            await _ProductService.RemoveProduct(FindProduct);

            return Ok();
        }

        [HttpPatch("update-product/{Product}/{StateId}")]
        public async Task<IActionResult> UpdateUserState(string Product, int StateId)
        {
            var FindProduct = await _ProductService.GetProductByName(Product);

            if (FindProduct == null)
            {
                return NotFound("No se encontro el producto!");
            }

            await _ProductService.UpdateProductStatus(FindProduct, StateId);

            return Ok();
        }
    }
}