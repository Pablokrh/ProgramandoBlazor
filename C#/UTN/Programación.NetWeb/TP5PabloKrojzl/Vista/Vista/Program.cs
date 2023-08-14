using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN5_KrojzlPablo
{
    class Program
    {

        static void Main(string[] args)
        {
            SQL sql = new SQL();

            List<Usuario> listaUsuarios;

            SimularDatosDeTabla(sql);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
           
            Console.WriteLine(string.Format("{0,62}", "Sistema de gestión de usuarios\n"));
            string mensaje = "";
            mensaje += string.Format("{0,21}", "Id ");
            mensaje += string.Format("{0,19}", "Nombre");
            mensaje += string.Format("{0,20}", "Apellido");
            mensaje += string.Format("{0,22}", "Edad" + Environment.NewLine);

            Console.WriteLine(mensaje);

            listaUsuarios = sql.ConsultaRegistros();
                       
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                Console.Write(
                    string.Format("{0,20}",listaUsuarios[i].Id.ToString().Trim()) +
                    string.Format("{0,20}", listaUsuarios[i].Apellido.ToString().Trim()) +
                    string.Format("{0,20}", listaUsuarios[i].Nombre.ToString().Trim()) +
                    string.Format("{0,20}", listaUsuarios[i].Edad.ToString().Trim())
                    );              
                Console.WriteLine(Environment.NewLine);
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.ReadKey();
        }

        private static void SimularDatosDeTabla(SQL sql)
        {
            sql.EliminarUsuarios();

            Usuario us1 = new Usuario();
            us1.Id = 1;
            us1.Nombre = "Pablo";
            us1.Apellido = "Krojzl";
            us1.Edad = 35;

            Usuario us2 = new Usuario();

            us2.Id = 2;
            us2.Nombre = "Lautaro";
            us2.Apellido = "Acosta";
            us2.Edad = 35;

            Usuario us3 = new Usuario();

            us3.Id = 3;
            us3.Nombre = "José";
            us3.Apellido = "Sand";
            us3.Edad = 43;

            sql.InsertarUsuario(us1);
            sql.InsertarUsuario(us2);
            sql.InsertarUsuario(us3);

        }

    }
}
