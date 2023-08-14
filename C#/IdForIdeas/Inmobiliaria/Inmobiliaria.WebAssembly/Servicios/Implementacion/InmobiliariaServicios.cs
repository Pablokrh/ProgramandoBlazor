using Inmobiliaria.DTO;
using Inmobiliaria.WebAssembly.Servicios.Contrato;
using System.Net.Http.Json;

namespace Inmobiliaria.WebAssembly.Servicios.Implementacion
{
    public class InmobiliariaServicios:IInmobiliariaServicios
    {

        private readonly HttpClient _httpClient;

        public InmobiliariaServicios(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseDTO<List<InmuebleDTO>>> Catalogo( string buscar)
        {
            return await _httpClient.GetFromJsonAsync<ResponseDTO<List<InmuebleDTO>>>($"Inmueble/Catalogo/{buscar}");
        }

        public async Task<ResponseDTO<InmuebleDTO>> Crear(InmuebleDTO modelo)
        {
            var response = await _httpClient.PostAsJsonAsync("Inmueble/Crear", modelo);
            var result = await response.Content.ReadFromJsonAsync<ResponseDTO<InmuebleDTO>>();
            return result!;
        }

        public async Task<ResponseDTO<bool>> Editar(InmuebleDTO modelo)
        {
            var response = await _httpClient.PutAsJsonAsync("Inmueble/Editar", modelo);
            var result = await response.Content.ReadFromJsonAsync<ResponseDTO<bool>>();
            return result!;
        }

        public async Task<ResponseDTO<bool>> Eliminar(int id)
        {
            return await _httpClient.DeleteFromJsonAsync<ResponseDTO<bool>>($"Inmueble/Eliminar/{id}");
        }

        public async Task<ResponseDTO<List<InmuebleDTO>>> Lista(string buscar)
        {
            return await _httpClient.GetFromJsonAsync<ResponseDTO<List<InmuebleDTO>>>($"Inmueble/Lista/{buscar}");


        }

        public async Task<ResponseDTO<InmuebleDTO>> Obtener(int id)
        {
            return await _httpClient.GetFromJsonAsync<ResponseDTO<InmuebleDTO>>($"Inmueble/Obtener/{id}");
        }
    }
}
