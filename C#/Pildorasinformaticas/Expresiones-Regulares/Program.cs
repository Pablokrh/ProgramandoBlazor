using System;
using System.Text.RegularExpressions;

namespace Expresiones_Regulares
{
    class Program
    {
        static void Main(string[] args)
        {

            string frase = "Mi Web es https://www.youtube.com/watch?v=R1HymOiV9To&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=71";
            //sin la regular expressions haría falta un foreach que recorra caracter a caracter y que ahí dentro se establezca un condicional
            //[P] para buscar una p mayuscula.
            string patron = "https://?";

            Regex miRegez = new Regex(patron); //Todas las coincidencias las mete en una colección
            MatchCollection elMatch = miRegez.Matches(frase); //MatchCollection es esa coleccion.
            //ahora hay que recorrer la colección para ver si hay o no hay p
            if (elMatch.Count > 0) Console.WriteLine("Se ha encontrado sitio web");
            else Console.WriteLine("No se han encontrado sitios web");

        }
    }
}
