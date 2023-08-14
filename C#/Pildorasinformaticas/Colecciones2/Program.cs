using System;
using System.Collections.Generic;
namespace Colecciones2
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> edades = new Dictionary<string, int>();
            //rellenación de 2 formas
            edades.Add("Pepe", 42);
            edades.Add("Laucha", 35);
            edades.Add("Maxi", 45);
            edades["María"] = 25;
            edades["Antonio"] = 29;

            //recorrición de 2 formas diferentes e igual resultado
            foreach(KeyValuePair<string,int> persona in edades)
            {
                Console.WriteLine("Nombre: "+ persona.Key+ " .Edad: "+ persona.Value);
            }

            foreach (KeyValuePair<string, int> persona in edades)
            {
                Console.WriteLine("Nombre: {0} Edad {1}", persona.Key, persona.Value);
            }

        }
    }
}
