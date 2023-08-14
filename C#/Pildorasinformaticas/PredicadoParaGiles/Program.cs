using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicadoParaGiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> todosNumeros = new List<int>(); 
            todosNumeros.AddRange(new int[] { 1, 5, 142, 53, 22, 95, 12 });

            Predicate<int> PabloPredica = new Predicate<int>(DevuelveMayores);
            List<int> mayores = todosNumeros.FindAll(PabloPredica);
            foreach (var item in mayores)
            {
                Console.Write(item+ " - ");
            }
            Console.ReadKey();
        }


        static bool DevuelveMayores(int num)
        {
            if (num > 20) return true;
            else return false;

        }

    }
}
