using ASPNETMVCHDELEON.Models;
using ASPNETMVCHDELEON.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace ASPNETMVCHDELEON.Service
{
    public class CervezaService
    {
        private readonly BeerYbrandContext _context;

        public CervezaService(BeerYbrandContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Cerveza>> Index()
        {
            var beers = _context.Cervezas.Include(b => b.Brand);
            return await beers.ToListAsync();
        }


        
        public IEnumerable<Brand> Create()
        {
            var brands = _context.Brands;           
            return brands;
        }

        

        public async Task<CervezaViewModel> Create(CervezaViewModel model)
        {            
                var beer = new Cerveza()
                {
                    Name = model.Name,
                    BrandId = model.BrandId,
                };
                _context.Cervezas.Add(beer);              
                await _context.SaveChangesAsync();

            return model;
        }

        /*
        public async IEnumerable<string> ShowBrands()
        {
            new SelectList(_context.Brands, "BrandId", "Name", model.BrandId)
        }
        */


    }
}
