using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json;
using APIVersionado.DTO;

namespace APIVersionado.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private const string ApiTestUrl = "https://dummyapi.io/data/v1/user?limit=10";
        private const string AppId = "64b4c2bc9c54294957bf51a5";

        //Crea una instancia de http Client. Habrá que enviarlo desde program.cs
        private readonly HttpClient _httpClient;

        public UsersController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [MapToApiVersion("1.0")]
        [HttpGet]
        public async Task <IActionResult> GetUsersDataAsync()
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("app-id", AppId);
            //Acá ya se tendría una respuesta con la lista de usuarios.

            var response = await _httpClient.GetStreamAsync(ApiTestUrl);
            var usersData = await JsonSerializer.DeserializeAsync<UsersResponseData>(response);
            return Ok(usersData);
        }
    }
}
