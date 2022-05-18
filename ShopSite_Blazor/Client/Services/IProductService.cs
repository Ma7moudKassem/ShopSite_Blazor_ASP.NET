using ShopSite_Blazor.Shared;

namespace ShopSite_Blazor.Client.Services
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        Task GetProducts();
    }
}
