using ASPNETMVCHDELEON.Models;
using ASPNETMVCHDELEON.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Scaffolding;
using MVC.Models;
using System.Collections.Immutable;

namespace ASPNETMVCHDELEON.Controllers
{
    public partial class CervezaController : Controller
    {
        private readonly BeerYbrandContext _context;

        public CervezaController(BeerYbrandContext context)
        {
            _context = context;
        }

        public async Task <IActionResult> Index()
        {
            var beers = _context.Cervezas.Include(b => b.Brand);
            return View(await beers.ToListAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Brands"] = new SelectList(_context.Brands, "BrandId", "Name" );
            return View(); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Create(CervezaViewModel model)
        {/*
            if(ModelState.IsValid)
            {
                var beer = new Cerveza()
                {
                    Name = model.Name,
                    BrandId = model.BrandId,                   
                  
                };
                //Opción larga y opción corta:
                _context.Cervezas.Add(beer);
                //_context.Add(beer);
                //Con esta última se agrega a la BBDD con EF:
                await _context.SaveChangesAsync();
                //Index es el método de arriba, que te lleva a la viste de la tabla de cervezas
                return RedirectToAction(nameof(Index));

            }

            ViewData["Brands"] = new SelectList(_context.Brands, "BrandId", "Name", model.BrandId);
            */
            return View(model);
        }
    }
}
