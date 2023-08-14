using System;
using System.Collections.Generic;

namespace Inmobiliaria.Modelo;

public partial class Imagen
{
    public int IdImagen { get; set; }

    public int? IdInmueble { get; set; }

    public bool? EsPrincipal { get; set; }

    public virtual Inmueble? IdInmuebleNavigation { get; set; }
}
