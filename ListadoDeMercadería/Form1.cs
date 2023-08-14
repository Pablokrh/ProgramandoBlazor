using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListadoDeMercadería
{
    public partial class txtPromocion : Form
    {
        public txtPromocion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            cboProctos.Items.Add("Pantalón");
            cboProctos.Items.Add("Camisa");
            cboProctos.Items.Add("Zapatos");


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = cboProctos.SelectedItem.ToString(); //Para obtener el producto seleccionado
            listCarritoDeCompras.Items.Add(productoSeleccionado);    //Con esta linea sea agrega al textarea
                
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double precioFinal = 0;

            int totalProductosCargados = listCarritoDeCompras.Items.Count;     //Este count nos dice cuantos ítems hay

            for (int i = 0; i < totalProductosCargados; i++)
            {
                string productoElegido = listCarritoDeCompras.Items[i].ToString();

                if (productoElegido== "Pantalón")
                {
                    precioFinal += 20;
                }
                if (productoElegido == "Camisa")
                {
                    precioFinal += 35;
                }
                if (productoElegido == "Zapatos")
                {
                    precioFinal += 24;
                }
            }



            if (txtPromo.Text == "NAVIDAD")
            {
                precioFinal = precioFinal * 0.9;

            }
            MessageBox.Show("El precio final es: $" + precioFinal);

        }

    }
} 
