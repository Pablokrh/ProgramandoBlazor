using System;

namespace AvisosVarios
{
    class Program
    {
        static void Main(string[] args)
        {

            AvisosTrafico Av1 = new AvisosTrafico(); //Este llama al constructor por defecto.
            Av1.MostrarAviso();
            AvisosTrafico Av2 = new AvisosTrafico("Policía Federal", "Sanción por fealdad extrema", "14 de enero de 2023");
            Av2.MostrarAviso();
            Console.WriteLine(Av2.getFecha());

        }
    }

    
}

