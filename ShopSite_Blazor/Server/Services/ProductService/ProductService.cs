using Microsoft.EntityFrameworkCore;
using ShopSite_Blazor.Server.Data;
using ShopSite_Blazor.Server.Services.ProductService.ProductService;
using ShopSite_Blazor.Shared;

namespace ShopSite_Blazor.Server
{
    public class ProductService : IProductService
    {

        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponce<Product>> GetProductAsync(int productId)
        {
            var responce = new ServiceResponce<Product>();
            var product = await _context.Products.FindAsync(productId);

            if (product == null)
            {
                responce.Success = false;
                responce.Massege = "Sorry Product doesn't found";
            }
            else
            {
                responce.Data = product;
            }
            return responce;
        }

        public async Task<ServiceResponce<List<Product>>> GetProductByCategory(string categoryUrl)
        {
            var response = new ServiceResponce<List<Product>>
            {
             Data = await _context.Products
            .Where(p => p.Category.Url.ToLower()
            .Equals(categoryUrl.ToLower()))
            .ToListAsync()
            };

        return response;

        }

        public async Task<ServiceResponce<List<Product>>> GetProductsAsync()
        {
            var responce = new ServiceResponce<List<Product>>
            {
                Data = await _context.Products.ToListAsync(),
            };

            return responce;


        }


    }
}
