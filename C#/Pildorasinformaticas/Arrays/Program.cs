using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Esto se está imprimiendo desde el main");
            for (int a = 0; a < arrayElementos.Length; a++)
            {
                Console.WriteLine(arrayElementos[a]);
            }
        }

        static int[] LeerDatos ()
        {
            Console.WriteLine("¿Cuántos elementos quieres que tenga el array?");

            string respuesta = Console.ReadLine();

            int numElementos = Int32.Parse(respuesta);
             
            int[] datos = new int[numElementos];

            for (int i = 0; i < numElementos; i++)
            { Console.WriteLine($"Introduce el dato para la posición {i}"+ i);
                respuesta = Console.ReadLine();
                int datosElemento = Int32.Parse(respuesta);
                datos[i] = datosElemento;
            }
            return datos;

        }
    }
}
/*ARRAYS de OBJETOS:
   empleados[] arrayEmpleados = new empleados[2];
            empleados Ana = new empleados("Ana", 27); //esto es *
            arrayEmpleados[0] = new empleados("Sarah", 36); // esta es una alternativa
            arrayEmpleados[1] = Ana; //esta es la otra alternativa, requiere de * ya que si no, daría error

        }

        class empleados //se van a construir objetos de tipo empleados
        {
            public empleados (string nombre, int edad) //Este public es el constructor de la clase
            {
                this.nombre = nombre;
                this.edad = edad;

            }

            string nombre;
            int edad;


 * 
 * int[] edades;
edades = new int[5];
edades[0] = 14;
edades[1] = 24;
edades[2] = 55;
edades[4] = 34;

for (int i = 0; i < edades.Length; i++)
{
    Console.WriteLine(edades[i]); //en el índice 3 se verá el 0 por default.
}
*/