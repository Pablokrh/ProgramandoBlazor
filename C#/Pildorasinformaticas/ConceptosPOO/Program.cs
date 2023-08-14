using System;
using static System.Math;
using static System.Console;

namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args) 
        {
            // realizarTarea();

           var miVariable = new { Nombre = "Juan", Edad = 19 }; //esto es una clase anónima, no se le da nombre.

            Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad);
            //Tampoco se especifica el tipo de dato de las variables

            var miOtraVariable = new { Nombre = "Ana", Edad = 25};
            //El compilador afirma que pertenecen a la misma clase. Ya que tienen la misma estructura.

            miVariable = miOtraVariable; //Esto lo hace para demostrar que son de la misma clase.
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();

            Punto destino = new Punto(128,80);

            Punto elTercero = new Punto(23, 56);

            double distancia = origen.DistanciaHasta(destino); //el this que puse antes, dentro de distanciahasta, hace referencia a origen.
            Console.WriteLine($"La distancia entre los puntos es de {distancia}");
            //este método requiere un objeto para ser llamado, no como otros. Y otros son llamados por su clase. Esto haría referencia al static.
            Console.WriteLine($"Número de objetos creados: {Punto.retornaContador()}"); //se crearon 2 objetos, pertenecientes a la clase punto.
        }


    }
       
}
