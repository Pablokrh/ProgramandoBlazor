using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMasterApp.Shared
{
    public class DetalleVentaDTO
    {
        public int? Cantidad { get; set; }

        public decimal? SubTotal { get; set; }

        public virtual ProductoDTO? Producto { get; set; }


    }
}
