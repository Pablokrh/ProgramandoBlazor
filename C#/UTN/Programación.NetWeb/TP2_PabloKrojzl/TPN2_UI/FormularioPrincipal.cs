using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPN2_UI
{
    public partial class FormularioPrincipal : Form
    {
        TPN2_BLL.Negocios negocios = new TPN2_BLL.Negocios();

        string[] listadoIdiomas = { "Español", "Portugués", "Inglés", "Japonés", "Chino", "Alemán", "Francés", "Ruso" };

        public FormularioPrincipal()
        {
            InitializeComponent();
            Array.Sort(listadoIdiomas);
            cbIdiomas.DataSource = listadoIdiomas;           
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            string opcion = (string)cbIdiomas.SelectedItem;
            lblResultado.Text = negocios.HolaMundo(opcion);
            lblResultado.Visible = Enabled;
        }
    }
}
