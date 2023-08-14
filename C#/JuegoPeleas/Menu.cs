using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPeleas
{
    class Menu
    {
        string nombre="";
        string raza;
        bool seguir = false;
        bool avanzar = false;
        Personaje usuario;
        Personaje enemigo;
        Atacar atacaUsuario;


        public Menu()
        {
            Presentacion();
        }


        private void Presentacion()
        {
            Console.WriteLine("                        Juego de peleas SuperSanguinario 3000           ");
            Console.WriteLine("\nBienvenido Usuario de maquinolas y manuelas (seguramente)\n");
            Console.WriteLine("\nEmpujá cualquier tecla hacia abajo para comenzar tu camino de aventuras, ilusiones y desilusiones, a través de legendarios enemigos y armas únicas, esquivando y golpeando al destino y a la muerte en cada segundo");
            Console.ReadKey();
            MenuPrincipal();



        }
        /*
        if ((int.TryParse(stringAuxiliar, out int intAno) == true) && stringAuxiliar.Trim() != "")
            {
                avanzar = true;
                numAux = int.Parse(stringAuxiliar);
                return numAux;
            }
        */

    public void MenuPrincipal()
        {
            seguir = false;
            do
            {
                Console.Clear();
                if (nombre == "")
                {
                    Console.WriteLine("Elija el nombre del personaje");
                    nombre = Console.ReadLine();
                }

            } while (nombre == "");


            seguir = false;
            avanzar = false;
            int razaAux=0;
            do
            {
                Console.Clear();
                Console.WriteLine("Elija su raza");
                Console.WriteLine("1 - Humano");
                Console.WriteLine("2 - Orco");
                Console.WriteLine("3 - Gato");


                try
                {
                     razaAux = int.Parse(Console.ReadLine());
                    if (razaAux < 1 == true && razaAux > 3 == true) avanzar = false;
                    else avanzar = true;
                }
                catch(Exception e)
                {
                    Console.WriteLine("El número ingresado no es un entero numérico");
                }

                EligeRaza(ref seguir, razaAux);

            } while (seguir == false);

            usuario = new Personaje(nombre, raza);
            MenuJuego();
        }

        public void EligeRaza (ref bool seguir, int razaAux)
        {
            switch (razaAux)
            {

                case 1:
                    seguir = true;
                     raza = "humano";
                    break;

                case 2:
                     raza = "orco";
                    seguir = true;
                    break;

                case 3:
                     raza = "gato";
                    seguir = true;
                    break;
            }

        }

        public void MenuJuego()
        {
            bool avanzar = false;
            do
            {
                Console.Clear();
                Console.WriteLine("XXXXXXXX  Juego de peleas SuperSanguinario 3000  XXXXXXXXXXX");
                Console.WriteLine("Elija la opción deseada a través de su índice numérico");
                Console.WriteLine("1 - Generar enemigo");
                Console.WriteLine("2 - Atacar enemigo");
                Console.WriteLine("3 - Cambiar de arma");
                Console.WriteLine("8 - Imprimir datos de personaje");
                Console.WriteLine("9 - Imprimir datos de enemigo");
                int respAux = int.Parse(Console.ReadLine());

                OpcionJuego(respAux, ref avanzar);
            } while (avanzar == false);           

        }

        private void OpcionJuego(int respAux, ref bool avanzar)
        {
            switch (respAux)
            {
                case 1:
                    enemigo = new Personaje();
                    atacaUsuario = new Atacar(usuario, enemigo);
                    break;

                case 2:                                     
                        Console.Clear();
                        atacaUsuario.AtacaUsuario();
                        Console.ReadKey();
                    if (enemigo.Vida > 0)
                    {
                        Console.WriteLine("A continuación, el golpe del enemigo...");
                        Console.ReadKey();
                        Console.Clear();
                        atacaUsuario.AtacaEnemigo();
                        Console.ReadKey();
                    }

                    if (enemigo.Vida <= 0 || usuario.Vida <= 0)
                    {
                        Console.Clear();
                        if (enemigo.Vida <= 0) Console.WriteLine("El enemigo ha muerto");
                        else
                        {
                            Console.WriteLine("¡¡Has muerto!!");
                            Console.ReadKey();
                            avanzar = true;

                        }

                        Console.ReadKey();
                    }
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Elija el arma que desea utilizar");
                    Console.WriteLine("1 - Cuchillo");
                    Console.WriteLine("2 - Lanza");
                    Console.WriteLine("3 - Desarmado");
                    int armaElegida = int.Parse(Console.ReadLine());
                    if (armaElegida==1) usuario.CambiaArma("Cuchillo", usuario);
                    if (armaElegida==2) usuario.CambiaArma("Lanza", usuario);
                    if (armaElegida==3) usuario.CambiaArma("Desarmado", usuario);
                    if (armaElegida < 1 || armaElegida > 3) Console.WriteLine("No has introducido un valor válido");
                    break;

                case 8:
                    PrinteaPersonaje(usuario);
                    Console.ReadKey();
                    break;

                case 9:
                    PrinteaPersonaje(enemigo);
                    Console.ReadKey();
                    break;


            }


        }


        private void PrinteaPersonaje(Personaje ppp)
        {
            Console.Clear();
            Console.WriteLine("Nombre del muchacho: "+ ppp.Nombre+ "   Raza: " + ppp.Raza);
            Console.WriteLine("Puntos de vida actuales: " +ppp.Vida+ "   Actualmente golpea "+ ppp.Arma[0].Nombre);
        }
    }

   

}
