using ShopSite_Blazor.Shared;
using System.Net.Http.Json;

namespace ShopSite_Blazor.Client.Services.ProductSevice
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;
        public ProductService(HttpClient Http)
        {
            _http = Http;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public event Action ProductChange;

        public async Task<ServiceResponce<Product>> GetProduct(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponce<Product>>($"api/Product/{productId}");
            return result;
        }


        public async Task GetProducts(string? categoryUrl = null)
        {
            var result = categoryUrl == null ? 
                await _http.GetFromJsonAsync<ServiceResponce<List<Product>>>("api/Product") : 
                await _http.GetFromJsonAsync<ServiceResponce<List<Product>>>($"api/Product/category/{categoryUrl}");
            {
                if (result != null && result.Data != null)
                    Products = result.Data;


            }

            ProductChange.Invoke();
        }

     
    }
}
