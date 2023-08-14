using System;

namespace Herencia_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            avion LAPA = new avion();
            coche Twingo = new coche();
            avion Jumbo = new avion();

            LAPA.conducir();
            Twingo.conducir();
        }

        public class vehiculo
        {
            public vehiculo()
            {
               
            }

            public void arrancarMotor ()
            {
                Console.WriteLine("El motor ha arrancado");
            }
            public void pararMotor()
            {
                Console.WriteLine("El motor se ha detenido");
            }
            public virtual void conducir()
            {
                Console.WriteLine("Se está conduciendo el vehículo");
            }

        }

        public class avion:vehiculo
        {
            public avion()
            {
                
            }
            public override void  conducir()
            {
                Console.WriteLine("Se está conduciendo el avión");

            }

        }
        public class coche:vehiculo
        {
            public coche()
            {

                
            }

            public override void conducir()
            {
                Console.WriteLine("Se está conduciendo el coche");

            }
        }

    }
}
