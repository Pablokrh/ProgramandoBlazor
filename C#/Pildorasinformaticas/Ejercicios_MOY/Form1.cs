using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_MOY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cambiar_Click(object sender, EventArgs e)
        {
            int[] listadoDeItems = new  []{0, 5, 6, 7}; //Esto no lo usa, por lo dificil que es modificarlo después.
            List<int> lista = new List<int>();
            lista.Add(2);
            lista.Add(20);
            lista.Add(40);
            lista.Add(89);
            for (int i = 0; i < lista.Count; i++)
            {
                int numero = lista[i];
                MessageBox.Show("El número es: " + numero);

            }





        }
    }
}

/*      string textoEdad = txtEdad.Text;

            int edad = Int32.Parse(textoEdad);
               
            bool esMayorDeEdad = edad >= 18;
            lblResultado.Text = "El usuario es menor de edad"; //esto es lo que se pone por defecto
            if (esMayorDeEdad)
            {
                lblResultado.Text = "El usuario es mayor de edad";
            }
*/