using System;
using System.Collections.Generic;

namespace PizzeriaDonRemolo.Model;

public partial class Venta
{
    public int IdVenta { get; set; }

    public string? NombreUsuario { get; set; }

    public string? Direccion { get; set; }

    public string? FormaPago { get; set; }

    public decimal? Total { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();
}
