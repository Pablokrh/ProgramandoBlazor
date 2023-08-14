using System;

namespace LanzamientoDeExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce el número de mes");


            try
            {
                int numeroMes = Int32.Parse(Console.ReadLine()); //esta línea la puse yo dentro del try, si no, se rompe el programa si uno le pasa un string en vez de un numero

                Console.WriteLine(NombreDelMes(numeroMes));//Le pasa por parámetro lo escrito por el usuario.

            }
            catch (Exception ex)
            {
                Console.WriteLine("Mensaje de la excepción: " +ex.Message);
            }
            Console.WriteLine("Aquí se continúa ejecutando el programa");
        }



        public static string NombreDelMes (int mes)
        {

            switch (mes)
            {
                case 1:
                    return "Enero";

                case 2:
                    return "Febrero";

                case 3:
                    return "Marzo";

                case 4:
                    return "Abril";

                case 5:
                    return "Mayo";

                case 6:
                    return "Junio";

                case 7:
                    return "Julio";

                case 8:
                    return "Agosto";

                case 9:
                    return "Septiembre";

                case 10:
                    return "Octubre";

                case 11:
                    return "Noviembre";

                case 12:
                    return "Diciembre";


                /*default: // Esta es una de las opciones que se podrían llevar a cabo
                    return "Dato erróneo"; //WOW. Jamás visto. */

                default:
                    throw new ArgumentOutOfRangeException(); //se crea un objeto de este tipo.
            }

            
        }
    }
}
