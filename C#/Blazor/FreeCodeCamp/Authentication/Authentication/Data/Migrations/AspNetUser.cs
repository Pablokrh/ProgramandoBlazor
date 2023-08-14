using Microsoft.AspNetCore.Identity;

namespace Authentication.Data.Migrations
{
    public class AspNetUser : IdentityUser
    {
        public string School { get; set; }
    }
}
