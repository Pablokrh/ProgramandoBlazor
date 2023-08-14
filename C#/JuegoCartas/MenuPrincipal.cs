using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCartas
{
    class MenuPrincipal
    {

        List<Jugador> jugadores;

        Jugador jugador1;
        Jugador jugador2;
        Mazo mazo;

        internal Jugador Jugador1 { get => jugador1; }
        internal Jugador Jugador2 { get => jugador2; }
        internal Mazo Mazo { get => mazo; }

        public MenuPrincipal()
        {
            mazo = new Mazo();
            jugadores = new List<Jugador>();
            MenuPresentacion();

        }

        public void MenuPresentacion()
        {
            bool avanzar = false;

            do
            {
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("XXX--------------BIENVENIDO AL CAMPO DE JUEGOS SXXI----------------XXX\n");
                Console.WriteLine("Elija su acción a través del índice numérico");
                Console.WriteLine("1- Truco");
                Console.WriteLine("2- Culo Sucio");

                int respuesta = int.Parse(Console.ReadLine());
                EligeJuego(respuesta, ref avanzar);

            } while (avanzar == false);

        }

        private void EligeJuego (int respuesta, ref bool avanzar)
        {
            switch (respuesta)
            {
                case 1:
                    MenuTruco(ref avanzar);
                    break;

                case 2:
                    MenuCuloSucio(ref avanzar);
                    break;

                default:
                    break;




            }

        }

        public void MenuCuloSucio(ref bool avanzar)
        {
            do
            {
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("XXX--------------JUEGAZO DE Culo Sucio SXXI----------------XXX\n");
                Console.WriteLine("Elija su acción a través del índice numérico");                
                Console.WriteLine("1 - Elegir Personaje");
                Console.WriteLine("2 - Repartir Cartas");
                Console.WriteLine("10 - Salir");
                int respuesta = int.Parse(Console.ReadLine());
                OpcionCuloSucio(ref avanzar, respuesta);

            } while (avanzar == false);
        }

        public void OpcionCuloSucio(ref bool avanzar, int respuesta)
        {
            switch (respuesta)
            {
                case 1:
                    int sobrante = 0;
                    Console.WriteLine("Escriba a continuación el nombre para intentar no ser el Sr o Sra Culo Sucio");
                    string nombre = Console.ReadLine();
                    jugador1 = new Jugador(nombre, sobrante);
                    break;

                case 2:
                    
                    break;

                case 10:
                    avanzar = true;
                    break;

                default:
                    break;


            }

        }



        public void MenuTruco(ref bool avanzar)
        {
            bool elegirPersonaje = false;
            
            do
            {
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("XXX--------------JUEGAZO DE TRUCO SXXI----------------XXX\n");
                Console.WriteLine("Elija su acción a través del índice numérico");

                if (elegirPersonaje == false)
                {
                    Console.WriteLine("1 - Elegir Personaje");
                   
                }


                if (elegirPersonaje == true)
                {
                    Console.WriteLine("1 - Repartir Cartas");
                    avanzar = true;
                }

                
                Console.WriteLine("10 - Salir");

                if (elegirPersonaje == false)
                {
                    string respuesta = Console.ReadLine();
                    MenuOpciones1(respuesta, ref avanzar);
                    elegirPersonaje = true;
                }

                if (elegirPersonaje == true)
                {
                    string respuesta = Console.ReadLine();
                    MenuOpciones2(respuesta, ref avanzar);
                }

                
            } while (avanzar==false);
           // Mano1();
        }   
        
        public void MenuOpciones1(string respuesta, ref bool avanzar)
        {
            switch (respuesta)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Escriba el nombre con el que se enfrentará a las fuerzas argentas del ingenio y la bravuconada");
                    string nombreUsuario = Console.ReadLine();
                    jugador1 = new Jugador(mazo.MazoCartas, nombreUsuario);
                    jugador2 = new Jugador(mazo.MazoCartas);
                    jugadores.Add(jugador1);
                    jugadores.Add(jugador2);
                    break;

                case "10":
                    Environment.Exit(1);
                    break;
                default:
                    break;
            }
        }

        public void MenuOpciones2(string respuesta, ref bool avanzar)
        {
            switch (respuesta)
            {
                case "1":
                    Console.Clear();
                    jugador1.ImprimeManoDeJugador();
                    Console.ReadKey();
                    Console.Clear();

                    break;

                case "10":
                    Environment.Exit(1);
                    break;
                default:
                    break;
            }
        }





    }

}
