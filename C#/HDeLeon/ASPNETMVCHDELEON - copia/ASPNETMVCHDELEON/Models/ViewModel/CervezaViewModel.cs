using System.ComponentModel.DataAnnotations;

namespace ASPNETMVCHDELEON.Models.ViewModel
{
    public class CervezaViewModel
    {
        [Required]
        [Display (Name="Nombre")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Marca")]
        public int BrandId { get; set; }
       
    }
}
