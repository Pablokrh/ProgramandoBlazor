using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Task4
{
    class Program
    {
        private static int acumulador = 0;



        static void Main(string[] args)
        {
            /* for (int i = 0; i < 100; i++)
             {
                 RealizarTareas(i);

                 Console.WriteLine($"Acumulador vale {acumulador}. Tarea realizada por el hilo {Thread.CurrentThread.ManagedThreadId}");
             }
            */

            Parallel.For(0, 100, RealizarTareas);
            //esto permite no utilizar varios task y sus run.

            Console.ReadKey();
        }

        static void RealizarTareas(int i)
        {
            Console.WriteLine($"Acumulador vale {acumulador}. Tarea realizada por el hilo {Thread.CurrentThread.ManagedThreadId}");

            if (acumulador % 2 == 0)
            {
                acumulador += i;
                Thread.Sleep(300);
            }
            else
            {
                acumulador -= i;
                Thread.Sleep(100);
            }


        }
    }
}
