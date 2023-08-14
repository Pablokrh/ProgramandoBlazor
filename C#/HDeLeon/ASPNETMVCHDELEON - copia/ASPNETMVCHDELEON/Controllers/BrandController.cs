using ASPNETMVCHDELEON.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNETMVCHDELEON.Controllers
{
    public class BrandController : Controller
    {
        private readonly BeerYbrandContext _context;
        
        public BrandController(BeerYbrandContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {
            return View(await _context.Brands.ToListAsync());
        }
    }
}
