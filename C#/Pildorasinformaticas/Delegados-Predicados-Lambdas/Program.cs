using System;
using System.Collections.Generic;


namespace Delegados_Predicados_Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            Personas P1 = new Personas();
            P1.Nombre = "Juan"; P1.Edad = 18;
            Personas P2 = new Personas();
            P2.Nombre = "Roberto"; P2.Edad = 38;

            ComparaPersonas comparaEdad = (per1, per2) => per1 == per2;
            Console.WriteLine(comparaEdad(P1.Edad, P2.Edad));
            Console.WriteLine("------\n");
         
        }

        public delegate bool ComparaPersonas(int num1, int num2);    
    }
     
    class Personas
    {

        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
