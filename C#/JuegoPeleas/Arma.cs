using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPeleas
{
    abstract class Arma
    {
        internal string nombre;
        internal int daño;
        internal int velocidad;


        internal string Nombre { get => nombre;  }
        internal int Daño { get => daño; }
        internal int Velocidad { get => velocidad;  }

       

    }

    class Cuchillo : Arma
    {
        public Cuchillo()
        {
            nombre = "cuchillo";
            daño = 18;
            velocidad = 5;
        }
    }

    class Lanza : Arma
    {
        public Lanza()
        {
            nombre = "lanza";
            daño = 22;
            velocidad = 10;

        }
    }
    class Desarmado : Arma
    {
        public Desarmado()
        {
           nombre = "desarmado";
           daño = 10;
           velocidad = 1;
        }


    }

   
}
