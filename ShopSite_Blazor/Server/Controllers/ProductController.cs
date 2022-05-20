using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopSite_Blazor.Server.Data;
using ShopSite_Blazor.Server.Services.ProductService.ProductService;
using ShopSite_Blazor.Shared;

namespace ShopSite_Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService ProductService)
        {
            _productService = ProductService;

        }

        [HttpGet]

        public async Task<ActionResult<ServiceResponce<List<Product>>>> GetProducts()
         {
            var result = await _productService.GetProductsAsync();
           
            return Ok(result);

         }


        [HttpGet("{productId}")]
        public async Task<ActionResult<ServiceResponce<Product>>> GetProduct(int productId)
        {
            var result = await _productService.GetProductAsync(productId);
            return Ok(result);
        }

        [HttpGet("category/{categoryUrl}")]
        public async Task<ActionResult<ServiceResponce<List<Product>>>> GetProductsByCategory(string categoryUrl)
        {
            var result = await _productService.GetProductByCategory(categoryUrl);
            return Ok(result);
        }


        
      


    }
}
