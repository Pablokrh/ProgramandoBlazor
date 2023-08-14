using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDeDatos;


namespace CapaNegocio
{
    public class CN_Productos
    {     
        private CD_Productos objetoCD = new CD_Productos();

        public DataTable MostrarProducto()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }   

        public void Insertar(string nombre, string desc, string marca, string precio, string stock)
        {
            objetoCD.Insertar(nombre, desc, marca, double.Parse(precio), int.Parse(stock));   
        }

        public void Editar(string nombre, string descripcion, string marca, string precio, string stock, string id)
        {
            objetoCD.Editar(nombre, descripcion, marca,double.Parse(precio), int.Parse(stock), int.Parse(id));
            
        }

        public void Eliminar (string id)
        {
            objetoCD.Eliminar(int.Parse(id));
        }

    }
}
