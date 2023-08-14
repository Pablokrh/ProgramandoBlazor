using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestiónDeClientes
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(); // es la variable cliente, del tipo Cliente. y se crea un nuevo objeto Cliente.
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.TarjetaDeCredito = txtTarjeta.Text;
            cliente.Telefono = txtTelefono.Text;

            listClientes.Items.Add(cliente);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indice = listClientes.SelectedIndex;
            listClientes.Items.RemoveAt(indice);

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
