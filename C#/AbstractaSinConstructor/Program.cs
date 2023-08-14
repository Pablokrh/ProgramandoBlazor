using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractaSinConstructor
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Operador o = new Operador();
        }
    }


    public abstract class psicologo
    {
        public bool titulo;
        public int anosDeEstudio;
        public List<psicoanalista> listadoti = new List<psicoanalista>();

        public void Ejercer()
        {
            Console.WriteLine("El muchacho está ejerciendo");

        }


    }



    public class psicoanalista : psicologo
    {
        public int duracionTratamientos;

        

    }

    public class Operador
    {
        int duracionTratamientos;
        public psicoanalista p = new psicoanalista();

        public Operador()
        {
            Random r = new Random();
            duracionTratamientos = r.Next(3, 21);

            p.titulo = true;
            p.anosDeEstudio = 8;
            p.duracionTratamientos = 5;
            p.listadoti.Add(p);
            AgregaPsicologos();
            AgregaPsicologos2();
            AgregaPsicologos3();
            ImprimeListado();
            Console.ReadKey();
        }

        public void AgregaPsicologos()
        {
            p.anosDeEstudio = 5;
            p.duracionTratamientos = 15;
            p.titulo = true;
            p.listadoti.Add(new psicoanalista());


        }

        public void AgregaPsicologos2()
        {
            p.anosDeEstudio = 6;
            p.duracionTratamientos =24;
            p.titulo = false;
            p.listadoti.Add(new psicoanalista());


        }
        public void AgregaPsicologos3()
        {
            p.anosDeEstudio = 1;
            p.duracionTratamientos = 33;
            p.titulo = false;
            p.listadoti.Add(new psicoanalista());


        }

        public void ImprimeListado()
        {
            Console.WriteLine("Cantidad de elementos en listadoti: "+ p.listadoti.Count);
            for (int i = 0; i < p.listadoti.Count; i++)
            {
                Console.WriteLine(p.listadoti[i].anosDeEstudio + " " + p.listadoti[i].duracionTratamientos + " " + p.listadoti[i].titulo);
            }
        }
    }
}
