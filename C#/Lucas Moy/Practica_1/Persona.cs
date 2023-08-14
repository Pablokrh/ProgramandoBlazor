using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    class Persona
    {
        private string Nombre;
        private string Nid;
        string pais;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
       // public string Nid1 { get => Nid; set => Nid = value; }
       // public string Pais { get => pais; set => pais = value; }
       public string Pais
        {
            get { return "Mi país es: " + pais; }
            set { pais = value; }
        }
        public string nid { get; set; }

    }
}
