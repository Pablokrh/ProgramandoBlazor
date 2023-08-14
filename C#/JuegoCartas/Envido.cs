using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCartas
{
    class Envido
    {
        int envidoJ;
        List<int> puntaje = new List<int>();
        

        public void JugarEnvido(List <Jugador> jugadores)
        {
            for (int i = 0; i < jugadores.Count; i++)
            {
                Console.WriteLine("---------------------------------------");


                if (jugadores[i].CartaJugador[0].Palo == jugadores[i].CartaJugador[1].Palo && jugadores[i].CartaJugador[0].Palo == jugadores[i].CartaJugador[2].Palo)
                {
                    envidoJ = jugadores[i].CartaJugador[0].ValorEnv + jugadores[i].CartaJugador[1].ValorEnv + jugadores[i].CartaJugador[2].ValorEnv + 20;
                    Console.Write("¡¡" + jugadores[i].Nombre + " tiene Flor!!. Sus cartas suman "+ envidoJ);
                }

                else
                {
                    if (jugadores[i].CartaJugador[0].Palo == jugadores[i].CartaJugador[1].Palo)
                    {
                        envidoJ = jugadores[i].CartaJugador[0].ValorEnv + jugadores[i].CartaJugador[1].ValorEnv+20;
                        Console.WriteLine(jugadores[i].Nombre +" tiene "+ envidoJ + " de envido");
                    }
                   else if (jugadores[i].CartaJugador[0].Palo == jugadores[i].CartaJugador[2].Palo)
                    {
                        envidoJ = jugadores[i].CartaJugador[0].ValorEnv + jugadores[i].CartaJugador[2].ValorEnv+20;
                        Console.WriteLine(jugadores[i].Nombre + " tiene " + envidoJ + " de envido");
                    }
                    else if (jugadores[i].CartaJugador[1].Palo == jugadores[i].CartaJugador[2].Palo)
                    {
                        envidoJ = jugadores[i].CartaJugador[1].ValorEnv + jugadores[i].CartaJugador[2].ValorEnv+20;
                        Console.WriteLine(jugadores[i].Nombre + " tiene " + envidoJ + " de envido");
                    }

                    else
                    {
                        if (jugadores[i].CartaJugador[0].ValorEnv>= jugadores[i].CartaJugador[1].ValorEnv && jugadores[i].CartaJugador[0].ValorEnv >= jugadores[i].CartaJugador[2].ValorEnv)
                        {
                            envidoJ = jugadores[i].CartaJugador[0].ValorEnv;
                        }

                        if (jugadores[i].CartaJugador[1].ValorEnv >= jugadores[i].CartaJugador[0].ValorEnv && jugadores[i].CartaJugador[1].ValorEnv >= jugadores[i].CartaJugador[2].ValorEnv)
                        {
                            envidoJ = jugadores[i].CartaJugador[1].ValorEnv;
                        }

                        if (jugadores[i].CartaJugador[2].ValorEnv >= jugadores[i].CartaJugador[0].ValorEnv && jugadores[i].CartaJugador[2].ValorEnv >= jugadores[i].CartaJugador[1].ValorEnv)
                        {
                            envidoJ = jugadores[i].CartaJugador[2].ValorEnv;
                        }
                        Console.WriteLine(jugadores[i].Nombre + " tiene " + envidoJ + " de envido");

                    }

                }
                puntaje.Add(envidoJ);



            }

            Console.WriteLine("\n------------------------------------------");
            if (puntaje[0] > puntaje[1])
            {
                Console.WriteLine("Ha ganado " + jugadores[0].Nombre);

            }

            else if (puntaje[0] < puntaje[1])
            {
                Console.WriteLine("Ha ganado " + jugadores[1].Nombre);

            }

            else Console.WriteLine("Ha ganado " + jugadores[0].Nombre + " por ser mano");

        }

    }
}
