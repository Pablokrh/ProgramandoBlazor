using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task5
{
    class Program
    {
        static private int acumulador = 0;

        static void Main(string[] args)
        {
            CancellationTokenSource MiToken = new CancellationTokenSource();
            //este señala

            CancellationToken cancelaToken = MiToken.Token;
            //este cancela

            Task tarea = Task.Run(()=> RealizarTarea(cancelaToken));
            for (int i = 0; i < 100; i++)
            {
                acumulador += 4;
                Thread.Sleep(700);
                if (acumulador >= 100)
                {
                    MiToken.Cancel();
                    break;

                }
            }
            Thread.Sleep(1000);
            Console.WriteLine("Valor de acumulador:"+acumulador);

            Console.ReadKey();
        }


        static void RealizarTarea(CancellationToken tokenDeAca)
        {
            for (int i = 0; i < 100; i++)
            {
                acumulador++;
                var MiThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(700);
                Console.WriteLine("Ejecuta tarea el thread "+ MiThread);
                Console.WriteLine(acumulador);

               if (tokenDeAca.IsCancellationRequested)
               {
                    acumulador = 0;
                    //Con esa linea se dejan las cosas como estaban inicialmente
                    return;
                    //Esto hace que salga del for y vuelva.
               }
            }


        }
    }
}
