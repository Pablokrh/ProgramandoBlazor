using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN2_BLL
{
    public class Negocios
    {
        TPN2_DAL.Datos datos = new TPN2_DAL.Datos();


        public string HolaMundo(string opcion)
        {
            return datos.HolaMundo(opcion);
        }
    }
}
