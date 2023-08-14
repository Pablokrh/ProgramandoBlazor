using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaDonRemolo.DTO
{
    public class VentaDTO
    {
        public int IdVenta { get; set; }

        public string? NombreUsuario { get; set; }

        public string? Direccion { get; set; }

        public string? FormaPago { get; set; }

        public decimal? Total { get; set; }

        public virtual ICollection<DetalleVentaDTO> DetalleVenta { get; set; } = new List<DetalleVentaDTO>();

    }
}
