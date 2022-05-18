using ShopSite_Blazor.Shared;
using System.Net.Http.Json;

namespace ShopSite_Blazor.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;
        public ProductService(HttpClient Http)
        {
            _http = Http;
        }

        public List<Product> Products { get; set; } = new List<Product>();
        public async Task GetProducts()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponce<List<Product>>>("api/Product");
            {
                if (result != null && result.Data != null)
                    Products = result.Data;


            }
        }
    }
}
