using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCartas
{
    class Mazo
    {       
        List<Carta> mazoCartas;

        internal List<Carta> MazoCartas { get => mazoCartas; }

        public Mazo()
        {
            mazoCartas = new List<Carta>();
            CreaCarta("basto");
            CreaCarta("oro");
            CreaCarta("espada");
            CreaCarta("copa");
        }

        private void CreaCarta(string palo)
        {
            for (int i = 1; i < 8; i++)
            {
               mazoCartas.Add(new Carta(i, palo, i));
            }

            for (int i = 10; i < 13; i++)
            {
                mazoCartas.Add(new Carta(i, palo, 0));
            }

        }

        public void ReparteCartaCuloSucio()
        {
            

        }

        public void ImprimeCartas()
        {
            for (int i = 0; i < mazoCartas.Count; i++)
            {
                Console.WriteLine("La carta N° " + (i+1) + " del mazo. Tiene el número " + mazoCartas[i].Numero + " y es de " + mazoCartas[i].Palo +"s");
            }
        }

        public void CartasRestantes()
        {
            Console.WriteLine("\n---------------------------------\nCartas restantes");

            for (int i = 0; i < mazoCartas.Count; i++)
            {
                Console.WriteLine("Carta:" +  mazoCartas[i].Numero + " es de " + mazoCartas[i].Palo + "s");
            }
        }
    }
}
