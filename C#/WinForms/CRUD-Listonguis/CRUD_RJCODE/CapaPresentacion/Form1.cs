using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Data.SqlClient;

namespace CapaPresentacion
{

    public partial class Form1 : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        private string idProducto = null;
        private bool editar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            objetoCN = new CN_Productos();
            dataGridView1.DataSource = objetoCN.MostrarProducto();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    objetoCN.Insertar(txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text);
                    MessageBox.Show("Registro insertado correctamente");
                    MostrarProductos();
                    LimpiarCampos();
                }
                catch (Exception err)
                {
                    MessageBox.Show("no se pudieron insertar los datos. Motivo: " + err.Message);                }

            }
           if (editar==true)
            {
                try
                {
                    MessageBox.Show("Entró a Insertar:editar==TRue");
                    objetoCN.Editar(txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, idProducto);
                    MessageBox.Show("Registro insertado correctamente");
                    MostrarProductos();
                    editar = false;
                    LimpiarCampos();
                }

                catch (Exception er)
                {
                    MessageBox.Show("no se pudieron insertar los datos. Motivo: " + er.Message);
                }

            }

        }

        private void LimpiarCampos()
        {
            txtStock.Clear();
            txtPrecio.Clear();
            txtNombre.Clear();
            txtMarca.Clear();
            txtDescripcion.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }
            else MessageBox.Show("Debe elegir una fila para poder editar");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.Eliminar(idProducto);
                MessageBox.Show("Registro eliminado correctamente");
                MostrarProductos();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
    }
}
