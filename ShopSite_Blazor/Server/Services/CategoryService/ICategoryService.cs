using ShopSite_Blazor.Shared;

namespace ShopSite_Blazor.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponce<List<Category>>> GetCategories();
    }
}
