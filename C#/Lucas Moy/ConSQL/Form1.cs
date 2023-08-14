using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Conectar_Click(object sender, EventArgs e)
        {

            ConectaSQL conectandose = new ConectaSQL(); //Acá se crea un objeto
            ConectaSQL.Conectar () ;

        }
    }
}
