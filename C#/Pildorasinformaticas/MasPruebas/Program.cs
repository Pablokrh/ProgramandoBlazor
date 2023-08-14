using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasPruebas
{
    class Program
    {
        delegate string MeCuelgoDeOtraFuncion(string dia, string mes, int año);

        static void Main(string[] args)
        {
            //Delegado
            MeCuelgoDeOtraFuncion colgateDeEsta = new MeCuelgoDeOtraFuncion(GeneraFecha);
            string texto = colgateDeEsta("Nueve", "Enero", 1988);
            Console.WriteLine(texto);

            //Predicado
            string [] palabrasDeTexto= texto.Split();
            int contador = 1;
            foreach (var item in palabrasDeTexto)
            {
                Console.Write("Palabra N°"+ contador + "= "+item);
                Console.WriteLine();
                contador++;
            }

           Predicate<string> Predicado = new Predicate<string>(contieneXPalabra);
           List <string> palabrasList= palabrasDeTexto.ToList();

           Console.Clear();
           List<string> listFinal= palabrasList.FindAll(Predicado);
           foreach (var item in listFinal)
           {
                Console.WriteLine(item);
           }

           //Lambdas

            int num1 = 5;
            int num2 = 12;
            int num3 = 91;

            Func<int, int, int, int > teSumo= (a, b, c) => a + b + c;
            Console.WriteLine(teSumo(num1, num2, num3));
            Console.WriteLine("--------------------------------------\n");

            Predicate<int> esMayor = (a) => a > 15;
            Console.WriteLine(esMayor(num2));
            Console.WriteLine(esMayor(num3));

            Console.WriteLine("--------------------------------------\n");

            Action<int, int> soyAccion = (a, b) => Console.WriteLine((a+b)*b);
            soyAccion(num1, num2);

            Console.ReadKey();
        }





        //Delegado
        static string GeneraFecha( string dia, string mes, int año)
        {
            return $"El día es {dia}, del mes de {mes}, del año {año}";
        }


        //Predicado (O delegado predicado)

        static bool contieneXPalabra(string cadena)
        {
            // if (cadena == "Enero"|| cadena == "Enero,"|| cadena == "Enero.") return true;
            if (cadena.Contains("de")|| cadena.Contains("De")) return true;
            else return false;
        }
    }
}
