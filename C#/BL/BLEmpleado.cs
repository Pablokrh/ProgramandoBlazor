using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLEmpleado
    {
        DAL.DALEmpleado dalempleado = new DAL.DALEmpleado();

        public String VerificarUsuario (EN.ENEmpleado enempleado)
        {
            return dalempleado.VerificarUsuario(enempleado);
        }

        public String VerificarClave (EN.ENEmpleado enempleado)
        {
            string ClaveVerifiqueta = dalempleado.VerificarClave(enempleado);
            return ClaveVerifiqueta;

        }

    }
}
