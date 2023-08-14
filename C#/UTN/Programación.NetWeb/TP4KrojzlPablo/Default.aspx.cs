using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4KrojzlPablo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnActualizaHora_Click(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now;
            lblHora.Text = hora.ToString();

            //Demostración de que el UpdatePanel no permite la realización de cambios por fuera del mismo.
            txtSuma.Text = "45";
        }

        protected void btnSuma_Click(object sender, EventArgs e)
        {
            txtSuma.Text = (Int32.Parse(txt1.Text) + Int32.Parse(txt2.Text)).ToString();

        }
    }
}