using System;
using System.IO;

namespace Destructores
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos miArchivo = new ManejoArchivos();
            miArchivo.Mensaje();
        }
    }
    class ManejoArchivos
    {
        StreamReader archivo = null;
        int contador = 0;
        string linea;
        public ManejoArchivos()
        {
           archivo = new StreamReader(@"C:\Users\Pcablo\Desktop\Programando\C#\tirar.txt");
           //arriba se abre la conexión, flujo de datos. Si no se cierra, una vez que se leyó,  consume recursos.
            while ((linea = archivo.ReadLine()) != null)
            {

                Console.WriteLine(linea);
                contador++;
            }
        }
        public void Mensaje()
        {
            Console.WriteLine("Hay {0} lineas", contador);
        }
       //Alt 126 ~
        ~ManejoArchivos() //es igual el nombre que el constructor
        {
            archivo.Close(); //Ahí se cierra el flujo de datos.
        }
    }

    
}
