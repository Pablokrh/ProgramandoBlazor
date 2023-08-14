using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quark_Practica_previa
{
    class Program
    {
        static void Main(string[] args)
        {
            Vista E = new Vista();
            E.Eleccion();

            Console.WriteLine("¿Desea saber el precio de dicha prenda? (si - no)");
            string rta = Console.ReadLine();
            if (rta == "si") E.Cotiza();

            Console.ReadKey();
            Console.WriteLine();
        }
    }

    class Vista
    {
       private Camisa C;
       private  Pantalon P;
       private int pantalon = 500;
       private int camisa = 800;
       string prenda;


        public void Eleccion()
        {
            Console.WriteLine("¿Desea usted una camisa o un pantalón? (camisa - pantalón)");
             prenda = Console.ReadLine();

            if (prenda == "camisa") EligeCamisa();
            if (prenda == "pantalon" || prenda == "pantalón") EligePantalon();

        }

        public void EligeCamisa()
        {
            C= new Camisa();
            
            Console.WriteLine("¿De manga larga o corta? (larga - corta)");
            C.Manga = Console.ReadLine();


            Console.WriteLine("¿De cuello normal o Mao? (normal - Mao)");
            C.Cuello = Console.ReadLine();


            Console.WriteLine("¿De calidad premium o normal? (premium - normal)");
            C.Calidad = Console.ReadLine();

        }

        public void EligePantalon()
        {
            
            P =new Pantalon();

            Console.WriteLine("¿Lo desea chupín o normal? (chupín - normal)");
            P.Calce = Console.ReadLine();

            Console.WriteLine("¿De calidad premium o normal? (premium - normal)");
            P.Calidad = Console.ReadLine();

        }

        public void Cotiza()
        {
            if (prenda == "camisa")
            {
                if (C.Manga == "corta") camisa = camisa * 90 / 100;
                if (C.Cuello == "Mao") camisa = camisa * 103 / 100;
                if (C.Calidad == "premium") camisa = camisa * 130 / 100;
                Console.WriteLine($"La {prenda}, con un precio base de 800, tiene manga {C.Manga}, cuello {C.Cuello} y de calidad {C.Calidad}.\nEl precio final es: ${camisa}");
            }

            if (prenda == "pantalón" || prenda=="pantalon")
            {
                if (P.Calce == "chupín") pantalon = pantalon * 88 / 100;
                if (P.Calidad == "premium") pantalon = pantalon * 130 / 100;

                Console.WriteLine($"El {prenda}, con un precio base de 500, tiene calce {P.Calce} y una calidad {P.Calidad}. \nEl precio final unitario es de {pantalon}");
            }
           

        }

    }



    abstract class Prenda
    {
        private string calidad;

        internal string Calidad { get => calidad; set => calidad = value; }
    }

     class Camisa:Prenda
    {
       private string manga;
       private string cuello;

        public string Manga { get => manga; set => manga = value; }
        public string Cuello { get => cuello; set => cuello = value; }
    }

     class Pantalon : Prenda
    {

        private string calce;

        public string Calce { get => calce; set => calce = value; }
    }
}
