using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace U3ClasesyObjetos
{
    


    class Program
    {
        static void Main(string[] args)
        {
            string color;
            int año;
            int puertas;
            string modelo;

            Console.WriteLine("Bienvenidos al sistema de gestion de autos, ingresar nuevo automobil");
            Console.WriteLine("Ingrese color:");
            color = Console.ReadLine();

            Console.WriteLine("Ingrese año:");
            año = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cantidad de puertas:");
            puertas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese modelo:");
            modelo = Console.ReadLine();

            Auto miAuto = new Auto(color, año, puertas, modelo);
            Console.WriteLine("");
            Console.WriteLine("Auto creado: " + miAuto.GetModelo() + " " + miAuto.GetAño() + " " + miAuto.GetColor() + " de " + miAuto.GetPuertas() + "puertas");

            Console.Read();



        }
        
    }
}


















/*
            Auto instanciado por constructor
           Auto miAuto2 = new Auto("amarillo",2010,5,"Ka");
           miAuto2.SetColor("verde");
           */
