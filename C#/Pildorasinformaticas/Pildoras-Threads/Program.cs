using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Pildoras_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(MetodoSaludo);
            t.Start();
            t.Join();
            Console.WriteLine("Hola bacterias desde thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Hola bacterias desde thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Hola bacterias desde thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Hola bacterias desde thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Hola bacterias desde thread 1");
            Thread.Sleep(500);
            Console.ReadKey();
        }
        static void MetodoSaludo()
        {
            Thread.Sleep(150);
            Console.WriteLine("Hola bacterias desde thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hola bacterias desde thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hola bacterias desde thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hola bacterias desde thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hola bacterias desde thread 2");
            Thread.Sleep(500);

        }
    }
}
