using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InviertoDependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            var colchonCannon = new Cannon();
            Cama cama1 = new Cama(colchonCannon, persona);
            cama1.ImprimeData();
            persona.ObtieneAltura();
            Console.WriteLine("El colchón mide "+ colchonCannon.RetornaLargoCama());

            Console.WriteLine("----------------------------------------------\n");

            var colchonDia = new Dia();
            Cama cama2 = new Cama(colchonDia, persona);
            cama2.ImprimeData();
            persona.ObtieneAltura();
            Console.WriteLine("El colchón mide " + colchonDia.RetornaLargoCama());
        
            Console.ReadKey();

        }
    }


    public class Cama
    {
        private readonly Colchon colchon;
        private readonly Persona persona;
        public Cama(Colchon colchon, Persona persona)
        {
            this.colchon = colchon;
            this.persona = persona;
        }

        public void ImprimeData()
        {
            colchon.ObtieneCalidad();
            colchon.ObtieneTamaño();
        }

        public void EntraPersona()
        {
            if (persona.ObtieneAltura() <= colchon.RetornaLargoCama())
            {
                Console.WriteLine("La persona entra en la cama");
            }

            else if (colchon.RetornaLargoCama() - persona.ObtieneAltura() <= -15)
            {
                Console.WriteLine("¡¡Oh no!! los piecitos quedan colgando");
            }     
            else
            {
                Console.WriteLine("La persona claramente no entra en esa cama");
            }


            
        }
            

    }

    public class Cannon : Colchon
    {
        public Cannon()
        {
            this.Calidad = "Premium";
            this.Largo = 190;
            this.Ancho = 150;
            this.Precio = 35000d;
        }
    }

    public class Camitonga : Colchon
    {
        public Camitonga()
        {
            this.Calidad = "Baja";
            this.Largo = 180;
            this.Ancho = 70;
            this.Precio = 13000d;
        }
    }

    public class Dia : Colchon
    {
        public Dia()
        {
            this.Calidad = "Media";
            this.Largo = 180;
            this.Ancho = 90;
            this.Precio = 19000d;
        }
    }

    public abstract class Colchon
    {
        protected string Calidad { get; set; }
        protected int Largo { get; set; }
        protected int Ancho { get; set; }
        protected double Precio { get; set; }

        public void ObtieneTamaño()
        {
            Console.WriteLine("El colchón mide " + Largo + " cms de largo y " + Ancho + " de ancho."); ;
        }
        public void ObtieneCalidad()
        {
            Console.WriteLine("El colchón " + this.GetType().Name + " es de calidad " + Calidad + ".");
        }

        public int RetornaLargoCama()
        {
            return Largo;
        }
    }

    public class Persona
    {
        int Altura { get; set; }

        public int ObtieneAltura()
        {
            Random random = new Random();
            Altura = random.Next(140,220);
            return Altura;
        }

        public void obtienePersona()
        {
            Console.WriteLine("La persona mide "+Altura);
        }
       


    }

}
