using APIVersionado.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace APIVersionado.Controllers.V2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]


    public class UsersController : ControllerBase
    {
        private const string ApiTestUrl = "https://dummyapi.io/data/v1/user?limit=30";
        private const string AppId = "64b4c2bc9c54294957bf51a5";

        //Crea una instancia de http Client. Habrá que enviarlo desde program.cs
        private readonly HttpClient _httpClient;

        public UsersController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        [MapToApiVersion("2.0")]
        [HttpGet(Name = "GetUsersData")]

        public async Task<IActionResult> GetUsersDataAsync()
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("app-id", AppId);

            var response = await _httpClient.GetStreamAsync(ApiTestUrl);
            //Acá ya se tendría una respuesta con la lista de usuarios.
            var usersData = await JsonSerializer.DeserializeAsync<UsersResponseData>(response);

            var users = usersData?.data;
            return Ok(users);
        }
    }
}
