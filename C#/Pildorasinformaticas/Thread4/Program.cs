using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 500; i++)
            {
                //Thread t = new Thread(EjecutarTarea);
                // t.Start();
                ThreadPool.QueueUserWorkItem(EjecutarTarea,i);
            }
            Console.ReadKey();
        }

        static void EjecutarTarea(Object o)
        {
            int tarea = (int)o;
            Console.WriteLine($"Thread n°:{ Thread.CurrentThread.ManagedThreadId} ha comenzado la tarea n° {tarea}");
            Thread.Sleep(1000);
            Console.WriteLine($"Thread n°:{ Thread.CurrentThread.ManagedThreadId} ha terminado  la tarea n° {tarea}");

        }
    }
}
