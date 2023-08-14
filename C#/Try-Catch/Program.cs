using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    class Program
    {
        
       static void Main(string[] args)
        {
            operacion O = new operacion();
            O.Operate();
           
        }
    }


    class operacion
    {
        public string opcion = "si";
        int resultado;
        int numero1;
        int numero2;

        public void Operate()
        {
            
            do
            {
                try
                {
                    Console.WriteLine("Ingrese aquí el primer número:");
                     numero1 = int.Parse(Console.ReadLine());
                }

                catch(FormatException)
                {
                    Console.WriteLine("Ingresa un número, melonazo!!");
                }


                try
                {
                    Console.WriteLine("Ingrese aquí el número 2:");
                    numero2 = int.Parse(Console.ReadLine());
                }

                catch (FormatException)
                {
                    Console.WriteLine("Ingresa un número, melonazo!!");
                }

                Console.WriteLine("Ingrese aquí la operación:");
                string operacion = Console.ReadLine();

                if (operacion == "suma") { resultado = numero1 + numero2; }
                if (operacion == "resta") { resultado = numero1 - numero2; }
                Console.WriteLine("La operación da por resultado: " + resultado);

                Console.WriteLine("¿Desea una nueva operación? (si-no)");
                opcion = Console.ReadLine();

            } while (opcion == "si");
        }

    }

}
