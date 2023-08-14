using System;

namespace Ciclo_examen2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Double numing = 0;
            Double promedio = 0;
            Double suma = 0;
            Double resta = 0;
            Double multiplicacion = 1;
            for (int cond = 1; cond <= 10; cond++)
            {
                Console.WriteLine("Escriba aquí un número");
                numing = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Este es el número ingresado N° " + cond);

                suma = suma + numing;
                resta = resta - numing;
                multiplicacion = multiplicacion * numing;
                Console.WriteLine(numing);
                Console.WriteLine(suma);
            }
           
            promedio = suma / 10;
            Console.WriteLine("La sumatoria de los números ingresados es de :" + suma);
            Console.WriteLine("La resta de los números ingresados es de :" + resta);
            Console.WriteLine("La mulitiplicación de los números ingresados es de :" + multiplicacion);
            Console.WriteLine("El promedio de los números ingresados es de :" + promedio);
            Console.ReadKey();
        }
    }
}
/*
Actividad No. 3: Ingresar datos e imprimir las diferentes operaciones matemáticas
Escriba un programa que permita ingresar 10 números por teclado y nos muestre posteriormente la suma, resta, multiplicación y promedio de los números ingresados.



Tenga en cuenta que el usuario escribirá los números en la consola.




Metodología
a. Implementa tu programa en un proyecto de consola llamado ciclos.cs.



b.Tu programa pedirá al usuario diez números y los almacenará en una variable llamada valor.



c.Crea una variable llamada suma, donde se almacenará la suma de los valores que ingreses.




d.Crea una variable llamada promedio, donde se almacenará el promedio de los números ingresados.



e.Utiliza un ciclo for para pedir al usuario que ingrese diez veces un valor.




f.Imprima las variables suma y promedio.*/