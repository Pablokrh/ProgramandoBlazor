using System;

namespace Array_Datos_Personas
{
    class Program
    {
        static void Main(string[] args)
        {


            /*string[] datos = new string[4];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Escriba aquí sus datos ");
                Console.WriteLine("Escriba aquí su nombre: ");
                datos[0] = Console.ReadLine();
                Console.WriteLine("Escriba aquí su apellido: ");
                datos[1] = Console.ReadLine();
                Console.WriteLine("Escriba aquí su edad: ");
                datos[2] = Console.ReadLine();
                Console.WriteLine("Escriba aquí su sexo (Masculino/femenino): ");
                datos[3] = Console.ReadLine();


            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(Usuario_A[0]);
                Console.WriteLine(datos[1]);
                Console.WriteLine(datos[2]);
                Console.WriteLine(datos[3]);
                //Esto no estaría bien, imprime 2 veces el último i ingresado


            }

            */

            string[] Usuario_A = new string[4];

            {
                Console.WriteLine("Escriba aquí sus datos ");
                Console.WriteLine("Escriba aquí su nombre: ");
                Usuario_A[0] = Console.ReadLine();
                Console.WriteLine("Escriba aquí su apellido: ");
                Usuario_A[1] = Console.ReadLine();
                Console.WriteLine("Escriba aquí su edad: ");
                Usuario_A[2] = Console.ReadLine();
                Console.WriteLine("Escriba aquí su sexo (Masculino/femenino): ");
                Usuario_A[3] = Console.ReadLine();
                Console.ReadKey();
            }
            string[] Usuario_B = new string[4];

            {
                Console.WriteLine("Escriba aquí sus datos ");
                Console.WriteLine("Escriba aquí su nombre: ");
                Usuario_B[0] = Console.ReadLine();
                Console.WriteLine("Escriba aquí su apellido: ");
                Usuario_B[1] = Console.ReadLine();
                Console.WriteLine("Escriba aquí su edad: ");
                Usuario_B[2] = Console.ReadLine();
                Console.WriteLine("Escriba aquí su sexo (Masculino/femenino): ");
                Usuario_B[3] = Console.ReadLine();
                Console.ReadKey();

                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine(Usuario_A[0]);
                    Console.WriteLine(Usuario_A[1]);
                    Console.WriteLine(Usuario_A[2]);
                    Console.WriteLine(Usuario_A[3]);
                }

                for (int i = 0; i <1; i++)
                {
                    Console.WriteLine(Usuario_B[0]);
                    Console.WriteLine(Usuario_B[1]);
                    Console.WriteLine(Usuario_B[2]);
                    Console.WriteLine(Usuario_B[3]);
                }



            }

        }
    }
}
/*
 Falta la parte de la impresión del array
 Actividad No. 4: Ingresar datos e imprimir arreglos
Escriba un programa que permita ingresar por consola los nombres, apellidos, edad y sexo de 5 personas, luego imprima los arreglos.

 

Tenga en cuenta que los arreglos se deben imprimir de manera ordenada.

 

A continuación, un ejemplo:
Nombre → José
Apellido → Martin
Edad → 18
Sexo → Masculino
--------------------------------------
Nombre → Rosaura
Apellido → Lopez
Edad → 19
Sexo → Femenino
Edutin Academy


Metodología
a. Implementa tu programa en un proyecto de consola llamado arreglos.cs.

 

b. Crea cuatro arreglos dónde se almacene: nombre, apellido, edad, sexo.

 

c. Crea los arreglos con los siguientes nombres: arreglo_n, arreglo_a, arreglo_e, arreglo_s.

 

d. Imprima los arreglos en el orden estipulado en la actividad.*/