using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF__ValidacionesYSQL
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(String rol)
        {
            InitializeComponent();
            if (rol == "empleado") panEliminar.Visible = false;

        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
            //Funca cuando se le da a la X
        {
            Form1 VolverALogin = new Form1();
            VolverALogin.Show();
            this.Hide();
        }
    }
}
