using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos;
namespace Practica_1
{
    public partial class Form1 : Form
    {
        telefono Movistar = new telefono();
        telefono Claro = new telefono("Samsung", "Rojito", "con botones"); //Ahí pasa el parámetro a la M.
        Persona P = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Llamar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Operaciones.suma(55,66).ToString()); 
            MessageBox.Show(Movistar.mandarMensaje("Eduardo", "La puerca está en la pocilga"));
            MessageBox.Show("El crack de pablo pudo conseguir este número " +Operaciones.total.ToString());

            P.Pais = "Argentina"; //Este es el set, porque ahí se ingresa la info a la variable
            MessageBox.Show(P.Pais);
            P.nid = "4495";
            MessageBox.Show(P.nid);

        }
    }   
}
