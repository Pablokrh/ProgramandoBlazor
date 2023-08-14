using Inmobiliaria.DTO;
using Inmobiliaria.Servicios.Contrato;
using Inmobiliaria.Servicios.Implementacion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inmobiliaria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagenController : ControllerBase
    {
        private readonly IImagenServicio _imagenServicio;

        public ImagenController(IImagenServicio imagenServicio)
        {
            _imagenServicio = imagenServicio;
        }

        [HttpGet("Lista/{buscar?}")]
        public async Task<IActionResult> Lista(string buscar = "NA")
        {
            var response = new ResponseDTO<List<ImagenDTO>>();

            try
            {
                if (buscar == "NA") buscar = "";
                response.EsCorrecto = true;
                response.Resultado = await _imagenServicio.Lista(buscar);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }
            return Ok(response);
        }

        [HttpGet("ObtenerLista/{id:int}")]
        public async Task<IActionResult> ObtenerLista(int id )
        {
            var response = new ResponseDTO<List<ImagenDTO>>();

            try
            {               
                response.EsCorrecto = true;
                response.Resultado = await _imagenServicio.ObtenerLista(id);
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
            var response = new ResponseDTO<ImagenDTO>();

            try
            {
                response.EsCorrecto = true;
                response.Resultado = await _imagenServicio.Obtener(id);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }
            return Ok(response);
        }

        [HttpGet("ObtenerImagenPrincipal/{id:int}")]
        public async Task<IActionResult> ObtenerImagenPrincipal(int id)
        {
            var response = new ResponseDTO<ImagenDTO>();

            try
            {
                response.EsCorrecto = true;
                response.Resultado = await _imagenServicio.ImagenPrincipal(id);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }
            return Ok(response);
        }

        [HttpPost("Crear")]
        public async Task<IActionResult> Crear([FromBody] ImagenDTO modelo)
        {
            var response = new ResponseDTO<ImagenDTO>();

            try
            {
                response.EsCorrecto = true;
                response.Resultado = await _imagenServicio.Crear(modelo);
            }
            catch (Exception ex)
            {
                response.EsCorrecto = false;
                response.Mensaje = ex.Message;
            }
            return Ok(response);
        }


        [HttpPut("Editar")]
        public async Task<IActionResult> Editar([FromBody] ImagenDTO modelo)
        {
            var response = new ResponseDTO<bool>();

            try
            {
                response.EsCorrecto = true;
                response.Resultado = await _imagenServicio.Editar(modelo);
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
                response.Resultado = await _imagenServicio.Eliminar(id);
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
