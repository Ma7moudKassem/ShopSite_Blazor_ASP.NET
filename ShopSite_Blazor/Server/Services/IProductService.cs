using ShopSite_Blazor.Shared;

namespace ShopSite_Blazor.Server.Services
{
    public interface IProductService
    {
        Task<ServiceResponce<List<Product>>> GetProductAsync();
    }
}
