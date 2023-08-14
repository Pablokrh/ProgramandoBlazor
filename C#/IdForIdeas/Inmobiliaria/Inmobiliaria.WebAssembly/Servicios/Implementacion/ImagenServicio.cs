using Inmobiliaria.DTO;
using Inmobiliaria.WebAssembly.Servicios.Contrato;
using System.Net.Http.Json;

namespace Inmobiliaria.WebAssembly.Servicios.Implementacion
{
    public class ImagenServicio : IImagenServicio
    {

        private readonly HttpClient _httpClient;

        public ImagenServicio(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseDTO<ImagenDTO>> Crear(ImagenDTO modelo)
        {
            var response = await _httpClient.PostAsJsonAsync("Imagen/Crear", modelo);
            var result = await response.Content.ReadFromJsonAsync<ResponseDTO<ImagenDTO>>();
            return result!;
        }

        public async Task<ResponseDTO<bool>> Editar(ImagenDTO modelo)
        {
            var response = await _httpClient.PutAsJsonAsync("Imagen/Editar", modelo);
            var result = await response.Content.ReadFromJsonAsync<ResponseDTO<bool>>();
            return result!;
        }

        public async Task<ResponseDTO<bool>> Eliminar(int id)
        {
            return await _httpClient.DeleteFromJsonAsync<ResponseDTO<bool>>($"Imagen/Eliminar/{id}");
        }

        public async Task<ResponseDTO<List<ImagenDTO>>> Lista(string buscar)
        {
            return await _httpClient.GetFromJsonAsync<ResponseDTO<List<ImagenDTO>>>($"Imagen/Lista/{buscar}");
        }

        public async Task<ResponseDTO<ImagenDTO>> Obtener(int id)
        {
            return await _httpClient.GetFromJsonAsync<ResponseDTO<ImagenDTO>>($"Imagen/Obtener/{id}");
        }

        public async Task<ResponseDTO<ImagenDTO>> ObtenerImagenPrincipal(int id)
        {
            return await _httpClient.GetFromJsonAsync<ResponseDTO<ImagenDTO>>($"Imagen/ObtenerImagenPrincipal/{id}");
        }

        public async Task<ResponseDTO<List<ImagenDTO>>> ObtenerLista(int id)
        {
            return await _httpClient.GetFromJsonAsync<ResponseDTO<List<ImagenDTO>>>($"Imagen/ObtenerLista/{id}");
        }
    }
}
