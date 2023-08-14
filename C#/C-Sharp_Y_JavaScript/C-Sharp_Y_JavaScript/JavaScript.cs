using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Y_JavaScript
{
    public class JavaScripty
    {
        List<int> numeroles = new List<int>();

        public void Locurotas()
        {
            numeroles.Add(12);
            numeroles.Add(24);
            numeroles.Add(53);
            numeroles.Add(66);
            numeroles.Add(47);
            numeroles.Add(87);
            numeroles.Add(87);
            numeroles.Add(7);

            Console.WriteLine("\nVIRGOFORMA DE IMPRESIÓN");
            Console.WriteLine(numeroles);


            //FUNCION FLECHA, LAMBDA. QUE ADEMAS SON ANONIMAS. (IDEM JAVASCRIPT)
            Console.WriteLine("\nVIRGOFORMA DE IMPRESIÓN");

            numeroles.ForEach((valor) =>
            {
                Console.WriteLine(valor + " ");
            });

            Console.WriteLine("-----------------------------------------------------\n LISTA ORDENADA ");
            //SORT (IDEM JAVASCRIPT)

            numeroles.Sort((a, b) => b + a);

            numeroles.ForEach((valor) =>
            {
                Console.WriteLine(valor);
            });

            Console.WriteLine("-----------------------------------------------------\n LISTA ORDENADA AL REVÉS");

            numeroles.Reverse();

            numeroles.ForEach((valor) =>
            {
                Console.WriteLine(valor);
            });

            Console.WriteLine("-----------------------------------------------------\n FIND");
            //FIND (IDEM JAVASCRIPT)
            int hayNumero = numeroles.Find((valor) =>
            {
                if (valor == 0) return true;
                else return false;

            });
            Console.Write(hayNumero);
            //No es booleana, devuelve el número si es que está o un 0 si no hay.
        }
    }
}
