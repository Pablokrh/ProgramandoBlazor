using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPeleas
{
    public static class Randomizador
    {
        private static Random random = new Random();

        public static int randomiza(int num1, int num2)
        {
            int rand2 = random.Next(num1, num2);
            return rand2;

        }
    }
}
