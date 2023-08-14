using MayoristaEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp_N_7_RuizJulianDAL;

namespace mayoristaEstrellaBussines
{
    public class EmpleadoBussines
    {
        public static List<Empleado> ListarEmpleados(string NombreApellido)
        {
            return EmpleadoDAL.ListarEmpleados(NombreApellido);
        }

        public static Empleado ABMEmpleado(Empleado Empleado)
        {
            return EmpleadoDAL.ABMEmpleado(Empleado);
        }

        public static void DeleteEmpleado(int id)
        {
            EmpleadoDAL.DeleteEmpleado(id);
        }

        public static Empleado ObtenerEmpleado(int id)
        {
            return EmpleadoDAL.ObtenerEmpleado(id);
        }
    }
}
