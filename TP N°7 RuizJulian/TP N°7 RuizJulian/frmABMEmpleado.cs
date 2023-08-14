using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MayoristaEntities;
using mayoristaEstrellaBussines;
using TP_N_7_RuizJulian;

namespace TP_N_7_RuizJulian
{
    public partial class frmABMEmpleado : Form
    {
        public frmABMEmpleado()
        {
            InitializeComponent();
        }

        private Empleado empleado = new Empleado();
        public frmABMEmpleado(int ID)
        {
            InitializeComponent();
            lblid.Text = ID.ToString();
            
            empleado = EmpleadoBussines.ObtenerEmpleado(ID);

            txtCuil.Text = empleado.Cuil;
            txtDomicilio.Text = empleado.Domicilio;
            txtLocalidad.Text = empleado.Localidad;
            txtNacionalidad.Text = empleado.Nacionalidad;
            txtMail.Text = empleado.Mail;
            txtNombreApellido.Text = empleado.NombreApellido;
            txtPais.Text = empleado.Pais;
            txtProvincia.Text = empleado.Provincia;
            txtTelefono.Text = empleado.Telefono;
            dtpFechaNacimiento.Value = empleado.FechaNacimiento;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmABMEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            empleado.Cuil = txtCuil.Text;
            empleado.Domicilio = txtDomicilio.Text;
            empleado.Localidad = txtLocalidad.Text;
            empleado.Nacionalidad = txtNacionalidad.Text;
            empleado.Mail = txtMail.Text;
            empleado.NombreApellido = txtNombreApellido.Text;
            empleado.Pais = txtPais.Text;
            empleado.Provincia = txtProvincia.Text;
            empleado.Telefono = txtTelefono.Text;
            empleado.FechaNacimiento = dtpFechaNacimiento.Value;

            EmpleadoBussines.ABMEmpleado(empleado);

            MessageBox.Show("Se guardo el cliente OK");

            this.Close();
        }

        private void tppFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNacionalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
