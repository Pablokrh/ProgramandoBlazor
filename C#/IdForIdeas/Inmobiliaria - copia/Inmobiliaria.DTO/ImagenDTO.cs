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

		public bool? EsPrincipal { get; set; }

		public virtual InmuebleDTO? IdInmuebleNavigation { get; set; }
	}
}
