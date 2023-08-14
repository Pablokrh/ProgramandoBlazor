using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia_Facilito
{
    public class Vehiculo
    {
        protected string ruido;
        protected Random Ale = new Random();
        protected int opcion;

        public Vehiculo( string ruido)
        {
            this.ruido = ruido;

        }

        public void ArrancarMotor()
        {
            Console.WriteLine("El motor se ha encendido, realizando el siguiente ruido: " + ruido);
        }

        public void PararMotor()
        {
            Console.WriteLine("El motor se ha detenido");

        }


        public virtual void Conducir()
        {
            Console.WriteLine("El vehiculo se está conduciendo");
        }

        
        public virtual void Aleatorio()
        {
            opcion = Ale.Next(0, 3);
            switch (opcion)
            {
                case 0:
                    Console.WriteLine("¡¡El vehículo ha sufrido un accidente!!");
                    break;

                case 1:
                    Console.WriteLine("El vehículo no tuvo inconvenientes y fue muy eficaz");
                    break;

                case 2:
                    Console.WriteLine("¡¡El vehículo resultó ser de cartulina!!");
                    break;
                default:
                    break;

            }

        }

    }

    public class Coche:Vehiculo
    {
        public Coche(string ruido) : base(ruido)
        {


        }

            
        public override void Conducir()
        {
            Console.WriteLine("Se está conduciendo el coche, ascendiendo por los montes haedinos");

        }

        public override void Aleatorio()
        {
            opcion = Ale.Next(0, 3);

            switch (opcion)
            {
                case 0:
                    Console.WriteLine("¡¡El coche se morfó unos miguelitos, frenó y fue asaltado!!");
                    break;
                case 1:
                    Console.WriteLine("El coche se quedó sin nasta y lo reempujaron 3 kms");
                    break;
                case 2:
                    Console.WriteLine("El coche llegó a lo mas alto de los montes haedinos");
                    break;

            }
        }

    }

    public class Avion : Vehiculo
    {

        public Avion (string ruido): base (ruido)
        {

        }

        public override void Conducir()
        {
            Console.WriteLine("El avión está sobrevolando los montes haedinos");

        }

        public override void Aleatorio()
        {
            opcion = Ale.Next(0, 3);

            switch (opcion)
            {
                case 0:
                    Console.WriteLine("¡¡El avión tuvo inconvenientes durante el despegue y debió retornar al garage!!");
                    break;
                case 1:
                    Console.WriteLine("El avión tuvo inconvenientes para aterrizar y debió retornar al garage, en pedazos y con peritos de por medio");
                    break;
                case 2:
                    Console.WriteLine("El avión aterrizó correctamente, y la muchachada logró conocer al maestro sensei");
                    break;

            }
        }
    }




    public class programejo
    {
        static void Main(string[] args)

        {

        Vehiculo V1 = new Coche("Rum, Rum, Ruuuum, Ruuuuuuuum");
        Vehiculo V2 = new Avion("Ieeeeeeeaaaaaaoooouuuii");
        Vehiculo V3 = new Vehiculo("Japish, japish");

        Vehiculo[] Arraycito = new Vehiculo[3];
            Arraycito[0] = V1;
            Arraycito[1] = V2;
            Arraycito[2] = V3;

            foreach (var item in Arraycito)
            {
                item.ArrancarMotor();
                item.Conducir();
                item.PararMotor();
                item.Aleatorio();
                Console.WriteLine();

            }

            
            Console.ReadKey();
        }

}


}
/*EJERCICIO 1
 * public class Operacion
   {
       protected double valor1;
       protected double valor2;
       protected double resultado;

       public Operacion(double valor1, double valor2)
       {
           this.valor1 = valor1;
           this.valor2 = valor2;

       }



       public virtual  void Operar() { }

   }

   public class Suma: Operacion
   {
       public Suma (double valor1, double valor2): base (valor1, valor2)
       {

       }

       public override void Operar()
       {
           Console.WriteLine("\n" +
               "El resultado de la sumatoria es " + (resultado = valor1 + valor2));

       }

   }

   public class Resta : Operacion
   {
       public Resta(double valor1, double valor2) : base(valor1, valor2)
       {

       }

       public override void Operar()
       {
           Console.WriteLine("\nEl resultado de la resta es " + (resultado = valor1 - valor2));

       }

   }

   class Program
   {
       private double n1;
       private double n2;
       private string respuesta;

       static void Main(string[] args)
       {
           Program P1 = new Program();
           Console.WriteLine("Escriba a continuación el primer número");
           P1.n1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Escriba a continuación el segundo número");
           P1.n2 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("¿Desea realizar suma o resta?");
           P1.respuesta = Console.ReadLine();

           if (P1.respuesta=="suma")
           {
               Suma S1 = new Suma(P1.n1, P1.n2);
               S1.Operar();
           }

           if (P1.respuesta == "resta")
           {
               Resta r1 = new Resta(P1.n1, P1.n2);
               r1.Operar();

           } 


           Console.ReadKey();


       }


EJERCICIO 2

public class Persona
    {
        protected int edad;
        protected string nombre;

        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public virtual void Imprimir() { }

    }


    public class Empleado:Persona
    {
        protected double sueldo;

        public double Sueldo { get => sueldo; set => sueldo = value; }

        public override void Imprimir()
        {
            Console.WriteLine($"El sueldo de {Nombre}, de {Edad} años, es de {Sueldo} pesos");

        }

    }

    public class programjejo
    {

        static void Main(string[] args)
        {
            Empleado P1 = new Empleado();
            P1.Nombre = "Laucha";
            P1.Edad = 34;
            P1.Sueldo = 2500000;
            P1.Imprimir();
            Console.ReadKey();
        }

    }

   }*/


