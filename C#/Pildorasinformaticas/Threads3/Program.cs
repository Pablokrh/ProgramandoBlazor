using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads3
{
    class Program 
    {
        static void Main(string[] args)
        {
            var tareaTerminada = new TaskCompletionSource<bool>();
           //Sería lo mismo que:
           // TaskCompletionSource<bool> tareaTerminada = new TaskCompletionSource<bool>();

            var hilo1 = new Thread(() =>
              {
                  //Aclara que lo de arriba es una expresión lambda
                  for (int i = 0; i < 5; i++)
                  {
                      Console.WriteLine("Hilo 1");
                      Thread.Sleep(1000);

                  }
                  tareaTerminada.TrySetResult(true);

              });

            var hilo2 = new Thread(() =>
            {
                //Aclara que lo de arriba es una expresión lambda
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 2");
                    Thread.Sleep(1000);

                }


            });
            hilo1.Start();

            var resultado = tareaTerminada.Task.Result;
            //Dime el resultado de la tarea que se llama tareaTerminada
            hilo2.Start();

        }
    }
}
