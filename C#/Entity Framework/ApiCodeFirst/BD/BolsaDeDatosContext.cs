using Microsoft.EntityFrameworkCore;

namespace BD
{
    public class BolsaDeDatosContext:DbContext
    {

        public BolsaDeDatosContext(DbContextOptions<BolsaDeDatosContext> options) : base(options) { } 
    
        public DbSet<Brand>Brands { get; set; }

        public DbSet<Cerveza> Cervezas { get; set;}

       /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().ToTable("Cerveza");
        }
       */
    }



}