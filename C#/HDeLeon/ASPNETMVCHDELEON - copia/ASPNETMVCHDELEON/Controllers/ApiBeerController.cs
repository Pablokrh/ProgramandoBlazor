using ASPNETMVCHDELEON.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNETMVCHDELEON.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBeerController : ControllerBase
    {
        private readonly BeerYbrandContext _context;
        public ApiBeerController(BeerYbrandContext context)
        {
            _context = context;
        }
        public async Task<List<ObjPrint>> GetCerveza()
        {          
            List<ObjPrint> imprimibles=new List<ObjPrint>();
            
            foreach (var item in _context.Cervezas)
            {                
                imprimibles.Add(new ObjPrint(item.Name,item.Brand.Name,item.CervezaId));
            }
           
            return  imprimibles.ToList();
        }
    }


    public class ObjPrint
    {
        public ObjPrint(string name, string marca, int id) 
        { 
            Name = name;
            Marca = marca;
            ID= id;
        
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public string Marca { get; set; }
    }
}
