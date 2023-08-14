using System;

namespace Uso_Checked
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int numero = int.MaxValue;
                int resultado = checked(numero + 20); //agregué este segundo checked. Sería redundante porque está el primero
                Console.WriteLine(resultado);

            }
            Console.ReadKey();

        }
    }
}
