using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorMasterApp.Server.Models;
using Microsoft.EntityFrameworkCore;
using BlazorMasterApp.Shared;

namespace BlazorMasterApp.Server.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {

        private readonly DbpruebaContext _dbContext;

        public VentaController(DbpruebaContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpPost]
        public async Task <IActionResult> Post (VentaDTO ventaDTO)
        {
            try
            {
                var mdventa = new Venta();
                var mdDetalleVenta = new List<DetalleVenta>();

                mdventa.Cliente=ventaDTO.Cliente;
                mdventa.Total=ventaDTO.Total;

                foreach (var item in ventaDTO.DetalleVenta)
                {
                    mdDetalleVenta.Add(new DetalleVenta
                    {
                        IdProducto=item.Producto.IdProducto,
                        Cantidad=item.Cantidad,
                        SubTotal=item.SubTotal
                    });
                }
                mdventa.DetalleVenta = mdDetalleVenta;
                _dbContext.Venta.Add(mdventa);
                await _dbContext.SaveChangesAsync();
                return Ok();
            }

            catch (Exception ex) 
            {
                return BadRequest(ex);
            }

        }


    }
}
