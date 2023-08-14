using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3KrojzlPablo
{
    class Persona
    {
        private string nombre;
        private string eMail;
        private string sexo;
        private int sueldo;
        private int peso;
        private double altura;

        public Persona(string nombre, int sueldo, int peso, double altura, string sexo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
            CrearEMail();
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getEMail()
        {
            return eMail;
        }
        public string getSexo()
        {
            return sexo;
        }

        public int getSueldo()
        {
            return sueldo;
        }
        public int getPeso()
        {
            return peso;
        }
       
        public double getAltura()
        {
            return altura;
        }

        private void CrearEMail()
        {
            eMail = nombre + "@superempresa.com";
        }

    }
}
