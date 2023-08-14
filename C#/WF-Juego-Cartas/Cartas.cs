using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCartas
{
    class Carta
    {
        private int numero;
        string palo;
        private int valorEnv;
        
        
        public Carta(int numero, string palo, int valorEnv)
        {
            this.numero = numero;
            this.palo = palo;
            this.valorEnv = valorEnv;
        }

        public int Numero { get => numero; }
        public string Palo { get => palo; }
        public int ValorEnv { get => valorEnv; }
    }
}
