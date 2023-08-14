using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_HC1
{
    class Validaciones
    {
        string contraseña="1234";
        string nombreDeUsuario="Pepe";
        bool valido = true;

        public bool validar (string nombreDeUsuario, string contraseña)
        {
            if (this.contraseña == contraseña && this.nombreDeUsuario == nombreDeUsuario)
            {
                return valido;
            }
            else return valido = false;

        }

    }
}
