using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrudShared
{
    public  class ResponseApi<T>
    {
        public bool EsCorrecto { get; set; }

        public T? Valor { get; set; }

        public string? Mensaje { get; set; }        

    }
}
