using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MétodoEstático
{/*Problema propuesto
Plantear una clase llamada VectorEnteros que defina tres métodos estáticos. 
    El primero retorna el mayor elemento del vector (el vector llega como parámetro), el segundo el menor elemento
    y el tercero la suma de sus componentes.*/


    class Triangulo
    {
        public int Lado1 { get; set; } = 5;
        public int Lado2 { get; set; } = 5;
        public int Lado3 { get; set; } = 5;

      

        public int RetornarPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo() { Lado1 = 10, Lado2 = 20, Lado3 = 30 };
            Console.WriteLine(triangulo1.RetornarPerimetro());
            Triangulo triangulo2 = new Triangulo() { Lado3 = 30 };
            Console.WriteLine(triangulo2.RetornarPerimetro());
            Console.ReadKey();
        }
    }

}


/* public class VectorEnteros
    {
       public int[] enteros;

        public void LlenaArray()
        {
            Console.WriteLine("¿Cuántos números desea agregar?");
            int cant = int.Parse(Console.ReadLine());
            enteros = new int[cant];
            Console.WriteLine("¡¡Lo has hecho muy bien!!"); Console.WriteLine();

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("ingrese el número n°" + (i + 1));
                enteros[i] = int.Parse(Console.ReadLine());
            }
        }
                
        public static int MayorE(int []H)
        {
            int elMayor = int.MinValue;
            for (int i = 0; i < H.Length; i++)
            {
                if (H[i] > elMayor)
                {
                   elMayor = H[i];
                }
            }
            return elMayor;
        }
        public void Impresionar(int[] d)
        {
            foreach (var item in d)
            {
                Console.Write(item + " /  ");
            }
        }
    }
       
    class Program
    {
        static void Main(string[] args)
        {
            int[] enteros;

            Console.WriteLine("¿Cuántos números desea agregar?");
            int cant = int.Parse(Console.ReadLine());
            enteros = new int[cant];
            Console.WriteLine("¡¡Lo has hecho muy bien!!"); Console.WriteLine();

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("ingrese el número n°" + (i + 1));
                enteros[i] = int.Parse(Console.ReadLine());
            }

            VectorEnteros VC = new VectorEnteros();
            VC.Impresionar(enteros);
            VectorEnteros.MayorE(enteros);
            Console.WriteLine("El mayor número es="+ VectorEnteros.MayorE(enteros));
            Console.ReadKey();
        }
    }*/