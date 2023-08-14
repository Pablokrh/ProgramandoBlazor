using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexadoresEIteradores
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperaturas t = new Temperaturas();
            t[2] = 11.5f;
            //Ahí estoy modificando el índice 2 del array.

            for (int i = 0; i < t.len; i++)
            {
                Console.WriteLine("Item N° " + (i + 1) + ": " + t[i]);
            }
            Console.WriteLine("\n--------------------------------------\n");

            DiasSemana ds = new DiasSemana();
            Console.WriteLine(ds["Lunes"]);
            try
            {
                Console.WriteLine(ds["Vienés"]);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

        }
    }

    //Recurso que nos permite acceder a una estructura de datos tipo matriz

    public class Temperaturas
    {
        float[] temp = new float[10]
        {
        10f, 11f, 10f, 7f, 8f,
        5f, 12f, 10f, 11f, 10f,
        };

        public int len => temp.Length;

        //acá se entra en tema nuevo:
        public float this[int index]
        {
            get => temp[index];
            set => temp[index] = value;
        }

    }

    public class DiasSemana
    {
        public string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

        public string this [string dia]=> FindDayIndex(dia);

        private string FindDayIndex(string dia)
        {
            for (int i = 0; i < dias.Length; i++)
            {
                if (dia == dias[i])
                {
                    return "El día " + dia + " está en el índice " + i;
                }                                
            }
            
            throw new ArgumentOutOfRangeException(nameof(dia), $"El día {dia} no es válido para el idioma y formato actual.");
        }

        
    }



}
