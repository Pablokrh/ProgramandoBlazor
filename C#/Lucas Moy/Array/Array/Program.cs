using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int[,] barcohundido = new int[2, 3];
            barcohundido[0, 0] = 36;
            barcohundido[0, 1] = 36;
            barcohundido[0, 2] = 36;
            barcohundido[1, 0] = 36;
            barcohundido[1, 1] = 36;
            barcohundido[1, 2] = 12;

           System.Console.WriteLine(barcohundido[1, 2]); //Eso imprime el array en esa posición (usando esos 2 índices)
            Console.ReadKey();





        }
    }
}
/*int[] numeros = new int[5]; //5 son los elementos, llegará hasta el índice 4.
            numeros[0] = 1;
            numeros[1] = 12;
            numeros[2] = 4;
            numeros[3] = 6;
            numeros[4] = 7;

            int suma = numeros[0] + numeros[3] + numeros[4];
            Console.WriteLine("La suma de estos números enteros es de "+ suma);

int[] numeros = { 2, 6, 12, 45, 66 }; //Es otra forma de dar valores al array, de inicializarlo.

Array recorrido con un for:
            int[] numeros = { 2, 6, 12, 45, 66 }; //Es otra forma de dar valores al array, de inicializarlo.
                
            for (int i = 0; i < numeros.Length; i++) //En el for el .length se hace sobre el array no sobre el contador
            {
                Console.WriteLine("El elemento " + (i+1) + " Es igual a " + numeros[i]);
            }

  Así se pasan los valores de un array a otro.
int[] numeros = { 2, 6, 12, 45, 66 }; //Es otra forma de dar valores al array, de inicializarlo.
            int[] numerosgrande = new int[10];

            for (int i = 0; i < numeros.Length; i++) //En el for el .length se hace sobre el array no sobre el contador
            {
                numerosgrande[i] = numeros[i];
            }
            //La gran limitación del array es que si lo inicializas con 6 elementos, después no podes agregar un séptimo.
            // Se podría crear un array mas grande y pasarle los valores que se pusieron en el array mas pequeño.
            //se le pasa el mismo for cambiando el .length
            for (int i = 0; i < numerosgrande.Length; i++)
            {
                Console.WriteLine("El elemento " + (i + 1) + " Es igual a " + numerosgrande[i]);
            } 
           
            Console.ReadKey();


static void Main(string[] args)
        {
            int[] numeros = { 2, 6, 12, 45, 66 }; //Es otra forma de dar valores al array, de inicializarlo.
            int[] numerosgrande = new int[10]; //este array es mas grande que el primero y se le van a pasar sus valores. 

            for (int i = 0; i < numeros.Length; i++) //En el for el .length se hace sobre el array no sobre el contador
            {
                numerosgrande[i] = numeros[i];
            }
            //La gran limitación del array es que si lo inicializas con 6 elementos, después no podes agregar un séptimo.
            // Se podría crear un array mas grande y pasarle los valores que se pusieron en el array mas pequeño.
            //se le pasa el mismo for cambiando el .length
            for (int i = 0; i < numerosgrande.Length; i++)
            {
                Console.WriteLine("El elemento " + (i + 1) + " Es igual a " + numerosgrande[i]);
            } 
           
            Console.ReadKey();

*/