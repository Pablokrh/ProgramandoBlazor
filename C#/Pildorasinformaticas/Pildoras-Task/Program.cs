using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Pildoras_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(EjecutarTarea);
            task.Start();

            Task task2 = Task.Run(() => EjecutarTarea());

            Console.ReadKey();

        }

        static void EjecutarTarea()
        {
            for (int i = 0; i < 100; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);
                Console.WriteLine("Esta vuelta de bucle corresponde al thread:"+ miThread);
            }
        }

    }
}
