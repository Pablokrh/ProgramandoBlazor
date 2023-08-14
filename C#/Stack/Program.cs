using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaPersonas listaPersonas = new ListaPersonas();

            Ramiro ramiro = new Ramiro();
            Cassandra cassandra = new Cassandra();
            Lucas lucas = new Lucas();
            Andrea andrea = new Andrea();
            Horacio horacio = new Horacio();

            listaPersonas.SumaPersonas(ramiro);
            listaPersonas.SumaPersonas(cassandra);
            listaPersonas.SumaPersonas(lucas);
            listaPersonas.SumaPersonas(andrea);
            listaPersonas.SumaPersonas(horacio);







        }
    }



    public class CocaCola
    {
        int cantidadVasos = 10;
        public int CantidadVasos()
        {
            return cantidadVasos;
        }
    }

   public abstract class Persona
   {
        protected string nombre;
        private CocaCola cocacola;
        protected string stringGanar;
        protected int tomaVasos = Aleatoriza.Tirar();

        public int TomaCoca(CocaCola cocacola)
        {
            if (cocacola.CantidadVasos() > 0)
            {
              return cocacola.CantidadVasos() - tomaVasos;

            }
            Console.WriteLine("Ha pasado del turno de "+ nombre +" y quedan "+ cocacola.CantidadVasos()+ " en la botella");
            return cocacola.CantidadVasos();
        }
   }

    public class Ramiro : Persona
    {
        public Ramiro()
        {
            nombre = "Ramiro";
            stringGanar = "Aleluyaa!!";
        }
    }
    public class Cassandra : Persona
    {
        public Cassandra()
        {
            nombre = "Cassandra";
            stringGanar = "I have won, iupi!!";
        }
    }
    public class Lucas : Persona
    {
        public Lucas()
        {
            nombre = "Lucas";
            stringGanar = "Se viene Boooocaaaa!!";
        }
    }
    public class Andrea : Persona
    {
        public Andrea()
        {
            nombre = "Andrea";
            stringGanar = "Ay, que buena ondis!";
        }
    }
    public class Horacio : Persona
    {
        public Horacio()
        {
            nombre = "Horacio";
            stringGanar = "Tomen putos!!";
        }
    }

    public class ListaPersonas
    {
        List<Persona> personas = new List<Persona>();
        public void SumaPersonas(Persona persona)
        {
            personas.Add(persona);
        }

    }

    static class Aleatoriza
    {
        private static Random aleatorio = new Random();

        public static int Tirar(int min=1, int max=4)
        {
            return aleatorio.Next(min, max);
        }
    }
}

