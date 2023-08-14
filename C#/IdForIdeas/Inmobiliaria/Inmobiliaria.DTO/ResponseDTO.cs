using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.DTO
{
    public class ResponseDTO<K>
    {
        public K? Resultado { get; set; }

        public bool? EsCorrecto { get; set; }

        public string? Mensaje { get; set; }
    }
}
