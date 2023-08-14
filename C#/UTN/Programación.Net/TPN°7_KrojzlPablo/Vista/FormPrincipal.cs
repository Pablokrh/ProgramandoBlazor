using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidades;

namespace Vista
{
    public partial class FormPrincipal : Form
    {
        EmpleadoNegocios empleado = new EmpleadoNegocios();
        List<EmpleadoEntidades> listEmpleados;
      

        public FormPrincipal()
        {
            InitializeComponent();
            listEmpleados = new List<EmpleadoEntidades>();
            listEmpleados=empleado.AgregarALista();  
            DGVPropiedades();

        }

        private void DGVPropiedades()
        {
            columnaId.Visible = false;
            dgvTabla.Columns[3].Width = 50;
            dgvTabla.Columns[3].Width = 44;
            dgvTabla.Columns[3].Width = 44;
            dgvTabla.Columns[3].Width = 44;
        }

        public void MostrarEmpleados(List<EmpleadoEntidades> listEmpleados)
        {
            dgvTabla.DataSource = "";
            dgvTabla.DataSource = null;
            foreach (var item in listEmpleados)
            {
                dgvTabla.Rows.Add(item.Id, item.NombreCompleto, item.Dni, item.Edad, item.Casado, item.Salario.ToString("F2"));
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarEmpleados(listEmpleados);           
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            Form2AgregarEmpleado form2AgregarEmpleado = new Form2AgregarEmpleado(this, listEmpleados);
            form2AgregarEmpleado.Text = "Agregar empleado";
            form2AgregarEmpleado.btnAgregarEmpleado.Text = "Agregar";
            Hide();
            form2AgregarEmpleado.Show();
        }      
    }

}
