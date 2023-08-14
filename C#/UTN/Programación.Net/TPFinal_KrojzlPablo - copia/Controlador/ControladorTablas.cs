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
    public class Class1
    {
        ModeloTablas modelo = new ModeloTablas();

        public Empleado RecuperaFila(int auxId)
        {
            return modelo.RecuperaFila(auxId);
        }

        public List <Empleado> AgregarALista()
        {
            return modelo.AgregarALista();
        }
        
        public List<Empleado> AgregarEmpleado(string nombreCompleto, string dni, int edad, bool casado, decimal salario)
        {
           return modelo.AgregarEmpleado(nombreCompleto, dni, edad, casado, salario);
        }


        public void EliminarEmpleado (int auxId)
        {
            modelo.EliminarEmpleado(auxId);
        }

       public List<Empleado> ModificarEmpleado(string nombreCompleto, string dni, int edad, bool casado, decimal salario, int id)
        {
            return modelo.ModificarEmpleado(nombreCompleto, dni, edad, casado, salario, id);

        }

        public List<Empleado> FiltrarPorNombre(string buscaPorNombre)
        {
           return modelo.FiltrarPorNombre(buscaPorNombre);
        }

        public bool DNIExistente(string dni)
        {
            return modelo.DNIExistente(dni);
        }
    }
}
