using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Pruebas_QueueyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos días desea que pasen?");
            int msj = int.Parse(Console.ReadLine());


            Listas l = new Listas();
            l.ArmoStack();
            l.PrinteoStack();
            Console.WriteLine("--------------------------\n");
            l.PasanXDias(msj);
            l.PrinteoStack();


            Console.ReadKey();
        }
    }

    class Listas
    {
        Queue<string> dias = new Queue<string>();

        public void ArmoStack()
        {
            dias.Enqueue("Lunes");
            dias.Enqueue("Martes");
            dias.Enqueue("Miércoles");
            dias.Enqueue("Jueves");
            dias.Enqueue("Viernes");
            dias.Enqueue("Sábado");
            dias.Enqueue("Domingo");
        }

        public void PrinteoStack()
        {
            foreach (var item in dias)
            {
                Console.WriteLine(item);
            }
        }

        public void PasaUnDía()
        {
            string aux= dias.Dequeue();
            dias.Enqueue(aux);
        }

        public void PasanXDias(int msj)
        {
            for (int i = 0; i < msj; i++)
            {
                string aux = dias.Dequeue();
                dias.Enqueue(aux);
            }
        }


    }

}
