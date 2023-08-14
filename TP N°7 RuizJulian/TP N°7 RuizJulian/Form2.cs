using mayoristaEstrellaBussines;
using MayoristaEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_N_7_RuizJulian
{
    public partial class ListadoEmpleados : Form
    {
        public ListadoEmpleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void dgEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int id = (int)this.dgEmpleado.Rows[e.RowIndex].Cells["id"].Value;

            if (this.dgEmpleado.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                frmABMEmpleado frmEmpleado = new frmABMEmpleado(id);
                frmEmpleado.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Empleado_FormClosed);

                frmEmpleado.ShowDialog();
            }
            else if (this.dgEmpleado.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                if (MessageBox.Show("Esta seguro de eliminar al empleado?","Empleado",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    EmpleadoBussines.DeleteEmpleado(id);
                    MessageBox.Show("Se elimino correctamente el cliente");
                    CargarEmpleados();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMEmpleado empleado = new frmABMEmpleado();
            empleado.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Empleado_FormClosed);

            empleado.ShowDialog();
        }

        private void Empleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            dgEmpleado.AutoGenerateColumns = false;
            dgEmpleado.DataSource = EmpleadoBussines.ListarEmpleados(txtNombre.Text);
        }
    }
}
