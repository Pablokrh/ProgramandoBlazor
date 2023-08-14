using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads2
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria CuentaFamilia = new CuentaBancaria(2000);

            Thread[] hilosPersonas = new Thread[15];

            for (int i=0; i<15; i++)
            {
                Thread t = new Thread(CuentaFamilia.VamosRetirarEfectivo);
                t.Name = i.ToString();
                hilosPersonas[i] = t;
            }
            for (int i = 0; i < 15; i++)
            {
                hilosPersonas[i].Start();
            }
            Console.ReadKey();
        }
    }

    class CuentaBancaria
    {
        private Object BloqueaSaldo = new Object();

        double Saldo { get; set; }
        
        public CuentaBancaria(double Saldo)
        {
            this.Saldo = Saldo;
        }

        public double RetirarEfectivo(double cantidad)
        {
            if (Saldo - cantidad < 0)
            {
                Console.WriteLine($"No dispone de tanto saldo, queda ${Saldo} en la cuenta. Hilo: {Thread.CurrentThread.Name}");
                return Saldo;
            }
            lock (BloqueaSaldo) {

                if (Saldo>=cantidad)
                {
                  Console.WriteLine("Retirado {0} y queda {1} en la cuenta. Hilo: {2}", cantidad, Saldo - cantidad, Thread.CurrentThread.Name);
                  Saldo -= cantidad;

                }
                return Saldo;
            }
        }

        public void VamosRetirarEfectivo()
        {
            Console.WriteLine("Está sacando dinero el hilo-thread n°: {0}", Thread.CurrentThread.Name);
            RetirarEfectivo(500);

        }

    }



}
