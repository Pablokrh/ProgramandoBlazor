using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorCrudServer.Models;
using BlazorCrudShared;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private readonly CrudBlazorContext _context;

        public DepartamentoController(CrudBlazorContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            var responseApi = new ResponseApi<List<DepartamentoDTO>>();
            var listaDepartamentoDTO=new List<DepartamentoDTO>();
            try
            {
                foreach (var item in await _context.Departamentos.ToListAsync())
                {
                    listaDepartamentoDTO.Add(new DepartamentoDTO
                    {
                        IdDepartamento = item.IdDepartamento,
                        Nombre=item.Nombre,

                    });
                }
                responseApi.EsCorrecto = true;
                responseApi.Valor = listaDepartamentoDTO;
            }
            catch (Exception ex)
            {
                responseApi.EsCorrecto = false;
                responseApi.Mensaje = ex.Message;
            }
            return Ok(responseApi); 
        }
    }
}
