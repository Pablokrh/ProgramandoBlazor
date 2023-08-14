using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using Entidades;

namespace Negocios
{
    public class EmpleadoNegocios
    {
        EmpleadoDAL modelo = new EmpleadoDAL();
  
        public List <EmpleadoEntidades> AgregarALista()
        {
            return modelo.AgregarALista();
        }
        
        public List<EmpleadoEntidades> AgregarEmpleado(string nombreCompleto, string dni, int edad, bool casado, decimal salario)
        {
           return modelo.AgregarEmpleado(nombreCompleto, dni, edad, casado, salario);
        }

        public bool DNIExistente(string dni)
        {
            return modelo.DNIExistente(dni);
        }
    }
}
