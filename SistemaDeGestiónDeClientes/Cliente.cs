using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestiónDeClientes
{
    class Cliente
    {
        private string nombre; 
       

        public string Nombre //Con mayúscula
        {
            get { return nombre; }
            set { nombre = value; } //El value lo genera automáticamente el set. Es lo que pone el usuario.
        }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string TarjetaDeCredito { get; set; }

        public override string ToString()
        {
            return nombre + " " + Apellido + ". " + Telefono + ". " + TarjetaDeCredito;

        }
    }

}

