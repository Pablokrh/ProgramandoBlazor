using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class telefono
    {
        private string marca = "";
        private string color = "";
        private string tipo = "";

        public telefono()
        { 
            marca = "Motorola";
            color = "Blanco";
            tipo = "Screentouch";

        }
        public telefono(string M, string C, string T)
        {
            marca = M;   //Aquí la Marca va a ser igual a lo que se le pase como parámetro.
            color = C;
            tipo = T;

        }
        public void llamar () 
        {
            System.Windows.Forms.MessageBox.Show("Tu celular es un: " + marca + ", de color "+ color + " y, de tipo "+ tipo);

        }

        public string mandarMensaje (string N, string msj)
        {
            string Nombre = N;
            string Mensaje = msj;

            string enviandoMsj= "El mensaje: " + Mensaje + ", enviado por: " + Nombre;

            return enviandoMsj;
        }

    }
}
