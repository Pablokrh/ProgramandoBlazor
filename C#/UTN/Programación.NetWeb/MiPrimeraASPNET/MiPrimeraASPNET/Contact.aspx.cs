using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiPrimeraASPNET
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAsesinar_Click(object sender, EventArgs e)
        {
            lblPrecio.Text = "50000";
        }
    }
}