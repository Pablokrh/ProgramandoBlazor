using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ControladorTablas;
using Entidades;

namespace TPFinal_KrojzlPablo
{
    public partial class Form1 : Form
    {
        NegociosEmpleados negociosEmpleados = new NegociosEmpleados();
        List<Empleado> listEmpleados;
        EmpleadoResponse resp;

        public Form1()
        {
            InitializeComponent();
            listEmpleados = new List<Empleado>();
            columnaId.Visible = false;
            resp = negociosEmpleados.AgregarALista();
            DGVPropiedades();
            if (resp.error == null)
            {
                listEmpleados = resp.listEmpleado;
            }

            else
            {
                MessageBox.Show("Ocurrió un error al conectar con la BBDD"+ Environment.NewLine+ resp.error.Message);
            }        
        }


        private void DGVPropiedades()
        {         
            columnaId.Visible = false;
            columnaNombreCompleto.Width = 150;
            columnaDni.Width = 100;
            columnaEdad.Width = 50;
            columnaCasado.Width = 60;
            columnaSalario.Width = 175;
            dgvTabla.BackgroundColor = Color.White;
        }

        public void MostrarEmpleados(List<Empleado> listEmpleados)
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
            Form2AgregarModificarEmpleado form2AgregarEmpleado = new Form2AgregarModificarEmpleado(this, listEmpleados);
            form2AgregarEmpleado.Text = "Agregar empleado";
            form2AgregarEmpleado.btnAgregarEmpleado.Text = "Agregar";
            Hide();
            form2AgregarEmpleado.Show();
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar al empleado?", "Empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int auxId = Convert.ToInt32(dgvTabla.CurrentRow.Cells[0].Value);
                resp=negociosEmpleados.EliminarEmpleado(auxId);
               
                if (resp.error == null)
                {
                   listEmpleados = resp.listEmpleado;
                   MostrarEmpleados(listEmpleados);
                }
                else
                {
                    MessageBox.Show("El proceso no pudo ser llevado a cabo:" + Environment.NewLine + resp.error.Message);
                }
            }
                

        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form2AgregarModificarEmpleado form2AgregarEmpleado=new Form2AgregarModificarEmpleado(this, listEmpleados);

            int Id = Convert.ToInt32(dgvTabla.CurrentRow.Cells[0].Value);
            form2AgregarEmpleado.btnAgregarEmpleado.Text = "Modificar";
            form2AgregarEmpleado.Text = "Modificar empleado";
            try
            {
                resp = negociosEmpleados.RecuperaFila(Id);
                Empleado empl=resp.empleado;          
                form2AgregarEmpleado.Show();
                form2AgregarEmpleado.ModificarEmpleado(empl, Id);
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
            this.Hide();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string buscaPorNombre = txtFiltrar.Text;
            if (buscaPorNombre == "")
            {
                MessageBox.Show("Debes ingresar algún valor para realizar la búsqueda");
            }
            else
            {
                resp = negociosEmpleados.FiltrarPorNombre(buscaPorNombre);
                if (resp.error==null)
                {
                    MostrarEmpleados(resp.listEmpleado);
                }
                else
                {
                    MessageBox.Show("El proceso no pudo ser llevado a cabo:" + Environment.NewLine + resp.error.Message);
                }
            }

        }

        private void btnTablaOrig_Click(object sender, EventArgs e)
        {
            MostrarEmpleados(listEmpleados);
        }
    }

}
