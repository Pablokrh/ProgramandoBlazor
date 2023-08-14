using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPets.Model
{
    public class PetModel
    {

        //Fields -- Campos
        private int id;
        private string name;
        private string type;
        private string colour;

        //Properties - Validations

        [DisplayName("Pet Id")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DisplayName("Pet Name")]
        [Required(ErrorMessage="Pet Name is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Pet Name must have between 3 & 50 characters")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DisplayName("Pet Type")]
        [Required(ErrorMessage = "Pet Type is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet Type must have between 3 & 50 characters")]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        [DisplayName("Pet Colour")]
        [Required(ErrorMessage = "Pet Colour is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet Colour must have between 3 & 50 characters")]
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
    }
}
