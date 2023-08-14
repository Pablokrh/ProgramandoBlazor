using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEncuentraPrimos
{
    class Program
    {
        //Predicate <bool> DelegadoPablo(int cantidad);

        static void Main(string[] args)
        {
            List<int> TodosLosNumeros = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                TodosLosNumeros.Add(i);
            }
           

            Numerica n = new Numerica();
            

           Predicate <int> PredicadoPablo = new Predicate<int>(n.EncuentraPrimos);
            List<int> numerosPrimos = TodosLosNumeros.FindAll(PredicadoPablo);

            foreach (var item in numerosPrimos)
            {
                Console.Write(item+ " - ");
            }
            Console.ReadKey();
           

        }




    }

   
    public class Numerica
    {
        public  bool EncuentraPrimos(cantidad)
        {
            bool esPrimo = false;
            for (int i = 1; i < cantidad; i++)
            {
                esPrimo = false;
                for (int j = 1; j < cantidad; j++)
                {
                    if (j != 1 && i!= j && i>=j)
                    {
                        if (i % j == 0)
                        {
                            esPrimo= true;
                        }
                    }
                }


            }
            return esPrimo;
        }

    }

}
