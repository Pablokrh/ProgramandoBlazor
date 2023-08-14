using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioMayoryMenor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string txtNum1 = txtPrimero.Text;
            int num1 = Int32.Parse(txtNum1);

            string txtNum2 = txtSegundo.Text;
            int num2 = Int32.Parse(txtNum2);

            string txtNum3 = txtTercero.Text;
            int num3 = Int32.Parse(txtNum3);


            int mayor = num1;
            if (num2 > mayor)
            {
                mayor = num2;
            }
            if (num3 > mayor)
            {
                mayor = num3;
            }


            MessageBox.Show("El mayor es: "+ mayor);


            int menor = num1;
            if (num2 < mayor)
            {
                mayor = num2;
            }
            if (num3 < mayor)
            {
                mayor = num3;
            }
            MessageBox.Show("El menor es: " + menor);

        }


    }
}

