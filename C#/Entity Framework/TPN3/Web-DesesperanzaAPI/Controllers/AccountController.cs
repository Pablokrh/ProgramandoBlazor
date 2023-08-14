using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Web_DesesperanzaAPI.DataAccess;
using Web_DesesperanzaAPI.Helpers;
using Web_DesesperanzaAPI.Models;

namespace Web_DesesperanzaAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class AccountController:ControllerBase
    {
        private readonly UniversityContext _context;
        private readonly JwtSettings _jwtSettings;


        public AccountController(JwtSettings jwtSettings, UniversityContext context)
        {
            _jwtSettings = jwtSettings;
            _context = context;
        }

        private IEnumerable<User> Logins = new List<User>()
        {
            new User()
            {
                Id = 1,
                Email="pablokrh@gmail.com",
                Name="Admin",
                Password="Admin"
            },
            new User()
            {
                Id = 2,
                Email="pepe@gmail.com",
                Name="User 1",
                Password="Pepe"
            }

        };
        [HttpPost]
        public IActionResult GetToken(UserLogins userLogin)
        {
            try
            {
               var token = new UserTokens();

               var searchUser =  (from user in _context.Users
                                 where user.Name == userLogin.UserName
                                 && user.Password == userLogin.Password
                                 select user).FirstOrDefault();
                //Sin el FirstOrDefault() no se bien por qué te tira error después. Creo que no te devuelve un 
                //objeto de tipo User, sino algún tipo de IQueryable, por eso no se puede usar. Así si.

                if (searchUser != null)
                {             
                    token = JWTHelpers.GenTokenKeys(new UserTokens()
                    {
                        Username = searchUser.Name,
                        EmailId = searchUser.Email,
                        Id = searchUser.Id,
                        GuidId = Guid.NewGuid()
                    }, _jwtSettings);                
                }
                else
                {
                    return BadRequest("Wrong Credentials");
                }
                return Ok(token);

            }
            catch (Exception ex)
            {
                throw new Exception("Get token error: " + ex);
            }
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes =JwtBearerDefaults.AuthenticationScheme,Roles ="Administrator")]
        //A esta ruta solo accede el rol de administrador.
        public IActionResult GetUserList()
        {
            return Ok(Logins);
        }    
    }
}
