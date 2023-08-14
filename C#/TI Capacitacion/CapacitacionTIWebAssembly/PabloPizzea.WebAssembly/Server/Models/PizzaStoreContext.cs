using Microsoft.EntityFrameworkCore;
using PabloPizzea.Shared;

namespace PabloPizzea.Server.Models
{
    public class PizzaStoreContext:DbContext
    {
        public DbSet<PizzaSpecial> Specials { get; set; }

        public PizzaStoreContext(DbContextOptions options):base(options) {}


    }
}
