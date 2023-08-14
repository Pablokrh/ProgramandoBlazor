using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciostema3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche miCoche = new Coche();
            miCoche.AgregaPuertas(1);
            Console.WriteLine(miCoche.numeroPuertas);
            Console.ReadKey();
        }

    }

    public class Coche
    {
        public int numeroPuertas=3;

        public void AgregaPuertas (int valor)
        {
            numeroPuertas = numeroPuertas + valor;

        }
    }

}
