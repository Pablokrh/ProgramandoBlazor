using Inmobiliaria.DTO;
using Inmobiliaria.Servicios.Contrato;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inmobiliaria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InmuebleController : ControllerBase
    {

        private readonly IInmuebleServicio _inmuebleServicio;

        public InmuebleController(IInmuebleServicio inmuebleServicio)
        {
            _inmuebleServicio = inmuebleServicio;
        }
        

        [HttpGet("Lista/{buscar?}")]
        public async Task<IActionResult> Lista(string buscar = "NA")
        {
            var response = new ResponseDTO<List<InmuebleDTO>>();

            try
            {
                if (buscar == "NA") buscar = "";
                response.EsCorrecto = true;
                response.Resultado = await _inmuebleServicio.Lista(buscar);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }
            return Ok(response);
        }
        

        [HttpGet("Catalogo/{buscar?}")]
        public async Task<IActionResult> Catalogo(string buscar = "NA")
        {
            var response = new ResponseDTO<List<InmuebleDTO>>();

            try
            {               
                if (buscar == "NA") buscar = "";

                response.EsCorrecto = true;
                response.Resultado = await _inmuebleServicio.Catalogo( buscar);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }
            return Ok(response);
        }

        
        [HttpGet("Obtener/{id:int}")]
        public async Task<IActionResult> Obtener(int id)
        {
            var response = new ResponseDTO<InmuebleDTO>();

            try
            {
                response.EsCorrecto = true;
                response.Resultado = await _inmuebleServicio.Obtener(id);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }
            return Ok(response);
        }
        

        [HttpPost("Crear")]
        public async Task<IActionResult> Crear([FromBody] InmuebleDTO modelo)
        {
            var response = new ResponseDTO<InmuebleDTO>();

            try
            {
                response.EsCorrecto = true;
                response.Resultado = await _inmuebleServicio.Crear(modelo);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }
            return Ok(response);
        }

        [HttpPut("Editar")]
        public async Task<IActionResult> Editar([FromBody] InmuebleDTO modelo)
        {
            var response = new ResponseDTO<bool>();

            try
            {
                response.EsCorrecto = true;
                response.Resultado = await _inmuebleServicio.Editar(modelo);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }
            return Ok(response);
        }

        [HttpDelete("Eliminar/{id:int}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var response = new ResponseDTO<bool>();

            try
            {
                response.EsCorrecto = true;
                response.Resultado = await _inmuebleServicio.Eliminar(id);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }
            return Ok(response);
        }
    }
}
