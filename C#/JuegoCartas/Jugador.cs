using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCartas
{

    class Jugador
    {
       string nombre;
       List<Carta> cartaJugador;

        public string Nombre { get => nombre; }
        internal List<Carta> CartaJugador { get => cartaJugador; }

        public Jugador( List <Carta> mazoDeCartas)
        {
           nombre= ObtieneNombre();
           cartaJugador= new List<Carta>();
           RecibeCartas(mazoDeCartas);
        }

        public Jugador(string nombre, int sobrante)
        {
            nombre = ObtieneNombre();
            cartaJugador = new List<Carta>();
        }


        public Jugador(List<Carta> mazoDeCartas, string nombreUsuario)
        {
            nombre = nombreUsuario;
            cartaJugador = new List<Carta>();
            RecibeCartas(mazoDeCartas);
        }

        public void 

        private void RecibeCartas(List<Carta> mazoDeCartas)
        {
            for (int i = 0; i < 3; i++)
            {
                int carta = Randomizador.randomiza(0, mazoDeCartas.Count);
                CartaJugador.Add(mazoDeCartas[carta]);
                mazoDeCartas.RemoveAt(carta);
            }

        }


        public string ObtieneNombre()
        {
            int nombreint = Randomizador.randomiza(1, 11);               

            switch (nombreint)
            {
                case 1:
                   return nombre = "Carlos";                  

                case 2:
                    return nombre = "Lucía";
                 
                case 3:
                    return nombre = "Jerónimo";
                  
                case 4:
                    return nombre = "Luis";
                 
                case 5:
                    return nombre = "Pablo, el Grande";
                  
                case 6:
                    return nombre = "Cristina";
                  
                case 7:
                    return nombre = "Lautaro";
                  
                case 8:
                    return nombre = "Uriel";
                  
                case 9:
                    return nombre = "Silvina";
                
                case 10:
                    return nombre = "Robertina";
              
                default:
                    return null;

                    



            }


        }

        public void ImprimeManoDeJugador()
        {
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine(Nombre+ " tiene en su mano:");                 

            foreach (Carta carta in CartaJugador)
            {
                Console.WriteLine(carta.Numero+ " de " +carta.Palo+ "s");
            }
        }
    }
     
   

}
