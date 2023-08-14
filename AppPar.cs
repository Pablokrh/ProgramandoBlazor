using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPromediar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            string textNum1 = txtPrimero.Text;
            double Num1 = Int32.Parse(textNum1);

            double Num2 = Int32.Parse(txtSegundo.Text);

            double Num3 = Int32.Parse(txtTercero.Text);

            double promedio = (Num1 + Num2 + Num3) / 3;

            MessageBox.Show("El promedio de los 3 números es: "+ promedio);
        }
    }
}
