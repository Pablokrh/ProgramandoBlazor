using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {          
        static void Main(string[] args)
        {
            float valorConIva;
            Console.WriteLine("Ingrese a continuación el valor del producto: ");
            int valorSinIva = int.Parse(Console.ReadLine());
            valorConIva= CalcularIVa(valorSinIva);
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("El valor de dicho producto, IVA incluido, es: $"+valorConIva);
            Console.ReadKey();            
        }

        static float CalcularIVa(int valorSinIva)
        {
            return valorSinIva * 121 / 100;
        }
    }
}
