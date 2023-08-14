using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNumPrimos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string resultado = "";

            double numero = 2;
            int contador = 0;

            while (contador<100)
            {
                if (esNumeroPrimo(numero)==true)

                {
                    resultado = resultado +  numero + ", " ; //Acá va agregando strings, la coma es la forma de separar los elementos.
                    contador++;
                }
                numero++;
            }

            MessageBox.Show(resultado);

        }

        private bool esNumeroPrimo (double Num )
        {

            bool esPrimo = true;

            for (int i = 2; i < Num; i++)
            {
                if (Num % i == 0)
                {
                    esPrimo = false;
                }

            }
         
            return esPrimo;

        }
    }
}
