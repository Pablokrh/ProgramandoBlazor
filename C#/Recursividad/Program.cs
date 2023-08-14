using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Recursividad
{
    public class Recursividad
    {

        public void Leer(string inicio)
        {
            
            
            
            
            
            String[] directorios = Directory.GetDirectories(inicio);

            for (int i = 0; i < directorios.Length; i++)
            {
                Console.WriteLine(directorios[i]);
            }
            Console.ReadKey();

            String[] archivos = Directory.GetFiles(inicio);
            Console.WriteLine(inicio + " (Directorio)");
            for (int f = 0; f < archivos.Length; f++)
            {
                Console.WriteLine(archivos[f] + " (Archivo)");
                Console.ReadKey();
            }
            for (int f = 0; f < directorios.Length; f++)
            {
                Leer(directorios[f]);
            }
        }

        static void Main(string[] args)
        {
            Recursividad rec = new Recursividad();
            rec.Leer("c:\\Windows\\");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}


/* 
 *  public class Recursividad
    {

        public void Leer(string inicio)
        {
            
            
            
            
            
            String[] directorios = Directory.GetDirectories(inicio);

            for (int i = 0; i < directorios.Length; i++)
            {
                Console.WriteLine(directorios[i]);
            }
            Console.ReadKey();

            String[] archivos = Directory.GetFiles(inicio);
            Console.WriteLine(inicio + " (Directorio)");
            for (int f = 0; f < archivos.Length; f++)
            {
                Console.WriteLine(archivos[f] + " (Archivo)");
                Console.ReadKey();
            }
            for (int f = 0; f < directorios.Length; f++)
            {
                Leer(directorios[f]);
            }
        }

        static void Main(string[] args)
        {
            Recursividad rec = new Recursividad();
            rec.Leer("c:\\Windows\\");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
 * 
 * public class Recursividad
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }

        private Nodo raiz;

        void InsertarPrimero(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;
            nuevo.sig = raiz;
            raiz = nuevo;
        }

        private void ImprimirInversa(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirInversa(reco.sig);
                Console.Write(reco.info + "-");
            }
        }

        public void ImprimirInversa()
        {
            ImprimirInversa(raiz);
        }

        static void Main(string[] args)
        {
            Recursividad r = new Recursividad();
            r.InsertarPrimero(10);
            r.InsertarPrimero(4);
            r.InsertarPrimero(5);
            r.ImprimirInversa();
            Console.ReadKey();
        }
    }
 * 
 * SON TODOS EJEMPLOS DE RECURSIVIDAD, DONDE QUIZAS MEJOR HUBIESE SIDO USAR UNA ESTRUCTURA REPETITIVA
 *  class Recursividad
    {
        int[] vectore = { 312, 453, 634, 12, 135, 985, 345 };

        void Ordenar (int [] vc, int cant)
        {
            if (cant>1)
            {
                for (int i = 0; i < cant-1; i++)
                {
                    if (vc[i]> vc[i + 1]) 
                    //O sea, si el número actual es mayor que el número siguiente
                    {
                        int aux = vc[i]; //Se pasa a variable auxiliar el valor del numero actual
                        vc[i] = vc[i + 1]; //se copia al número actual el valor del siguiente
                        vc[i + 1] = aux; //se pasa al numero siguiente el viejo valor del actual, por medio del auxiliar.
                    }
                }
                Ordenar(vc, cant - 1);
            }
        }

        void Procesar()
        {

            Ordenar(vectore, vectore.Length);
            //no entiendo por que se crea este método, que solo pasa los parámetros a Ordenar ¿?!!
        }

        void Imprimir()
        {

            for (int i = 0; i < vectore.Length; i++)
            {
                Console.WriteLine(vectore[i]+ " ");
                Console.WriteLine();
            }

        }


     

        static void Main(string[] args)
        {
            Recursividad re = new Recursividad();
            Console.WriteLine("Lista de elementos sin ordenar:");
            Console.WriteLine();
            re.Imprimir();    
            re.Procesar();
            Console.WriteLine("______________________________");
            Console.WriteLine();
            Console.WriteLine("Lista de elementos ordenados");
            Console.WriteLine();
            re.Imprimir();
            Console.ReadKey();

        }
    }
 * 
 *  class Recursividad
    {
        int Factorial (int fact)
        {
            if (fact>0)
            {
                int valor;
                valor = fact * Factorial(fact - 1);
                //Este fact -1 e lo que se le pasa como parámetro al método
                //Luego hace 4 (del fact) por (Factorial(fact-1) que es 3, por Factorial(fact-1) que es 2
               return valor;
            }
            else
            {
                return 1;
            }

        }
        static void Main(string[] args)
        {
            Recursividad re = new Recursividad();
            Console.WriteLine("Introduzca el número a factorizar:");
            int numero = int.Parse(Console.ReadLine());

           int f= re.Factorial(numero);
            Console.WriteLine("El factorial de " + numero+ " es: " +f);
            Console.ReadKey();

        }
    }
 * 
 * class Recursividad
    {
        void Imprimir (int x)
        {
            if (x > 0)
            {
                Console.WriteLine("Se está ejecutando el método recursivo");
                Console.Write(x+ " ");
                 Imprimir(x - 1);

            }

        }

        static void Main(string[] args)
        {
            Recursividad re = new Recursividad();
            re.Imprimir(8777);
            Console.WriteLine("El método recursivo ya se ha ejecutado");
            Console.ReadKey();
        }
    }

 * class Recursividad
    {
        void Imprimir (int x)
        {
            Console.Write(x+ " ");
            Imprimir(x - 1);
        }

        static void Main(string[] args)
        {
            Recursividad re = new Recursividad();
            re.Imprimir(5);
            Console.ReadKey();

        }
    }*/