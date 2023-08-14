using System;
using System.Collections.Generic;

namespace Inmobiliaria.Modelo;

public partial class Inmueble
{
    public int IdInmueble { get; set; }

    public string? Titulo { get; set; }

    public string? TipoInmueble { get; set; }

    public string? Detalles { get; set; }

    public string? Pais { get; set; }

    public string? Ciudad { get; set; }

    public int? Ambientes { get; set; }

    public int? Metros { get; set; }

    public int? Antigüedad { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Expensas { get; set; }

    public string? PublicadoPara { get; set; }

    public string? Estado { get; set; }

    public bool? Destacado { get; set; }

    public DateTime? FechaCreacion { get; set; }

	public virtual ICollection<Imagen> ListaImagenes { get; set; } = new List<Imagen>();
}
