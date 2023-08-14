using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace C_Sharp_Y_JavasCript_Main
{
    class Program
    {
        static void Main(string[] args)
        {
            BBDD.Conexion conexion = new BBDD.Conexion();
            
            conexion.InsertarUsuario(8, "Lautaro", "Martneis", 29);

            Console.WriteLine(conexion.PrinteaTabla());
            Console.WriteLine("-----------------------------\n");
            conexion.EliminaUsuario(3);
            Console.WriteLine(conexion.PrinteaTabla());





            C_Sharp_Y_JavaScript.JavaScripty javaScripty = new C_Sharp_Y_JavaScript.JavaScripty();
            javaScripty.Locurotas();
            Console.ReadKey();



        }
    }
}
