using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PabloPizzea.Shared;
using PabloPizzea.Server.Models;

namespace PabloPizzea.Server.Controllers
{
    [Route("specials")]
    [ApiController]
    public class SpecialsController : ControllerBase
    {
        private readonly PizzaStoreContext _dbContext;

        //Constructor lambdificado
        public SpecialsController(PizzaStoreContext dbContext) {
            _dbContext = dbContext;
        }

        
        [HttpGet]
        public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
        {
            return await _dbContext.Specials.
                OrderByDescending(x => x.BasePrice).ToListAsync();
                

        }

        

    }
}
