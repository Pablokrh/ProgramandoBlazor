using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int numero = 0;

            do
            {
                Console.WriteLine("Hola Mundo");
                numero++;
            } while (numero < 10);
              Console.ReadKey();                
        }
        
    }
}
/*
int numero = 0;

while (numero < 10)
{
    numero++;
    Console.WriteLine("El número es " + numero);
    Console.WriteLine("Hola Mundo");
    Console.ReadKey();
}

while (true) //Esto sería un ciclo infinito. Satura el programa. Salvo que se de la orden de cuando deja de ser true.
            {
                int numero = 0;
                numero++;
                Console.WriteLine("El número es " + numero);
                Console.ReadKey();
            }

 */