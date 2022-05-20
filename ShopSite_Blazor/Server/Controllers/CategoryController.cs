using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopSite_Blazor.Server.Services.CategoryService;
using ShopSite_Blazor.Shared;

namespace ShopSite_Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponce<List<Category>>>> GetCategories()
        { 
        var result = await _categoryService.GetCategories();
            return Ok(result);
        }
    }
}
