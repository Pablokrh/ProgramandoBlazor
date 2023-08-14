using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema9
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.Nombre = "Pablo";
            cliente1.Edad = 35;
            cliente1.Telefono = "541159123081";
            cliente1.Credito = 50000;

            Console.WriteLine("Datos de cliente:");
            Console.WriteLine("Nombre de cliente: "+cliente1.Nombre + ". Edad: "+ cliente1.Edad +
               " N° de teléfono:"+ cliente1.Telefono+ ". Cuenta con un crédito de: Ars "+cliente1.Credito );

            Trabajador trabajador1 = new Trabajador();
            trabajador1.Nombre = "Pol";
            trabajador1.Edad = 18;
            trabajador1.Telefono = "46595180";
            trabajador1.Salario = 20000;

            Console.WriteLine();
            Console.WriteLine("Datos de trabajador:");
            Console.WriteLine("Nombre de trabajador: " + trabajador1.Nombre + ". Edad: " + trabajador1.Edad +
               " N° de teléfono:" + trabajador1.Telefono + ". Cuenta con un salario de: Ars " + trabajador1.Salario);
            Console.ReadKey();
        }
    }

    class Persona
    {
       protected int edad;
       protected string nombre;
       protected string telefono;

        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }

    class Cliente: Persona
    {
        private double credito;

        public double Credito { get => credito; set => credito = value; }
    }

    class Trabajador: Persona
    {
        private double salario;

        public double Salario { get => salario; set => salario = value; }
    }

}
