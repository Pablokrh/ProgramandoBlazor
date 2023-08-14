using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.Cache;

namespace Login_Presentacion
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            lblName.Text = ActiveUser.FirstName +", "+ ActiveUser.LastName;
            lblPosition.Text = ActiveUser.Position;
            lblEmail.Text = ActiveUser.Email;
            ManagePermissions();

            if (ActiveUser.IdUser.ToString() == null || ActiveUser.IdUser <= 0)
            {
                MessageBox.Show("Are you a hacker??" + Environment.NewLine + "Police is going to your home") ;
                this.Close();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to end your session", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
        }

        private void ManagePermissions()
        {
            if (ActiveUser.Position == Positions.receptionist)
            {
                lblChart.Visible = false;
                lblSettings.Enabled = false;
                //Ahí le quita acceso a alguien logueado como recepcionista a ver el chart.
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the aplicattion", "Warning", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void linkMyProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserProfile userProfile= new UserProfile();
            this.Close();
            userProfile.Show();
        }
    }
}
