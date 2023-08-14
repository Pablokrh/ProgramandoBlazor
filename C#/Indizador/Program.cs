using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indizador
{
    class Cliente
    {
        private string nombre;
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        private int dinero;
        public int Dinero
        {
            set
            {
                dinero = value;
            }
            get
            {
                return dinero;
            }
        }
        public Cliente(string nom, int din)
        {
            Nombre = nom;
            Dinero = din;
        }
    }

    class Banco
    {
        private Cliente[] clientes;
        public Banco()
        {
            clientes = new Cliente[3];
        }

        public Cliente this[int indice]
        {
            set
            {
                clientes[indice] = value;
            }
            get
            {
                return clientes[indice];
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Banco banco1 = new Banco();
            Cliente cli1 = new Cliente("juan", 1000);
            Cliente cli2 = new Cliente("ana", 2000);
            Cliente cli3 = new Cliente("luis", 1500);
            banco1[0] = cli1;
            banco1[1] = cli2;
            banco1[2] = cli3;
            Console.WriteLine("Datos de los clientes.");
            Console.WriteLine(banco1[0].Nombre);
            Console.WriteLine(banco1[0].Dinero);
            Console.WriteLine();
            Console.WriteLine(banco1[1].Nombre);
            Console.WriteLine(banco1[1].Dinero);
            Console.WriteLine();
            Console.WriteLine(banco1[2].Nombre);
            Console.WriteLine(banco1[2].Dinero);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
