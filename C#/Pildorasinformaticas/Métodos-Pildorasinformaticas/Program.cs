using System;

namespace Métodos_Pildorasinformaticas
{
    class Program
    {
        static void Main(string[] args)
        {
             primerMetodo();
            segundoMetodo();
        }
       static void primerMetodo()
        {
            Console.WriteLine(num1);
             //su ámbito (o alcance o visibilidad) es local

        }

        static int num1 = 5;
        static  void segundoMetodo()
        {
            Console.WriteLine(num1);

        }

    }
}
