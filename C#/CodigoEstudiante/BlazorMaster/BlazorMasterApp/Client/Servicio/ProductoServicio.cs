using BlazorMasterApp.Shared;
using System.Net.Http.Json;

namespace BlazorMasterApp.Client.Servicio
{
    public class ProductoServicio : IProductoServicio
    {
        private readonly HttpClient _http;

        public ProductoServicio(HttpClient http)
        {
            _http = http;
        }


        public async Task<List<ProductoDTO>> lista()
        {
            var lista=new List<ProductoDTO>();
            lista = await _http.GetFromJsonAsync<List<ProductoDTO>>("api/Producto");
            return lista!;
        }
    }
}
