using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaStrings l = new ListaStrings();
            Console.WriteLine("¿Cuántas líneas desea agregar?");
            int lineas = int.Parse(Console.ReadLine());

            for (int i = 0; i < lineas; i++)
            {
                Console.WriteLine("Escriba a continuación la línea que desea agregar:");
                string sumable = Console.ReadLine();
                l.CargarStrings(sumable);
            }

            Console.WriteLine("¿Desea leer los strings que Ud redactó? (si - no)");
            string respuesta = Console.ReadLine();

            if (respuesta == "si") l.LeeLista();
            else { }
            Console.ReadKey();
        }
    }




    class ListaStrings
    {
        private List<string> listado = new List<string>();

        
        public void CargarStrings(string sumable)
        {
           listado.Add(sumable);
        }

        public void LeeLista()
        {
            foreach (var item in listado)
            {
                Console.WriteLine(item);
            }

        }





    }

}
