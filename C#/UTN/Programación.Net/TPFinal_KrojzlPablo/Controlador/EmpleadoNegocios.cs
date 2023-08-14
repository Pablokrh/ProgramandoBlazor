using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using Entidades;

namespace ControladorTablas
{
    public class NegociosEmpleados
    {
        ModeloTablas modelo = new ModeloTablas();

        public EmpleadoResponse RecuperaFila(int auxId)
        {
            return modelo.RecuperaFila(auxId);
        }

        public EmpleadoResponse AgregarALista()
        {
            return modelo.AgregarALista();
        }
        
        public EmpleadoResponse AgregarEmpleado(string nombreCompleto, string dni, int edad, bool casado, decimal salario)
        {
           return modelo.AgregarEmpleado(nombreCompleto, dni, edad, casado, salario);
        }


        public EmpleadoResponse EliminarEmpleado (int auxId)
        {
            return modelo.EliminarEmpleado(auxId);
        }

       public EmpleadoResponse ModificarEmpleado(string nombreCompleto, string dni, int edad, bool casado, decimal salario, int id)
        {
            return modelo.ModificarEmpleado(nombreCompleto, dni, edad, casado, salario, id);

        }

        public EmpleadoResponse FiltrarPorNombre(string buscaPorNombre)
        {
           return modelo.FiltrarPorNombre(buscaPorNombre);
        }

        public EmpleadoResponse DNIExistente(string dni)
        {
            return modelo.DNIExistente(dni);
        }
    }
}
