using ShopSite_Blazor.Shared;

namespace ShopSite_Blazor.Client.Services.ProductSevice
{
    public interface IProductService
    {
        event Action ProductChange;
        List<Product> Products { get; set; }

        Task GetProducts(string? categoryUrl = null);

        Task<ServiceResponce<Product>> GetProduct(int productId);
    }
}
