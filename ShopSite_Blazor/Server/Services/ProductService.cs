using Microsoft.EntityFrameworkCore;
using ShopSite_Blazor.Server.Data;
using ShopSite_Blazor.Shared;

namespace ShopSite_Blazor.Server.Services
{
    public class ProductService : IProductService
    {

        private readonly DataContext  _context;
        public ProductService(DataContext context) 
        {
            _context = context;
        }
        public async Task<ServiceResponce<List<Product>>> GetProductAsync()
        {
            var responce = new ServiceResponce<List<Product>>
            {
                Data = await _context.Products.ToListAsync(),
            };

            return responce;
            

        }

    
    }
}
