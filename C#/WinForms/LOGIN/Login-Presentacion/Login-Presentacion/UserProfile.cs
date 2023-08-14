using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Dominio;

namespace Login_Presentacion
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Reset();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            Reset();

        }

        private void LoadUserData()
        {

            //View
            lblName.Text = ActiveUser.FirstName;
            lblEmail.Text = ActiveUser.Email;
            lblPosition.Text = ActiveUser.Position;
            lblLastName.Text = ActiveUser.LastName;
            lblUser.Text = ActiveUser.LoginName;

            //Edit Panel 
            txtName.Text = ActiveUser.FirstName;
            txtEmail.Text = ActiveUser.Email;
            txtLastName.Text = ActiveUser.LastName;
            txtUserName.Text = ActiveUser.LoginName;
            txtPassword.Text = ActiveUser.Password;
            txtConfirm.Text = ActiveUser.Password;
            txtCurrent.Text = "";
        }
        private void InitializaPassEditControls()
        {
            linklblEditpassword.Text = "Edit";
            txtPassword.Enabled = false;
            txtPassword.UseSystemPasswordChar = true;
            txtConfirm.Enabled = false;
            txtConfirm.UseSystemPasswordChar = true;
            txtCurrent.Enabled = false;
            panel1.Visible = false;
        }

        private void Reset()
        {
            LoadUserData();
            InitializaPassEditControls();
        }

        private void linklblEditpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linklblEditpassword.Text == "Edit")
            {

                linklblEditpassword.Text = "Cancel";
                txtPassword.Text = "";
                txtConfirm.Text = "";
                txtPassword.Enabled = true;
                txtConfirm.Enabled = true;
                txtCurrent.Enabled = true;
            }
            else if (linklblEditpassword.Text == "Cancel")
            {
                Reset();
               /*
                * InitializaPassEditControls();
                txtPassword.Text = ActiveUser.Password;
                txtConfirm.Text = ActiveUser.Password;
               */
            } 

        }

        private void linklblEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            LoadUserData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPassword.TextLength >= 5)
            {
                if (txtPassword.Text == txtConfirm.Text)
                {
                    if (txtCurrent.Text == ActiveUser.Password)
                    {
                        var dominioUser = new DominioUser(idUser: ActiveUser.IdUser,
                            //Ahí hace eso ya que no es editable (ni se sabe)
                            loginName: txtUserName.Text,
                            password: txtPassword.Text,
                            firstName: txtName.Text,
                            lastName: txtLastName.Text,
                            position: null,
                            email: txtEmail.Text);

                        var result = dominioUser.EditUserProfile();
                        MessageBox.Show(result);
                        Reset();
                        panel1.Visible = false;
                    }
                    else MessageBox.Show("Incorrect current password, try again");
                }
                else MessageBox.Show("The password do not match, try again");
            }
            else MessageBox.Show("The password must have at least 5 characters");


        }
    }
}
