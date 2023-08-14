using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TP5MVC.Models;

public partial class Usuario
{
    //[Required]
    //[Display(Name = "Id")]
    public int Id { get; set; }

    //[Required]
    //[Display(Name = "Nombre")]
    public string? Nombre { get; set; }

   // [Required]
   // [Display(Name = "Apellido")]
    public string? Apellido { get; set; }

    //[Required]
  //  [Display(Name = "Edad")]
    public int? Edad { get; set; }
}
