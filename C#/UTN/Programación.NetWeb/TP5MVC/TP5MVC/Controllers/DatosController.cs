using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics.Metrics;
using TP5MVC.Models;


namespace TP5MVC.Controllers
{
    public class DatosController : Controller
    {
        private readonly Tpn5Context _context;

        public DatosController(Tpn5Context context)
        {
            _context = context;
        }

        // GET: DatosController
        public async Task<ActionResult> MostrarData()
        {
            return View(await _context.Usuarios.ToListAsync());
        }

        // GET: DatosController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Usuario model)
        {
            if (ModelState.IsValid)
            {
                var id = (from idMax in _context.Usuarios
                         select idMax.Id).Max();

                Usuario nuevoUsuario = new Usuario();      
                nuevoUsuario.Id= id;
                nuevoUsuario.Nombre= model.Nombre;
                nuevoUsuario.Apellido= model.Apellido;
                nuevoUsuario.Edad= model.Edad;

                _context.Usuarios.Add(nuevoUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(MostrarData));

            }
            
           
            return View();
        }

        
        // GET: DatosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

       
        /*
        // POST: DatosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DatosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DatosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DatosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DatosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}
