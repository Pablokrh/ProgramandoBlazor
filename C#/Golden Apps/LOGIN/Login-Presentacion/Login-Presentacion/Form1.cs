using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominio;
using Login_Presentacion;

namespace Login_Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Configuraciones();
        }

        private void Configuraciones()
        {
            this.Opacity = 0.992;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DominioUser userModel = new DominioUser();
            bool usuarioValido= userModel.Login(txtUserName.Text, txtPassword.Text);
            if (usuarioValido == true)
            {
                this.Hide();
                FormBienvenida formBienvenida = new FormBienvenida();
                formBienvenida.ShowDialog();
                FormMainMenu formMainMenu = new FormMainMenu();
                formMainMenu.Show();
            }
            else
            {
                MessageBox.Show("Incorrect userName or password entered." + Environment.NewLine + "Please try again.");
                txtPassword.Clear();
                txtUserName.Clear();
            }
        }

        private void FormMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        //   bool mouseDown = false;
        int m, mx, my;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            // mouseDown = false;
            m = 0;
        }

        private void linkLabelForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecoverPassword formRecoverPassword = new FormRecoverPassword();
            formRecoverPassword.ShowDialog();
            this.Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
          /* if (mouseDown == true)
            {
                this.Location = Cursor.Position;
            }  */

          if (m == 1)
          {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
          }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //  mouseDown = true;
            m = 1;
            mx = e.X;
            my = e.Y;
        }
    }
}
