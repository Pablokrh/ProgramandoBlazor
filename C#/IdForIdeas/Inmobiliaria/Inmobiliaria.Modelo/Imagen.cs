using System;
using System.Collections.Generic;

namespace Inmobiliaria.Modelo;

public partial class Imagen
{   
    public int IdImagen { get; set; }

    public int? IdInmueble { get; set; }

    public string? ImagenData { get; set; }

    public bool? EsImagenPrincipal { get; set; }


}
