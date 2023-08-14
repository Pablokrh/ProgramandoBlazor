using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pildoras_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] valoresNumericos = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Números impares:");
            foreach (var item in valoresNumericos)
            {
                if (item % 2 != 0) Console.Write(item+" / ");

            }

            Console.WriteLine();
            Console.WriteLine();
            /*
            Console.WriteLine("Números pares:");

            List<int> numerosPares = new List<int>();
            for (int i = 0; i < valoresNumericos.Length; i++)
            {
                if (valoresNumericos[i] % 2 == 0) numerosPares.Add(valoresNumericos[i]);
            }
            */

            Console.WriteLine("Números pares:");
            IEnumerable<int> numerosPares = from numero in valoresNumericos where numero % 2 == 0 select numero;

            foreach (var item in numerosPares)
            {
                Console.Write(item + " - ");
            }

            Console.ReadKey();
        }

    }
}
