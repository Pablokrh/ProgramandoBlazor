using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Desplazamientos
{
    class Program
    {
        static void Main(string[] args)
        {

            JuegolePosta j = new JuegolePosta();
            j.LlenaMatrix();
        }
    }

    public class JuegolePosta
    {
        int[,] matrizole = new int[4, 5];

        public void LlenaMatrix()
        {
            matrizole[1, 4] = 4;
            matrizole[1, 1] = 6;
            matrizole[2, 2] = 1;
            matrizole[0, 3] = 7;
            matrizole[3, 2] = 5;
            matrizole[3, 0] = 9;

            for (int i = 0; i < matrizole.GetLength(0); i++)
            {
                for (int x = 0; x < matrizole.GetLength(1); x++)
                {
                    if (matrizole[i, x] == 0) matrizole[i, x] = 3;
                    Console.Write(matrizole[i,x]);
                }
                Console.WriteLine();

            }

            Console.ReadKey();

        }

    }


}
