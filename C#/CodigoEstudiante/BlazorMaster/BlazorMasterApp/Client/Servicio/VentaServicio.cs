using BlazorMasterApp.Shared;
using System.Net.Http.Json;

namespace BlazorMasterApp.Client.Servicio
{
    public class VentaServicio:IVentaServicio
    {


        private readonly HttpClient _http;

        public VentaServicio(HttpClient http)
        {
            _http = http;
        }

        public async Task<bool> Guardar(VentaDTO ventaDTO)
        {
            var response = await _http.PostAsJsonAsync("api/Venta", ventaDTO);

            var resultado = response.IsSuccessStatusCode;

            return resultado;



        }
    }
}
