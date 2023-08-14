using Microsoft.EntityFrameworkCore;

namespace Web_Api_Gavilanch
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) { }

    }
}
