using ShopSite_Blazor.Shared;

namespace ShopSite_Blazor.Server.Services.ProductService.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponce<List<Product>>> GetProductsAsync();

        Task<ServiceResponce<Product>> GetProductAsync(int productId);

        Task<ServiceResponce<List<Product>>> GetProductByCategory(string categoryUrl);


    }
}
