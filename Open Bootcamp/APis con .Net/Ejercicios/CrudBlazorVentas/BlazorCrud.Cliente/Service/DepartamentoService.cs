using BlazorCrudShared;
using System.Net.Http.Json;

namespace BlazorCrud.Cliente.Service
{
    public class DepartamentoService:IDepartamentoService
    {
        private readonly HttpClient _http;

        public DepartamentoService(HttpClient https)
        {
            _http = https;
        }

        public async Task<List<DepartamentoDTO>> Lista()
        {
            var result = await _http.GetFromJsonAsync<ResponseApi<List<DepartamentoDTO>>>("api/Departamento/Lista");

            if (result!.EsCorrecto) return result.Valor!;
            else throw new Exception(result.Mensaje);
        }
    }
}
