using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3ClasesyObjetos
{
    class Auto
    {
        private string color;
        private int año;
        private string modelo;
        private int velocidad;
        private int puertas; 

        public Auto(string color, int año, int puertas, string modelo)
        {
            this.color = color;
            this.año = año;
            this.puertas = puertas;
            this.modelo = modelo;
        }
         

        public void Acelerar(int velocidadNueva)
        {

            this.velocidad = velocidadNueva;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return this.color;
        }

        public string GetAño()
        {
            return this.año.ToString();
        }

        public string GetModelo()
        {
            return modelo;
        }

        public string GetPuertas()
        {
            return puertas.ToString();
        }

        /*
     public Auto(string color, int año, int puertas, string modelo)
     {
         this.color = color;
         this.año = año;
         this.puertas = puertas;
         this.modelo = modelo;
     }

 */


    }
}
