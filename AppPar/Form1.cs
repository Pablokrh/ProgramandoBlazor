using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAveriguar_Click(object sender, EventArgs e)
        {

            double txtNum = Int32.Parse(txtnumero.Text);
            double modulo = txtNum % 2;

            if (modulo==0)
            {
                MessageBox.Show("El número ingresado es par");
            }

            else
            {
                MessageBox.Show("El número ingresado es impar");
            }

        }
    }
}
