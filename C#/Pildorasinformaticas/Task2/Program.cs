using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = Task.Run(() => EjecutarTarea());
            Task task2 = task.ContinueWith(EjecutarOtraTarea);
            Console.ReadKey();
        }

        static void EjecutarTarea()
        {
            for (int i = 0; i < 10; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(500);
                Console.WriteLine("Esta vuelta de bucle corresponde al thread:" + miThread);
            }
        }
        static void EjecutarOtraTarea(Task obj)
        {
            for (int i = 0; i < 10; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(500);
                Console.WriteLine("Esto es otra tarea y esta vuelta de bucle corresponde al thread:" + miThread);
            }
        }

    }
}
