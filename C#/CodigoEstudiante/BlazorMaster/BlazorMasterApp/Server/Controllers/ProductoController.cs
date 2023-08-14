using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorMasterApp.Server.Models;
using Microsoft.EntityFrameworkCore;
using BlazorMasterApp.Shared;

namespace BlazorMasterApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly DbpruebaContext _dbContext;

        public ProductoController(DbpruebaContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task <IActionResult> Get()
        {
            var lista=new List<ProductoDTO>();

            //Este es el "reemplazo del automapper. Lo hace así ya que le llevaría mas tiempo.
            foreach (var item in await _dbContext.Productos.ToListAsync())
            {
                lista.Add(new ProductoDTO
                {
                    IdProducto = item.IdProducto,
                    Nombre = item.Nombre,
                    Precio = item.Precio,
                });

            }
            return Ok(lista);


        }


    }
}
