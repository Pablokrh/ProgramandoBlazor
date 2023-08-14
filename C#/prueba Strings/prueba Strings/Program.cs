using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese texto");


            string cadena = Console.ReadLine();
            int contador = 0;
            bool esnumero;


            for (int i = 0; i < cadena.Length; i++)
            {
                if(esnumero = char.IsDigit(cadena[i]))
                {
                    Console.Write(cadena[i] + " ");
                    contador++;
                }
            }
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("Total de números en la cadena de carácteres: "+contador);

            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();

            bool avanzar = false;

           
                Console.Clear();
                Console.WriteLine("Ingrese ahora solamente números");
                Console.WriteLine("Presione X para salir");

                string cadenaNumerica = Console.ReadLine();

                try
                {
                    if (cadenaNumerica == "5") Environment.Exit(1);
                    int numerico = int.Parse(cadenaNumerica);
                    avanzar = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("¿¿¿Qué formato metiste, papá??? " + ex.Message);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);                    
                }
               



                Console.WriteLine("hola, estoy después del catch");

            Console.ReadKey();

           

        }
    }
}
