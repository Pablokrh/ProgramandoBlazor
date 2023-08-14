using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

For @for = new For();
@for.ConstruyeRectangulo(6, 7, true, 18);
@for.PrinteaMatriz();

While @while=new While();
@while.MultiplicaDiezVeces(8);

Console.WriteLine("\nXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX \n\n");
Console.WriteLine("Escriba a continuación un número entero");
int aux = int.Parse(Console.ReadLine());
Console.WriteLine("\n\n");
DoWhile @dowhile = new DoWhile();
@dowhile.Do_While(aux);


class DoWhile
{public void Do_While(int num)
    {
       if (num < 0)
       {
            Console.WriteLine("El número {0} es negativo", num);
            Console.WriteLine("Iniciando conteo ascendente...");
            do
            {
                Console.WriteLine("El número ahora es: "+ num++ );
            } while (num <= 0);
            Console.WriteLine("El número ya no es negativo");

        }
        else if (num > 0)
        {
            Console.WriteLine("El número {0} es positivo", num);
            Console.WriteLine("Iniciando conteo descendiente...");

            do
            {
                Console.WriteLine("El número ahora es: " + num--);



            } while (num >= 0);
            Console.WriteLine("El número ya no es positivo");
        }
        else
        {
            Console.WriteLine("El número es 0");
            Console.WriteLine("No se qué podría contarte =(");
        }
    }
}

class While {

    public void MultiplicaDiezVeces(int num)
    {
        Console.WriteLine(  "\n\n-------------------------------------\n");
        int contador = 1;
        while (contador < 11)
        {
            Console.Write(num + " X " + contador + " =");
            Console.WriteLine(num * contador);
            contador++;
        }

    }
}

public class PuntoRelleno
{
    public PuntoRelleno(int Alto, int Ancho)
    {
        this.Alto = Alto;
        this.Ancho = Ancho;
    }
    public int Alto { get; }
    public int Ancho { get;  }
}

public class For
{
    private static Random random;

    string[,] matrizRectangulo;

    List<PuntoRelleno> ListaPuntosRellenos;
  
    int rellenaAlto;
    int rellenaAncho;

    
    /*
    public void DoWhile ()
    */
    public void ConstruyeRectangulo ( int ancho,  int alto, bool relleno, int cantRellenos)
    {
        matrizRectangulo = new string[ancho, alto];


        for (int i = 0; i < alto; i++)
        {
            for (int j = 0; j < ancho; j++)
            {
                matrizRectangulo[j, i] = " - ";
            }
        }

        if (relleno)
        {
            ListaPuntosRellenos = new List<PuntoRelleno>();
            int contador = 0;

            do
            {
                bool puntodisponible = true;
                rellenaAncho = Randomizador(ancho);
                rellenaAlto = Randomizador(alto);
                

                for (int t = 0; t < ListaPuntosRellenos.Count; t++)
                {
                    if (ListaPuntosRellenos[t].Ancho == rellenaAncho && ListaPuntosRellenos[t].Alto == rellenaAlto)
                    {
                        puntodisponible = false;
                    }
                }

                if (puntodisponible == true)
                {                   
                    ListaPuntosRellenos.Add(new PuntoRelleno(rellenaAlto, rellenaAncho));
                    contador++;
                }

            } while (contador < cantRellenos);



            for (int k = 0; k < ListaPuntosRellenos.Count; k++)
            {
                Console.WriteLine("Casillero Relleno, Índice N° " + k + " : Ancho " + ListaPuntosRellenos[k].Ancho +
                  " Alto " + ListaPuntosRellenos[k].Alto);
            }
            Console.WriteLine("\n-----------------------------------------------\n\n");
            for (int i = 0; i < cantRellenos; i++)
            {
                matrizRectangulo[ListaPuntosRellenos[i].Ancho, ListaPuntosRellenos[i].Alto] = " X ";
            }
            
        }

       


    }

    public void PrinteaMatriz()
    {
        for (int i = 0; i < matrizRectangulo.GetLength(1); i++)
        {
            for (int j = 0; j < matrizRectangulo.GetLength(0); j++)
            {
                Console.Write(matrizRectangulo[j,i]  );
            }
            Console.WriteLine( );
        }

    }

    
    public static int Randomizador(int num)
    {
        random = new Random();
        int rand = random.Next(0, num);
        return rand;
    }

}