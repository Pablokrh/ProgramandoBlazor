using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class EmpleadoResponse
    {
        public EmpleadoResponse(Empleado empleado = null)
        {
            this.empleado = empleado;                  
            listEmpleado = new List<Empleado>();
        }

        public Empleado empleado { get;  }
        public List <Empleado> listEmpleado { get; set; }
        public Exception error { get; set; }
        public bool dniValido { get; set; }

    }
}
