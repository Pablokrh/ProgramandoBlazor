using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Moy2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

    


        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> lista = traerListado();
            mostrarListado(lista);
        }


        private List<int> traerListado()
        {
            List<int> lista = new List<int>();
            lista.Add(2);
            lista.Add(20);
            lista.Add(15);
            lista.Add(77);
            return lista;

        }
        private void mostrarListado(List<int> lista)
         {
         

            for (int i = 0; i < lista.Count; i++) 
            {
                int numero = lista[i];
                MessageBox.Show("El número es: "+numero);
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {

        }
    }
}
