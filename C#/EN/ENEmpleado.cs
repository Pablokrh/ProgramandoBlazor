using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EN
{
   public class ENEmpleado
    {
        private int empleadoId;
        private String empleadoNombre;
        private String empleadoApellido;
        private String empleadoIdentificacion;
        private String empleadoUsuario;
        private String empleadoClave;
        private String empleadoRol;

        public int EmpleadoId { get => EmpleadoId; set => EmpleadoId = value; }
        public String EmpleadoNombre { get => empleadoNombre; set => empleadoNombre = value; }
        public String EmpleadoApellido { get => empleadoApellido; set => empleadoApellido = value; }
        public String EmpleadoIdentificacion { get => empleadoIdentificacion; set => empleadoIdentificacion = value; }
        public String EmpleadoUsuario { get => empleadoUsuario; set => empleadoUsuario = value; }
        public String EmpleadoClave { get => empleadoClave; set => empleadoClave = value; }
        public String EmpleadoRol { get => empleadoRol; set => empleadoRol = value; }
    }
}
