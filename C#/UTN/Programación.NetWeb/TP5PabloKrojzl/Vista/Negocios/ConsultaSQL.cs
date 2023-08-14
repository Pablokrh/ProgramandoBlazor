using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    
    public class ConsultaSQL
    {
        Datos.SQL sql = new Datos.SQL();

        public void InsertarUsuario(int id, string nombre, string apellido, int edad)
        {
            sql.InsertarUsuario(id, nombre, apellido, edad);
        }

       public void EliminarUsuarios()
       {
            sql.EliminarUsuarios();
       }

        public DataTable ConsultaRegistros()
        {
           return sql.ConsultaRegistros();
        }




    }
}
