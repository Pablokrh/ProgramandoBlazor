using System;
using System.Collections.Generic;
using System.Text;

namespace AvisosVarios
{
    class AvisosTrafico : IAvisos
    { //2 constructores. Uno con parámetros y otro sin parámetros. El segundo, sin parámetros, es el mas genérico.
        
        public AvisosTrafico()
        {
            Remitente = "DirGenTra";
            Mensaje = "Sanción cometida. Pague antes de 3 días y se beneficiará en su sanción en un 50%";
            Fecha = "";
        }

        public AvisosTrafico (String Rem, string Mensaje, String Fec) //"se llamaban igual" (podrían hacerlo) que los campos de clase, sus nombres podrían ser bien otros.
        {
            //El this siempre refiere a la clase

            this.Remitente = Rem;
            this.Mensaje = Mensaje;
            this.Fecha = Fec;
        }
            public string getFecha()
        {
            return  Fecha;
        }

        public void MostrarAviso()
        {
            Console.WriteLine("Mensaje {0} ha sido enviado por {1} el día {2}" , Mensaje, Remitente, Fecha);
            //estos blanquitos post string, son los parámetros que se pasan a los numueros entrellaves
        }

        private string Remitente;
        private string Mensaje;
        private string Fecha;
    }
}
