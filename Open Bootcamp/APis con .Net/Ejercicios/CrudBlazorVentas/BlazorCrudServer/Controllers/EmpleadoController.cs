using BlazorCrudServer.Models;
using BlazorCrudShared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace BlazorCrudServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly CrudBlazorContext _context;

        public EmpleadoController(CrudBlazorContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            var responseApi = new ResponseApi<List<EmpleadoDTO>>();
            var listaEmpleadoDTO = new List<EmpleadoDTO>();
            try
            {
                foreach (var item in await _context.Empleados.Include(d=>d.IdDepartamentoNavigation).ToListAsync())
                {
                    listaEmpleadoDTO.Add(new EmpleadoDTO
                    {
                      IdEmpleado=item.IdEmpleado,
                      NombreCompleto=item.NombreCompleto,
                      IdDepartamento=item.IdDepartamento,
                      Sueldo=item.Sueldo,
                      FechaContrato=item.FechaContrato,
                      Departamento=new DepartamentoDTO
                      {
                          IdDepartamento=item.IdDepartamentoNavigation.IdDepartamento,
                          Nombre=item.IdDepartamentoNavigation.Nombre
                      }
                    });
                }
                responseApi.EsCorrecto = true;
                responseApi.Valor = listaEmpleadoDTO;
            }
            catch (Exception ex)
            {
                responseApi.EsCorrecto = false;
                responseApi.Mensaje = ex.Message;
            }
            return Ok(responseApi);
        }


        [HttpGet]
        [Route("Buscar/{Id}")]
        public async Task<IActionResult> Lista(int id)
        {
            var responseApi = new ResponseApi<EmpleadoDTO>();
            var empleadoDTO = new EmpleadoDTO();

            try
            {
                var dbEmpleado = await _context.Empleados.FirstOrDefaultAsync(x => x.IdEmpleado == id);
                if (dbEmpleado != null)
                {
                    empleadoDTO.IdEmpleado = dbEmpleado.IdEmpleado;
                    empleadoDTO.NombreCompleto = dbEmpleado.NombreCompleto;
                    empleadoDTO.IdDepartamento = dbEmpleado.IdDepartamento;
                    empleadoDTO.Sueldo = dbEmpleado.Sueldo;
                    empleadoDTO.FechaContrato = dbEmpleado.FechaContrato;
                    responseApi.EsCorrecto = true;
                    responseApi.Valor = empleadoDTO;
                }
                else
                {
                    responseApi.Mensaje = "Empleado no encontrado";
                }

            }
            catch (Exception ex)
            {
                responseApi.EsCorrecto = false;
                responseApi.Mensaje = ex.Message;
            }
            return Ok(responseApi);            
        }



        [HttpPost   ]
        [Route("Guardar")]
        public async Task<IActionResult> Guardar(EmpleadoDTO empleado)
        {
            var responseApi = new ResponseApi<int>();

            try
            {
                //Acá se convierte de tipo Empleado a tipo Empleado DTO
                var dbEmpleado = new Empleado
                {
                    NombreCompleto = empleado.NombreCompleto,
                    IdDepartamento = empleado.IdDepartamento,
                    Sueldo = empleado.Sueldo,
                    FechaContrato = empleado.FechaContrato,
                };
                _context.Empleados.Add(dbEmpleado);
                await _context.SaveChangesAsync();

                if (dbEmpleado.IdEmpleado != 0)
                {
                    responseApi.EsCorrecto = true;
                    responseApi.Valor = dbEmpleado.IdEmpleado;
                }
                else
                {
                    responseApi.EsCorrecto = false;
                    responseApi.Mensaje = "No guardado";
                }
            }
            catch (Exception ex)
            {
                responseApi.EsCorrecto = false;
                responseApi.Mensaje = ex.Message;
            }
            return Ok(responseApi);
        }


        [HttpPut]
        [Route("Editar/{id}")]
        public async Task<IActionResult> Editar(EmpleadoDTO empleado, int id)
        {
            var responseApi = new ResponseApi<int>();

            try
            {
                var dbEmpleado = await _context.Empleados.FirstOrDefaultAsync(emp => emp.IdEmpleado == id);

                if (dbEmpleado!= null)
                {
                    dbEmpleado.Sueldo=empleado.Sueldo;
                    dbEmpleado.NombreCompleto=empleado.NombreCompleto;
                    dbEmpleado.IdDepartamento = empleado.IdDepartamento;
                    dbEmpleado.FechaContrato=empleado.FechaContrato;

                    _context.Empleados.Update(dbEmpleado);
                    await _context.SaveChangesAsync();

                    responseApi.EsCorrecto = true;
                    responseApi.Valor = dbEmpleado.IdEmpleado;
                }
            
                else
                {
                    responseApi.EsCorrecto = false;
                    responseApi.Mensaje = "Empleado no encontrado";
                }
            }
            catch (Exception ex)
            {
                responseApi.EsCorrecto = false;
                responseApi.Mensaje = ex.Message;
            }
            return Ok(responseApi);
        }


        [HttpDelete]
        [Route("Eliminar/{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var responseApi = new ResponseApi<int>();

            try
            {                                                
                var dbEmpleado = await _context.Empleados.FirstOrDefaultAsync(emp => emp.IdEmpleado == id);

                if (dbEmpleado != null)
                {                  
                    _context.Empleados.Remove(dbEmpleado);
                    await _context.SaveChangesAsync();
                    responseApi.EsCorrecto = true;
                }

                else
                {
                    responseApi.EsCorrecto = false;
                    responseApi.Mensaje = "Empleado no encontrado";
                }
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
