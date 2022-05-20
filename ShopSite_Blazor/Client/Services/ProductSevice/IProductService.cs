using ShopSite_Blazor.Shared;

namespace ShopSite_Blazor.Client.Services.ProductSevice
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        Task GetProducts();

        Task<ServiceResponce<Product>> GetProduct(int productId);
    }
}
