using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPN3PabloKrojzl
{
    public partial class _Default : Page
    {
        SQL sql = new SQL();

        protected void Page_Load(object sender, EventArgs e)
        {
            LimpiarResultado();
        }
        private void LimpiarResultado()
        {
            if (lbProductosSeleccionados.Items.Count>0 || lblCompraRealizada.Text== "Su compra fue exitosa")
            {
                lblCompraRealizada.Text = "";
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            lbProductosSeleccionados.Items.Add(ddlProductos.Text);
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "" || lbProductosSeleccionados.Items.Count==0)
            {
                string msg="Datos incorrectos: ";

                if (lbProductosSeleccionados.Items.Count == 0)
                {
                    msg+= " 0 productos en el carrito de compras. ";
                                    }
                if (txtnombre.Text == "")
                {
                    msg+= "Ingresar nombre. ";
                }

                lblCompraRealizada.Visible = true;
                lblCompraRealizada.Text = msg;        
            }
            else
            {
                lblCompraRealizada.Visible = true;
                lblCompraRealizada.Text= "Su compra fue exitosa";
                int idCompra= sql.GeneraIDCompra();
               
                foreach (var item in lbProductosSeleccionados.Items)
                {
                    sql.AgregarProducto(txtnombre.Text, item.ToString(), idCompra);
                }               
            }
            lbProductosSeleccionados.Items.Clear();
            txtnombre.Text = "";
        }
    }
}