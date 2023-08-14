using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            int miNumero;
            int intentos = 0;
            Console.WriteLine("Introduce un N° entre 0 y 100");
            do
            {
                intentos++;
                try
                {
                    miNumero = Int32.Parse(Console.ReadLine()); //Si se introduce un texto el programa no será capaz de convertirlo a entero. Ahí da error el programa y se detiene.
                }
                
                catch (Exception ex) when (ex.GetType()!=typeof(FormatException)) //ex.GetType devuelve el tipo de excepción ocurrida. Cualquier excepción distinta a la indicada, se ejecutará lo que está dentro de este catch "genérico". Luego se hace el otro catch, con su tratamiento específico.
                {
                    Console.WriteLine("Has introducido un valor demasiado alto . Se toma como número introducido el 0");
                    miNumero = 0; //dice que esta linea es una solución poco elegante. Si no hacía esto, el próximo miNumero iba a dar error.
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Has introducido texto. Ingrese solamente números");
                    miNumero = 0;
                }

                if (miNumero > aleatorio) Console.WriteLine("El N° es mas bajo");
                if (miNumero < aleatorio) Console.WriteLine("El N° es mas alto");
            } while (aleatorio != miNumero);

            Console.WriteLine($"¡Correcto! Has necesitado {intentos} intentos" );

        }
    }
}
