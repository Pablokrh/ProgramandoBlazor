using System.ComponentModel.DataAnnotations;

namespace Web_DesesperanzaAPI.Models
{
    public class UserLogins
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
