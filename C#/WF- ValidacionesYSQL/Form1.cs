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
    public partial class Form1 : Form
    {
        BL.BLEmpleado blempleado;
        EN.ENEmpleado enEmpleado;
     

        public Form1()
        {
            InitializeComponent();
            blempleado = new BL.BLEmpleado();
            enEmpleado = new EN.ENEmpleado();
        }


        private void picLogin_Click(object sender, EventArgs e)
        {
           enEmpleado.EmpleadoUsuario = txtUsuario.Text;
           enEmpleado.EmpleadoClave = txtClave.Text;
           String usuarioValidado = blempleado.VerificarUsuario(enEmpleado);
           String claveValidada = blempleado.VerificarClave(enEmpleado);
           MessageBox.Show("El usuario digitado es: "+ enEmpleado.EmpleadoUsuario + " y el usuario validado es: "+ usuarioValidado);
            MessageBox.Show("La clave digitada es: "+ enEmpleado.EmpleadoClave + " y la clave validada es :"+ claveValidada);

            if (rbtAdmin.Checked == true) enEmpleado.EmpleadoRol = "Administrador";
            if (rbtEmpleado.Checked == true) enEmpleado.EmpleadoRol = "Empleado";

            if (usuarioValidado==enEmpleado.EmpleadoUsuario && claveValidada==enEmpleado.EmpleadoClave && enEmpleado.EmpleadoRol=="Administrador")
            {
                MenuPrincipal entrar = new MenuPrincipal("Administrador");
                entrar.Show();
                this.Hide();

            }
            if (usuarioValidado == enEmpleado.EmpleadoUsuario && claveValidada == enEmpleado.EmpleadoClave && enEmpleado.EmpleadoRol == "Empleado")
            {
                MenuPrincipal entrar = new MenuPrincipal("Empleado");
                entrar.Show();
                this.Hide();

            }
            else MessageBox.Show("Error en el inicio de sesión");
        }
    }
}
