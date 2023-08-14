using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CommandoconParametros_SQL
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-MSJO6R8\\MSSQLSERVER01 ; database=base1 ; integrated security = true");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena = "insert into articulos(descripcion,precio) values (@descripcion,@precio)";
            //@ daría lugar a pasar parámetros
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar);
            //Con sqlDbType se especifica qué tipo de dato se ingresará
            comando.Parameters.Add("@precio", SqlDbType.Float);
            comando.Parameters["@descripcion"].Value = textBox1.Text;
            //acá se captura lo escrito para usarlo como parámetros
            comando.Parameters["@precio"].Value = float.Parse(textBox2.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            textBox1.Text = "";
            textBox2.Text = "";
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena = "select descripcion, precio from articulos where Identidad=@Identidad";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.Add("@Identidad", SqlDbType.Int);
            comando.Parameters["@Identidad"].Value = int.Parse(textBox3.Text);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                label6.Text = registro["descripcion"].ToString();
                label7.Text = registro["precio"].ToString();
                button3.Enabled = true;
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena = "delete from articulos where Identidad=@Identidad";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.Add("@Identidad", SqlDbType.Int);
            comando.Parameters["@Identidad"].Value = int.Parse(textBox3.Text);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                label6.Text = "";
                label7.Text = "";
                MessageBox.Show("Se borró el artículo");
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            conexion.Close();
            button3.Enabled = false;
        }
    }
}

