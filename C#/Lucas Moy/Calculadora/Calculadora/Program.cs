using System;

namespace Calculadora
{


    class Program
    {
  

        static void Main(string[] args)
        {
            double Num1 = 0;
            double Num2 = 0;
            double Resultado = 0;
      
            Console.WriteLine("Escriba el primer número");
            Num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Escriba el segundo número");
            Num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escriba la operación a realizar");
            Console.WriteLine("Elija entre multiplicar, dividir, sumar y restar:");
            string operacion = (Console.ReadLine());

          
            switch (operacion)

             { 
                case "multiplicar":
                    Resultado = Num1 * Num2;
                    Console.WriteLine("El resultado de la multiplicación es: " + Resultado);
                    break;

               case "dividir" :
                    Resultado = Num1 / Num2;
                    Console.WriteLine("El resultado de la división es: " + Resultado);
                    break;

                case "sumar":
                    Resultado = Num1 + Num2;
                    Console.WriteLine("El resultado de la suma es: " + Resultado);
                    break;

                case "restar":
                    Resultado = Num1 - Num2;
                    Console.WriteLine("El resultado de la resta es: " + Resultado);
                    break;
            }
                      Console.ReadKey();

        }

        
    }
}
