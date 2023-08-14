using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese a continuación el valor del producto: ");
            int productoSinIva = int.Parse(Console.ReadLine());
            Console.ReadKey();

            double iva = productoSinIva * 0.21;
            double productoMasIva = productoSinIva + iva;

            Console.WriteLine();
            Console.WriteLine("El valor del produto con el IVA incluido es de: $"+ productoMasIva);
            Console.WriteLine("El IVA del mismo es de: $"+ iva);
            Console.ReadKey();



        }
    }
}
