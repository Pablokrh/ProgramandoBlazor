using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 15;
            int num3 = 30;

            SumaNumeros(num1, num2, num3);
            Console.ReadKey();
        }

        public static void SumaNumeros(int num1, int num2, int num3)
        {
            int resultado = num1 + num2 + num3;
            Console.WriteLine(resultado);
        }
    }




}
