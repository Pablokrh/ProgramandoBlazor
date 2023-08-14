using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPeleas
{
    class Atacar
    {
        Personaje usuario;
        Personaje enemigo;

        public Atacar (Personaje usuario, Personaje enemigo)
        {
            this.usuario = usuario;
            this.enemigo = enemigo;
        }

        public void AtacaUsuario ()
        {
            int intentoDeGolpe = Randomizador.randomiza(0, 101);
            Console.WriteLine("tirada de dados: Intento de golpe   "+ (intentoDeGolpe- enemigo.Arma[0].velocidad) + " Esquiva de enemigo: "+ enemigo.Esquiva);
            if (intentoDeGolpe - enemigo.Arma[0].velocidad > enemigo.Esquiva)
            {
                Console.WriteLine("Daño del golpe: "+usuario.Arma[0].daño);
                enemigo.Vida = enemigo.Vida - usuario.Arma[0].daño;
            }
            else Console.WriteLine("El enemigo ha esquivado el golpe");
            CompruebaVida(enemigo);

        }

        public void AtacaEnemigo()
        {
            int intentoDeGolpe = Randomizador.randomiza(0, 101);
            Console.WriteLine("tirada de dados: Intento de golpe   " + (intentoDeGolpe- usuario.Arma[0].velocidad) + " Esquiva de enemigo: " + usuario.Esquiva);

            if (intentoDeGolpe-enemigo.Arma[0].velocidad > usuario.Esquiva)
            {
                Console.WriteLine("Daño del golpe: " + enemigo.Arma[0].daño);
                usuario.Vida = usuario.Vida - enemigo.Arma[0].daño;
            }
            else Console.WriteLine("Has esquivado el golpe");

            CompruebaVida(usuario);
        }

        private void CompruebaVida(Personaje pp)
        {
            if (pp.Vida>=0)
            {
                Console.WriteLine(pp.Nombre + " tiene "+ pp.Vida +" puntos de vida.");
            }
        }


    }
}
