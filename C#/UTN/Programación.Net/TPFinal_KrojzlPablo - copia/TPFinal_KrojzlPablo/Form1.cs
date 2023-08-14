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
        Class1 Class1 = new Class1();
        List<Empleado> listEmpleados;
      

        public Form1()
        {
            InitializeComponent();
            listEmpleados = new List<Empleado>();
            columnaId.Visible = false;
            try
            {
                listEmpleados=Class1.AgregarALista();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}

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
           
            Application.DoEvents();
            //Y esto??

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
                Class1.EliminarEmpleado(auxId);
                MostrarEmpleados(listEmpleados);
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
                Empleado empl= Class1.RecuperaFila(Id);          
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
                MostrarEmpleados(Class1.FiltrarPorNombre(buscaPorNombre));
            }

        }

        private void btnTablaOrig_Click(object sender, EventArgs e)
        {
            MostrarEmpleados(listEmpleados);
        }
    }

}
