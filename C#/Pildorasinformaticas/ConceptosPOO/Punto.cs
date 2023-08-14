using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptosPOO
{
    class Punto
    {
        public Punto (int x, int y)
        {
            this.x = x;
            this.y = y;
            contadorDeObjetos++; //cada vez que se cree un objeto de tipo punto, se va a incrementar en uno el valor este
        }
        public Punto() //este es el constructor por defecto. Cuando no se pasan parámetros.
        {
            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;

        }

        public double DistanciaHasta (Punto otroPunto) //Este parámetro es un objeto.
        {
            int xDif = this.x - otroPunto.x; //estos this de acá hacen referencia al objeto desde el cual se llama al método. Es decir: double distancia = origen.DistanciaHasta(destino)
            int yDif = this.y - otroPunto.y;
            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2)); //teórema de pitágoras. Para eso se va a usar la clase math.

            return distanciaPuntos;
        }


        private static int contadorDeObjetos = 0;

        public static int retornaContador()
        {
            return contadorDeObjetos;
        }

        private int x, y;  //campos de clase, les llama. Propiedades, serían. Él los pone al final.

        
    }
}
