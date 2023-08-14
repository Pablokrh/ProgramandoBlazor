using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        public int Id { get; }
        public string NombreCompleto { get; }
        public string Dni { get; }
        public int Edad { get; }
        public bool Casado { get; }
        public float Salario { get; }

        public Empleado(string idAux, string nombreCompleto, string dniAux, string edadAux, string casadoAux, string salarioAux)
        {
            Id = int.Parse(idAux);
            NombreCompleto = nombreCompleto;
            Dni = dniAux;
            Edad = int.Parse(edadAux);
            Casado = bool.Parse(casadoAux);
            Salario = float.Parse(salarioAux);
        }
    }
}
