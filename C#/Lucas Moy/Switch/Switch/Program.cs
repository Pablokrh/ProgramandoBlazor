using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor = 0;
            switch (valor)
            {
                case 1: //ahí adentro van las instrucciones. Luego la palabra break.
                    Console.WriteLine("Entro al caso 1");

                    break;

                case 2:
                    Console.WriteLine("Entro al caso 2");

                    break;

                case 3:
                    Console.WriteLine("Entro al caso 3");

                    break;

                default:
                    Console.WriteLine("Entro al caso Default");
                    break;
                        }
            Console.ReadKey();



        }
    }
}
