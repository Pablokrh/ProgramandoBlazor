using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print del método con if:");
            MetodoConIf();
            Console.WriteLine();

            Console.WriteLine("Print del método con while:");
            MetodoConWhile();
            Console.WriteLine();

            Console.WriteLine("Print del método con do while:");
            MetodoConDoWhile();
            Console.WriteLine();

            Console.WriteLine("Print del método con for:");
            MetodoConFor();
            Console.WriteLine();

            Console.WriteLine("Print del método con switch:");
            MetodoConSwitch();

            Console.ReadKey();
        }

        public static void MetodoConIf()
        {
            int numeroIf = -12;

            if (numeroIf < 0)
            {
                Console.WriteLine("El número es negativo");
            }
            else if (numeroIf > 0)
            {
                Console.WriteLine("El número es positivo");
            }
            else
            {
                Console.WriteLine("El número es cero");
            }
        }

        public static void MetodoConWhile()
        {
            int numeroWhile = 0;
            while (numeroWhile < 3)
            {
                Console.WriteLine(numeroWhile);
                numeroWhile++;
            }
        }

        public static void MetodoConDoWhile()
        {
            int numeroDoWhile = 0;

            do
            {
                Console.WriteLine(numeroDoWhile);
                numeroDoWhile++;
            } while (numeroDoWhile < 1);
        }

        public static void MetodoConFor()
        {           
            for (int numeroFor=0; numeroFor<=3; numeroFor++)
            {
                Console.WriteLine(numeroFor);                
            }
        }

        public static void MetodoConSwitch()
        {
            string estacion = "Primavefra";

            switch (estacion)
            {
                case "Verano":
                    Console.WriteLine("La estación actual es verano");
                    break;

                case "Otoño":
                    Console.WriteLine("La estación actual es otoño");
                    break;

                case "Invierno":
                    Console.WriteLine("La estación actual es invierno");
                    break;

                case "Primavera":
                    Console.WriteLine("La estación actual es primavera");
                    break;

                default:
                    Console.WriteLine("No has seleccionado una estación válida");
                    break;
            }
        }
    } 
}
