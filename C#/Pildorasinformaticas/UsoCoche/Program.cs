using System;

namespace UsoCoche
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();          //el segundo coche es el nombre del constructor. Al que se llama.
            Coche coche2 = new Coche();
            Coche coche3 = new Coche(4500.25, 1200.35);

            Console.WriteLine(coche2.getInfoCoche()); //así si, se llama al método getter, getRuedas.
            Console.WriteLine(coche1.getInfoCoche()); 
            Console.WriteLine(coche3.getInfoCoche());
            coche3.setExtrasCoche(true, "Cuero");
            Console.WriteLine(coche3.getExtrasCoche());
        }
    }
    partial class Coche
    {
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 800;
        }

        public Coche(Double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
        }

        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria = "De tela";
    }
    partial class Coche
    {

        public string getInfoCoche()
        {
            return "Información del coche \n" + "Ruedas: " + ruedas + ". Largo: " + largo + ". Ancho:" + ancho;
        }

        public void setExtrasCoche(bool paramClimatizador, string paramTapiceria)
        {
            climatizador = paramClimatizador;
            tapiceria = paramTapiceria;
        }
        public string getExtrasCoche()
        {
            return "Extras del coche: \n" + "Tapicería " + tapiceria + ". Climatizador " + climatizador;
        }
    }
    
}
