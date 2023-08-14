using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3KrojzlPablo
{
    class Program
    {
     

        static void Main(string[] args)
        {
            string nombre;
            int sueldo;
            int peso;
            string sexo;
            double altura;
            
            Console.WriteLine("Ingrese a continuación el nombre de la persona:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su sueldo:");
            sueldo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su sexo:");
            sexo =Console.ReadLine();

            Console.WriteLine("Ingrese su peso:");
            peso = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese altura:");
            altura = double.Parse(Console.ReadLine());

            Persona persona1 = new Persona(nombre, sueldo, peso, altura, sexo);

            Console.Clear();
            Console.WriteLine("-Nombre: " + persona1.getNombre());
            Console.WriteLine("-Email: " + persona1.getEMail());
            Console.WriteLine("-sexo: " +persona1.getSexo());
            Console.WriteLine("-sueldo: "+persona1.getSueldo()+ " ARS");
            Console.WriteLine("-peso: "+ persona1.getPeso()+ "kg(B)");
            Console.WriteLine("-altura: "+ persona1.getAltura()+ "m");
            Console.ReadLine();

        }
    }
}
