using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPeleas
{
    class Personaje
    {
        string nombre;
        string raza;
        int vida;
        int esquiva;
        List <Arma> arma;

        public string Nombre { get => nombre; }
        public string Raza { get => raza; }
        internal List<Arma> Arma { get => arma; }
        public int Esquiva { get => esquiva; }
        public int Vida { get => vida; set => vida = value; }


        public Personaje(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
            arma = new List<Arma>();
            arma.Add(new Desarmado());
            Vida=RandomizaVida(raza);
            esquiva = RandomizaEsquiva(raza);   

        }

        public Personaje()
        {
            nombre = RandomizaNombre();
            raza = RandomizaRazaEnemigo();
            Vida = RandomizaVida(raza); 
            arma = new List<Arma>();
            arma.Add(ArmaEnemiga());
            esquiva = RandomizaEsquiva(raza);

        }

        public Arma ArmaEnemiga()
        {
            int tocaArma = Randomizador.randomiza(0, 3);
            if (tocaArma == 0) return new Cuchillo();
            else if (tocaArma == 1) return new Lanza();
            else return new Desarmado();

        }

        public void CambiaArma(string nombreArma, Personaje usuario)
        {
            if (usuario.Arma[0].nombre == nombreArma)
            {
                Console.WriteLine("Ya estabas utilizando dicha arma");
                Console.ReadKey();
            
            }
            else
            {
                usuario.arma.RemoveAt(0);
                if (nombreArma == "Cuchillo")
                {
                    usuario.arma.Add(new Cuchillo());
                }
                if (nombreArma == "Lanza")
                {
                    usuario.arma.Add(new Lanza());
                }
                if (nombreArma == "Desarmado")
                {
                    usuario.arma.Add(new Desarmado());
                }
                Console.WriteLine("Estás utilizando " + usuario.arma[0].nombre + ", la cual hace " + usuario.arma[0].daño + "puntos de daño y posee un penalizador por velocidad de " + usuario.arma[0].velocidad);

            }

        }

        public int RandomizaVida(string raza)
        {           
        if (raza == "gato")
        {
                Vida=Randomizador.randomiza(12, 30);
        }
        if (raza == "orco")
        {
                Vida = Randomizador.randomiza(130, 300);
        }
        if (raza == "humano")
        {
                Vida = Randomizador.randomiza(80, 150);
        }

            return Vida;
    }


        private int RandomizaEsquiva(string raza)
        {
            if (raza == "gato")
            {
                esquiva = Randomizador.randomiza(75, 95);
            }
            if (raza == "orco")
            {
                esquiva = Randomizador.randomiza(5, 25);
            }
            if (raza == "humano")
            {
                esquiva = Randomizador.randomiza(15, 50);
            }

            return esquiva;

        }

        private string RandomizaRazaEnemigo()
        {
           int aux= Randomizador.randomiza(0, 3);
            if (aux == 0) raza = "orco";
            if (aux == 1) raza = "humano";
            if (aux == 2) raza = "gato";
            return raza;

        }

        private string RandomizaNombre()
        {
            int aux = Randomizador.randomiza(1, 11);
            switch (aux)
            {
                case 1:
                    return "Carlitos";                    

                case 2:
                    return "Michifuz";

                case 3:
                    return "Ogronte";

                case 4:
                    return "Nalviandón";

                case 5:
                    return "Mbappé";

                case 6:
                    return "Garfield";

                case 7:
                    return "Szu Ku Lin";

                case 8:
                    return "Roberta Mario Sabrina";

                case 9:
                    return "Cáspides";

                case 10:
                    return "Pepe";

                default:
                    return "";

            }






        }

    }




}
