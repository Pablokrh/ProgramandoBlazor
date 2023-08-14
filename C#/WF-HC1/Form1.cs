using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_HC1
{
    public partial class Form1 : Form
    {

        string usuario;
        string contraseña;
        Validaciones validaciones;


        public Form1()
        {
            InitializeComponent();
             validaciones = new Validaciones();

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            usuario = Tb_Usuario.Text;
            contraseña = tb_contraseña.Text;
            bool valido= validaciones.validar(usuario, contraseña);
            if (valido)
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("El Usuario y/o contraseña no es válido");
            }
            
        }

        
    }
}
