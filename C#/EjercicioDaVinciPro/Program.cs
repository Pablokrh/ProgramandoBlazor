using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDaVinciPro
{
    /*3) En un juego de pelea por turnos, tomando un array con la vida de 10 enemigos
(valores de 1 a 100), mostrar primero tanto el índice como la vida de todos los que
tienen más chance de morir (< 30% de vida) y luego mostrar tanto el índice como la
vida de todos los enemigos de los cuales tenemos que huir (>70% de vida).
Hacer todo en un método que reciba el array con valores de vida de los enemigos y
retorne un array de tipo string indicando ambos casos con los siguientes textos:
“Este es propenso a morir” – “De este debemos huir”.*/
 public class Enemigo
    {
        private int indice;
        private int vida;
        public  int Indice { get => indice; set => indice = value; }
        public int Vida { get => vida; set => vida = value; }

        public Enemigo()
        {
            Random ale = new Random();
            vida = ale.Next(1, 101);
            indice = indice + 1; ;
        }


        static void Main(string[] args)
        {
            Enemigo N1 = new Enemigo();
            Enemigo N2 = new Enemigo();
            Enemigo N3 = new Enemigo();
            Enemigo N4 = new Enemigo();
            Enemigo N5 = new Enemigo();
            Enemigo N6 = new Enemigo();
            Enemigo N7 = new Enemigo();
            Enemigo N8 = new Enemigo();
            Enemigo N9 = new Enemigo();
            Enemigo N10 = new Enemigo();

            Console.WriteLine(N1.Indice + " / " + N1.Vida);

            Console.WriteLine(N9.Indice + " / "+ N9.Vida);
            Console.WriteLine(N1.Indice + " / " + N1.Vida);

            Console.ReadKey();
        }
    }
}


/*
 * 
 * public class Juego
    {
        List<int> huir = new List<int>();
        List<int> morir = new List<int>();

        public void Imprimir (int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }

    
        public void MorirHuir (int[]arraiete)
        {
       

            Console.WriteLine("__________________________");
            for (int i = 0; i < arraiete.Length; i++)
            {
                if (arraiete[i] < 30) huir.Add(arraiete[i]);
                else morir.Add(arraiete[i]);
            }
            foreach (var item in huir)
            {
               
                Console.WriteLine($"El enemigo con {item} puntos de vida es propenso a morir ");
            }

            Console.WriteLine();
            foreach (var item in morir)
            {
                Console.WriteLine($"Del enemigo con {item} puntos de vida, debemos huir  ");

            }


        }


        static void Main(string[] args)
        {

                        Random ale = new Random();
            int[] enemigos = new int[10];
            for (int i = 0; i < enemigos.Length; i++)
            {
                enemigos[i] = ale.Next(1, 101);
                Console.Write(enemigos[i]);
               
            }
            Console.WriteLine();

            Juego J = new Juego();
            J.Imprimir(enemigos);
            J.MorirHuir(enemigos);
            
            
            Console.ReadKey();
        }
    }
 * /*2) En un juego de estrategia se recibe un array con las distancias (que varían entre 10
y 50) de los 10 enemigos más cercanos. Sabemos que tienen un rango de ataque
que varía entre 15 y 40 metros.
Debemos evaluar qué acción realizar según cuantos enemigos nos tienen en rango
de ataque:
• Si tenemos al menos 6 enemigos en posición de atacarnos debemos huir.
• Si la cantidad de enemigos es entre 3 y 5 debemos proteger nuestra
posición.
• Si la cantidad de enemigos es de 1 o 2 debemos emboscarlos.
Genere un método que reciba el array en cuestión y sin retornar nada indique las
siguientes cosas:
a. Cuantos enemigos nos tienen en zona de ataque.
b. Qué acción debe realizar nuestro personaje.
c. Cuál es el enemigo más cercano y en qué índice se encuentra.
* public class JuegoEstrategia
    {
        int[] Enemigos;
        int PuedeAtacar = 0;

        public JuegoEstrategia()
        {
            Enemigos = new int[10];
        }

        public void DistanciaEnemigos ()
        {
            Random Ale = new Random();
          
            for (int i = 0; i<Enemigos.Length; i++)
            {
                Enemigos[i] = Ale.Next(10, 51);
            }
            
        }

       public void ImprimeDistancias2()
        {
            int contador = 0;
           
            Console.WriteLine("Los enemigos se encuentran a las siguientes distancias:");
            foreach (var item in Enemigos)
            {
                Console.WriteLine("Distancia: "+item+ "// En índice:"+ contador);
                contador++;

            }

        }

        public void ImprimeDistancias()
        {
            Console.WriteLine("Los enemigos se encuentran a las siguientes distancias:");
            for (int i = 0; i < Enemigos.Length; i++)
            {
                Console.WriteLine("En el índice "+ i + " se encuentra un enemigo ubicado a "+ Enemigos[i]+ " metros de distancia");

            }
            Console.WriteLine("______________________");
            Console.WriteLine();
        }



            public void MasCercano()
        {
            int masCercano = int.MaxValue;
            int indiceCercano = 0;
            for (int i = 0; i < Enemigos.Length; i++)
            {
                if (Enemigos[i] < masCercano)
                {
                    masCercano = Enemigos[i];
                    indiceCercano = i;
                    
                }
            }
            Console.WriteLine("El enemigo mas cercano está a " +masCercano+ " metros. Se encuentra en el índice "+ indiceCercano);
            Console.WriteLine("________________________");

        }


        public void ZonaAtaque()
        {
            
            for (int i = 0; i < Enemigos.Length; i++)
            {
                if (Enemigos[i] <= 40 && Enemigos[i] >=15)
                {
                    PuedeAtacar++;

                }
            }

            Console.WriteLine("Se encuentran en zona de ataque " + PuedeAtacar + " enemigos");
            Console.WriteLine("___________________________");

        }

        public void Reaccion()
        {
            if (PuedeAtacar > 5)
            {
                Console.WriteLine("Debemos huir, ya que hay " + PuedeAtacar + " enemigos, en posición de ataque");
            }

            else
            {
                if (PuedeAtacar>2 && PuedeAtacar < 6)
                {
                    Console.WriteLine("Debemos proteger nuestra posición, ya que hay " + PuedeAtacar + " enemigos, en posición de ataque");
                }
                else
                {
                    Console.WriteLine("Debemos emboscar al enemigo, ya que hay " + PuedeAtacar + " enemigo/s, en posición de ataque");

                }

            }

        }



        static void Main(string[] args)
        {
            JuegoEstrategia Juego1 = new JuegoEstrategia();
            Juego1.DistanciaEnemigos();
            Juego1.ImprimeDistancias();
            Juego1.ImprimeDistancias2();
            Juego1.ZonaAtaque();
            Juego1.Reaccion();
            Juego1.MasCercano();

            
            Console.ReadKey();
        }
    }*/