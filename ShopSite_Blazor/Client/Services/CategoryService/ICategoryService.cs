using ShopSite_Blazor.Shared;

namespace ShopSite_Blazor.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        public List<Category> Categories { get; set; }

        Task GetCategories();


    }
}
