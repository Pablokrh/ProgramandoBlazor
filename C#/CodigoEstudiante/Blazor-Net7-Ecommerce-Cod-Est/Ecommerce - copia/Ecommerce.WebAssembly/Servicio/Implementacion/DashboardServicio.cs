using Ecommerce.DTO;
using Ecommerce.WebAssembly.Servicio.Contrato;
using System.Net.Http.Json;

namespace Ecommerce.WebAssembly.Servicio.Implementacion
{
    public class DashboardServicio:IDashBoardServicio
    {

        private readonly HttpClient _httpClient;

        public DashboardServicio(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseDTO<DashBoardDTO>> Resumen()
        {
            return await _httpClient.GetFromJsonAsync<ResponseDTO<DashBoardDTO>>($"Dashboard/Resumen");
        }
    }
}
