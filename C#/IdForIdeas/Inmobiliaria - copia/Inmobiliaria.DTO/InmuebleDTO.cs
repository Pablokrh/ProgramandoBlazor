using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace Inmobiliaria.DTO;

public partial class InmuebleDTO
{
    public int IdInmueble { get; set; }

    [Required(ErrorMessage ="Ingresar el título del inmueble")]
    public string? Titulo { get; set; }

    public string? TipoInmueble { get; set; }

    public string? Detalles { get; set; }

    [Required(ErrorMessage = "Ingresar el país de locación")]

    public string? Pais { get; set; }

    public string? Ciudad { get; set; }

    public int? Ambientes { get; set; }

    public int? Metros { get; set; }

    public int? Antigüedad { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Expensas { get; set; }

    public string? PublicadoPara { get; set; }

    public string? Estado { get; set; } = "Disponible";

    public bool Destacado { get; set; } = false;

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<ImagenDTO> ListaImagenes { get; set; } = new List<ImagenDTO>();

}
