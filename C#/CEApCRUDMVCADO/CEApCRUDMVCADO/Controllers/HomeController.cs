using CEApCRUDMVCADO.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CEApCRUDMVCADO.Repositorios.Contrato;

namespace CEApCRUDMVCADO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGenericRepository<Departamento> _departamentoRepository;
        private readonly IGenericRepository<Empleado> _empleadoRepository;
        //Construttore
        public HomeController(ILogger<HomeController> logger, 
            IGenericRepository<Departamento> departamentoRepository, 
            IGenericRepository<Empleado> empleadoRepository)
        {
            _logger = logger;
            _departamentoRepository = departamentoRepository;
            _empleadoRepository = empleadoRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task <IActionResult> ListaDepartamentos()
        {
            List<Departamento> listadepartamentos = await _departamentoRepository.GetLista();
            //LLama al método getlista y lo retorna pero con el mensajito este de status.
            return StatusCode(StatusCodes.Status200OK, listadepartamentos);
        }

        [HttpGet]
        public async Task<IActionResult> ListaEmpleados()
        {
            List<Empleado> listaEmpleados = await _empleadoRepository.GetLista();
            return StatusCode(StatusCodes.Status200OK, listaEmpleados);
        }

        [HttpPost]
        public async Task<IActionResult> GuardarEmpleado( Empleado modelo)
        {
            bool resultado= await _empleadoRepository.Guardar(modelo);
            if (resultado)
            {
                return StatusCode(StatusCodes.Status200OK, new { valor = resultado, msg = "Ok" });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { valor = resultado, msg = "Error" });
            }
        }
        [HttpPut]
        public async Task<IActionResult> EditarEmpleado([FromBody] Empleado modelo)
        {
            bool resultado = await _empleadoRepository.Guardar(modelo);
            if (resultado)
            {
                return StatusCode(StatusCodes.Status200OK, new { valor = resultado, msg = "Ok" });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { valor = resultado, msg = "Error" });
            }
        }

        [HttpDelete]
        public async Task<IActionResult> EliminarEmpleado([FromBody] int idEmpleado)
        {
            bool resultado = await _empleadoRepository.Eliminar(idEmpleado);
            if (resultado)
            {
                return StatusCode(StatusCodes.Status200OK, new { valor = resultado, msg = "Ok" });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { valor = resultado, msg = "Error" });
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}