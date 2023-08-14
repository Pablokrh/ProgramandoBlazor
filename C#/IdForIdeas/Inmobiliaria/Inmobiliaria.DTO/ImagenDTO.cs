using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.DTO
{
	public class ImagenDTO
	{
		public int IdImagen { get; set; }

		public int? IdInmueble { get; set; }

        public string? ImagenData { get; set; }

        public bool? EsImagenPrincipal { get; set; }

    }
}
