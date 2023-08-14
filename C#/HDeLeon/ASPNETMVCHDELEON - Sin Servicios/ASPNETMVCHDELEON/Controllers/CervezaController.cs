using ASPNETMVCHDELEON.Models;
using ASPNETMVCHDELEON.Models.ViewModel;
using ASPNETMVCHDELEON.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Scaffolding;
using System.Collections.Immutable;

namespace ASPNETMVCHDELEON.Controllers
{
    public partial class CervezaController : Controller
    {
        private readonly CervezaService _service;
        public CervezaController(CervezaService service)
        {
            _service = service;
        }   


        public async Task <IActionResult> Index()
        {            
            return View(await _service.Index());
        }

        
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Brands"] = new SelectList(_service.Create(), "BrandId", "Name" );
            return View(); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Create(CervezaViewModel model)
        {
            if(ModelState.IsValid)
            {
               var beer= await _service.Create(model);       
               return RedirectToAction(nameof(Index));

            }
            ViewData["Brands"] = new SelectList(_service.Create(), "BrandId", "Name");

            return View(model);
        }
    }
}
