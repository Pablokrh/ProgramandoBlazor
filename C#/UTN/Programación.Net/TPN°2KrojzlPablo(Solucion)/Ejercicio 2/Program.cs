﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            while (numero < 101)
            {
                if (numero % 2 != 0) Console.Write(numero+ " ");

                numero++;
            }

            Console.ReadKey();


        }
    }
}
