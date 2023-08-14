using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodos_y_Listas
{



    class Vector
    {

        private int[] Array;

        public Vector()
        {
        
        }

        public void LlenarArray()
        {
            int tamano;
            Console.WriteLine("Escriba aquí el tamaño que tendrá el array:");
            tamano = int.Parse(Console.ReadLine());
            Array = new int[tamano];

            for (int i = 0; i < Array.Length; i++)
            {
                
                Console.WriteLine("Elija el valor a ingresar, en la posición N°:" + (i + 1));
                Array[i] = int.Parse(Console.ReadLine());

            }

        }
            public void PrinteaArray()
            {
             int cant = 0;
            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("El/los siguiente/s número/s está/n por arriba de 100");
                foreach (var item in Array)
                    {
                        if (item > 100)
                        {
                                Console.Write(item+ " , ");
                                cant++;
                        }
                    }
            Console.WriteLine();
            Console.WriteLine("El número total de números por encima de los 100 es:" + cant); 
            }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector CV = new Vector();
            CV.LlenarArray();
            CV.PrinteaArray();
            Console.ReadKey();
        }
    }
}
/*
 *     class Nodo
    {
        private int dato;
        private Nodo siguiente;
        //Es decir, cada nodo tiene un apuntador que apunta al nodo siguiente.

        public int Dato
        { 
         get { return dato;}
         set { dato = value;}
        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

    }

    class Lista
    {
        private Nodo Primero = new Nodo();
        //Ese va a ser el primer nodo de la lista y el de abajo el último. Siempre será así. En un primer momento coinciden.
        private Nodo Ultimo = new Nodo();

        public Lista()
        {
            Primero = null;
            Ultimo = null;
            //Los inicializa a ambos como null, en el método constructor.          
        }
        public void InsertarNodo()
        {
            Nodo Nuevo = new Nodo();
            //cada vez que el usuario quiera crear un nuevo nodo, por lo que:
            //creará un objeto de la clase Nodo. Mas abajo (Nuevo.Dato) se ve como le da
            //el valor al mismo.
            Console.WriteLine("Ingrese el dato que contendrá el nuevo nodo:");
            Nuevo.Dato = int.Parse(Console.ReadLine());
           
            if (Primero==null)
                //esto es true cuando se ingresa el primer Nodo
            {
                Primero = Nuevo;
                Primero.Siguiente = null;
                //apunta a null
                Ultimo = Nuevo;
            }
            {
                Ultimo.Siguiente = Nuevo;
                //El último, es decir el que ingresamos al ppio, apuntará a este nuevo, segundo nodo.
                Nuevo.Siguiente = null;
                Ultimo = Nuevo; 
                //El último ahora, es el nuevo nodo ingresado.
            }
            //En esa pequeña estructura se ve que Primero y Primero.Siguiente se definen en el if y no se pisan con cada nuevo Nodo ingresado.
            //El ùltimo, por el contrario si. Porque cada nodo ingresado es el ùltimo.
            Console.WriteLine("\n Nodo Ingresado\n ");


        }

        public void DesplegarLista()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            //O sea el primero ingresado, el que entra por el if.
            if (Primero!=null)
            //Si es diferente de Null es que hay nodos en la lista
            {
                while (Actual!=null)
                //Del "otro null" por así decir, al que le apunta el último ingresado.
                {
                    Console.WriteLine("{0}", Actual.Dato);
                    //Esto le imprime el valor que tenga Actual.Dato.
                    Actual = Actual.Siguiente;
                    

                }
            }
                else
                {
                Console.WriteLine("\n La lista se encuentra vacía \n");
                }
            
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Lista Liss = new Lista();
            Liss.InsertarNodo();
            Liss.InsertarNodo();
            Liss.InsertarNodo();
            Liss.InsertarNodo();
            Liss.InsertarNodo();

            Console.WriteLine();
            Console.WriteLine("La lista de nodos ingresados es:");
            Liss.DesplegarLista();
            
            Console.ReadKey();
        }
    }*/