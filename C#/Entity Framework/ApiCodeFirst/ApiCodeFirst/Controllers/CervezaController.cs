using BD;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CervezaController : ControllerBase
    {
        private BolsaDeDatosContext _context;

        public CervezaController(BolsaDeDatosContext context)
        {
            _context = context;
        
        }

        [HttpGet]
        public IEnumerable<Cerveza> Get() => _context.Cervezas.ToList();

    }
}
