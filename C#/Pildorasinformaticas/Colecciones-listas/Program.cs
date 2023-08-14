using System;
using System.Collections.Generic;

namespace Colecciones_listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>(); //Así se declara una colección de tipo lista
            numeros.Add(5); //Agregar elementos
            numeros.Add(7);

            /*for (int i = 0; i < 3; i++) //Así se recorre una lista
            {
                Console.writeline (numeros[i]);
            }*/
            //Hasta acá todo lo comparte con un array.
            //Acá le sumo a la lista, los valores de un array.
            int[] listanumeros = new int[] { 3, 6, 8, 10, 50 };
            for (int i = 0; i < 5; i++)
            {
                numeros.Add(listanumeros[i]);
            }

            for (int i = 0; i < 7; i++) //Así se recorre una lista
            {
                Console.WriteLine (numeros[i]);
            }
        } 
    }
}
