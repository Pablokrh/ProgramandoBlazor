using System.Net.Http.Json;

namespace Blazor_ECommerce_God.Client.Services.ProductService

{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; }=new List<Product>();


        public async Task GetProducts()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            Products = result.Data;
        }

        public async Task<ServiceResponse<Product>> GetSingleProductWithId(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result;
        }      
    }
}
