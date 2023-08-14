using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema8
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona miPersona = new Persona();
            miPersona.SetNombre("Pablo");
            miPersona.SetEdad(35);
            miPersona.SetTelefono("541159123081");

            Console.WriteLine("El usuario "+ miPersona.GetNombre() + " tiene "
            +miPersona.GetEdad() + " años y su número de teléfono es "+ miPersona.GetTelefono());
            Console.ReadKey();
        }
    }

    public class Persona
    {
        private string nombre;
        private int edad;
        private string telefono;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public int GetEdad()
        {
            return edad;
        }
        
        public void SetTelefono(string telefono)
        {
            this.telefono = telefono;
        }

        public string GetTelefono()
        {
            return telefono;
        }
    }
}
