using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vista
{
    public partial class Form1 : Form
    {
        List<Libro> listObjLibros;
        string[] listadoGeneros;
        string autor;
        string nombre;
        string genero;
        string paginas;
        string importado;
        string precio;     

        public Form1()
        {
            InitializeComponent();
            listadoGeneros = new string[] { "Aventura", "Drama", "Ciencia ficción", "Historia", "Policial" };
            listObjLibros = new List<Libro>();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            autor = txtAutor.Text;
            nombre = txtNombre.Text;
            genero = cBGenero.Text;
            paginas =txtPaginas.Text;
            precio = txtPrecio.Text;         

            if (cBImportado.Checked) importado = "Importado";
            else importado = "Nacional";

            var result= MessageBox.Show("¿Seguro que desea agregar los datos ingresados?", "Confirmar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result ==DialogResult.Yes)
            {
                AgregaLibro(autor, nombre, genero, paginas, precio, importado);
                MessageBox.Show("Se ha ingresado correctamente el libro:" + nombre + " - " + autor + " - " + genero + " - " + paginas + " - " + precio + " - " + importado);
                MuestraLibros();
                LimpiaCampos();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiaCampos();
        }

        List<string> listadoLibros = new List<string>();

        private void AgregaLibro(string autor, string nombre, string genero, string paginas, string precio, string importado)
        {
            listadoLibros.Add(nombre + " - " + autor + " - " + genero + " - " + paginas + " - " + precio + " - " + importado);
        }

        private void MuestraLibros()
        {
            lBMuestraListado.Items.Clear();
            foreach (var item in listadoLibros)
            {
                lBMuestraListado.Items.Add(item);
            }
        }

        private void LimpiaCampos()
        {
            txtAutor.Clear();
            txtNombre.Clear();
            cBGenero.Text = listadoGeneros[0];
            txtPaginas.Clear();
            txtPrecio.Clear();
            cBImportado.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBGenero.DataSource = listadoGeneros;
        }
    }

    public class Libro
    {
        public string Nombre { get; }
        public string Autor { get; }
        public string Genero { get; }
        public int Paginas { get; }
        public string Importado { get; }
        public float Precio { get; }

        public Libro (string nombre, string autor, string genero, string paginas, string importado, string precio)
        {
            Nombre = nombre;
            Autor = autor;
            Genero = genero;
            Paginas = int.Parse(paginas);
            Importado = importado;
            Precio = float.Parse(precio);
        }
    }

}
