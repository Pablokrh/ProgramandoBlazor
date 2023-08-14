using System;

namespace Finally_tirar
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null; //se crea un objeto archivo.

            try
            {

                string linea;
                int contador = 0;
                string path = @"C:\Users\Pcablo\Desktop\Programando\C#\tirar.txt"; //acá está el archivo tirar.txt

                archivo = new System.IO.StreamReader(path);
                while ((linea=archivo.ReadLine())!=null)// para recorrer lo que haya dentro del archivo. Lo de null es para que en el archivo las lineas tengan algo, no estén vacías. Cuando haya linea vacía sale del bucle.
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }catch (Exception ex)
            {
                Console.WriteLine("Error con la lectura del archivo.");
            }
            finally
            {
                if (archivo != null) archivo.Close(); //Distinto de nulo, porque si es nulo, no hay nada que cerrar. Incluso daría un error.
                Console.WriteLine("Conexión con el fichero cerrada");
            }



        }
    }
}
