using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClaseAbstractaPrueba
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

        public void AgregaPsicologos()
        {

            listadoti.Add(new psicoanalista(false, 4, 7));


        }

        public void AgregaPsicologos2()
        {
           listadoti.Add(new psicoanalista(true, 5, 12));


        }
    }



    public class psicoanalista: psicologo
    {
        public int duracionTratamientos;

        public psicoanalista(bool titulo, int anosDeEstudio, int duracionTratamientos)
        {
            this.anosDeEstudio = anosDeEstudio;
            this.duracionTratamientos = duracionTratamientos;
            this.titulo = titulo;
            
        }

    }

    public class Operador
    {
        int duracionTratamientos;
        public psicoanalista p;
        psicologo psi;
       
        public  Operador()
        {
            Random r = new Random();
            duracionTratamientos = r.Next(3, 21);

            p= new psicoanalista(true, 7, duracionTratamientos);
            p.listadoti.Add(p);
            psi.AgregaPsicologos();
            p.AgregaPsicologos2();
            ImprimeListado();
            Console.ReadKey();
        }

      

        public void ImprimeListado()
        {
            for (int i = 0; i < p.listadoti.Count; i++)
            {
                Console.WriteLine(p.listadoti[i].anosDeEstudio+ " "+ p.listadoti[i].duracionTratamientos+ " "+ p.listadoti[i].titulo);
            }
        }
    }


}
/*  Va bastante bien
 *  
 *  
 *  
 *   class Program
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



    public class psicoanalista: psicologo
    {
        public int duracionTratamientos;

        public psicoanalista(bool titulo, int anosDeEstudio, int duracionTratamientos)
        {
            this.anosDeEstudio = anosDeEstudio;
            this.duracionTratamientos = duracionTratamientos;
            this.titulo = titulo;
            
        }

    }

    public class Operador
    {
        int duracionTratamientos;
        public psicoanalista p;
       
        public  Operador()
        {
            Random r = new Random();
            duracionTratamientos = r.Next(3, 21);

            p= new psicoanalista(true, 7, duracionTratamientos);
            p.listadoti.Add(p);
            AgregaPsicologos();
            AgregaPsicologos2();
            ImprimeListado();
            Console.ReadKey();
        }

        public void AgregaPsicologos()
        {
           p.listadoti.Add( new psicoanalista(false, 4, 7));

          
        }

        public void AgregaPsicologos2()
        {
            p.listadoti.Add(new psicoanalista(true, 5, 12));


        }

        public void ImprimeListado()
        {
            for (int i = 0; i < p.listadoti.Count; i++)
            {
                Console.WriteLine(p.listadoti[i].anosDeEstudio+ " "+ p.listadoti[i].duracionTratamientos+ " "+ p.listadoti[i].titulo);
            }
        }
    }
 *  
 *  
 *  
 *  
 *  
 *  
 *  class Program
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



    public class psicoanalista: psicologo
    {
        public int duracionTratamientos;

        public psicoanalista(bool titulo, int anosDeEstudio, int duracionTratamientos)
        {
            this.anosDeEstudio = anosDeEstudio;
            this.duracionTratamientos = duracionTratamientos;
            this.titulo = titulo;
            
        }

    }

    public class Operador
    {
        int duracionTratamientos;
        public psicoanalista p;
        public psicologo psi;
        public  Operador()
        {
            Random r = new Random();
            duracionTratamientos = r.Next(3, 21);

            p= new psicoanalista(true, 7, duracionTratamientos);
         
            AgregaPsicologos();
            ImprimeListado();
            Console.ReadKey();
        }

        public void AgregaPsicologos()
        {
            new psicoanalista(false, 4, 7);

            p.listadoti.Add(p);
        }


        public void ImprimeListado()
        {
            for (int i = 0; i < p.listadoti.Count; i++)
            {
                Console.WriteLine(p.listadoti[i].anosDeEstudio+ " "+ p.listadoti[i].duracionTratamientos+ " "+ p.listadoti[i].titulo);
            }
        }
    }
 *  
 *  
 *  
 *  
 *  No Funca
 *  
 *  public class Operador
    {
        int duracionTratamientos;
        public psicoanalista p;
        public psicologo psi;
        public  Operador()
        {
            Random r = new Random();
            duracionTratamientos = r.Next(3, 21);

           
         
            AgregaPsicologos();
            AgregaPsicologos2();
            ImprimeListado();
            Console.ReadKey();
        }

        public void AgregaPsicologos()
        {
            new psicoanalista(false, 4, 7);

            p.listadoti.Add(p);
        }
        public void AgregaPsicologos2()
        {
            new psicoanalista(true, 7, duracionTratamientos);
            p.listadoti.Add(p);
        }


        public void ImprimeListado()
        {
            for (int i = 0; i < p.listadoti.Count; i++)
            {
                Console.WriteLine(p.listadoti[i].anosDeEstudio+ " "+ p.listadoti[i].duracionTratamientos+ " "+ p.listadoti[i].titulo);
            }
        }
    }*/