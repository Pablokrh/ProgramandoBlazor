using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorEudoDolar obj = new ConversorEudoDolar();

            // obj.Euro = 1.45; //al haberlo hecho público lo pudo cambiar. Luego lo elimina y convierte en private.
            obj.CambiaValorEuro(1.45); //¿Cuánto se gana con esto?*
            Console.WriteLine(obj.Convierte(50));
        }
    }
             class ConversorEudoDolar
    {
       double euro = 1.253; //este valor es volátil, cambia día a día, por eso le pone public.
        public double Convierte (double cantidad)
        {
            return cantidad * euro;

        }
        public void CambiaValorEuro (double nuevoValor)
        {if (nuevoValor < 0) euro = 1.253; //*esta línea y la que viene establece algún límite a lo que se podría modificar el valor del euro.
        else euro = nuevoValor; //Esto permite cambiar el valor del euro, pero no desde afuera de la clase.
        //if y else con sintaxis rara. 
        }

    }
 }
/*
 * namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; //creación (o declaración) de objeto de tipo circulo. O una variable objeto de tipo circulo (=/= variables de tipo primitivo)
            miCirculo = new Circulo(); //iniciación de variable objeto de tipo circulo. También se llama instanciar una clase. Siempre que se vea new es instanciación, o ejemplarización, o creación de ejemplar de clase.

            Console.WriteLine(miCirculo.calculoArea(5));  //para que aparezca pi o calculoArea, ya que están encapsuladas, le agrega al ppio a ambas, propiedad y método, la palabra public.
            //eso devuelve 78,54. Que es el area de un circulo con 5 de radio.
            Circulo miCirculo2 = new Circulo(); //aquí se declara e inicializa el objeto en la misma linea.
            Console.WriteLine(miCirculo2.calculoArea(9));
        }
    }

     class Circulo
    {
        const double pi = 3.1416; //propiedad de la clase Circulo. Variable(o constante)=Propiedad=Campo de clase.
         public double calculoArea (int radio) //Método de clase. Especifica el comportamiento del objeto.
        {
            return pi * radio * radio;
        }
    }
 }
*/