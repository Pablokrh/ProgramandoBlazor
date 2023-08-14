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

namespace SQLyWF_Prueba
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("server= DESKTOP-MSJO6R8 ; database=Jugadores-Cracks ; integrated security = true");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string equipo = txtEquipo.Text;
            string jugador = txtJugador.Text;
            string puntaje = txtPuntaje.Text;

            string cadenaAAgregar = "insert into Jugadores_Cracks (Equipo,Jugador,Puntaje) values ('"+equipo+"','"+jugador+"','"+puntaje+"')";
           //Antes había puesto como nombre de tabla Jugadores:Cracks y me tiraba error
            SqlCommand comandoPablo = new SqlCommand(cadenaAAgregar, conexion);
            comandoPablo.ExecuteNonQuery();
            MessageBox.Show("Los datos se agregaron al sistema");
            txtJugador.Text = "";
            txtEquipo.Text = "";
            txtPuntaje.Text = "";
            conexion.Close();

        }

        private void btnMostrarJugadores_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "select Equipo, Jugador, Puntaje from Jugadores_Cracks";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            txtJugAgr.Clear();
            while (registros.Read())
            {
                txtJugAgr.AppendText(registros["Equipo"].ToString());
                txtJugAgr.AppendText(" - ");
                txtJugAgr.AppendText(registros["Jugador"].ToString());
                txtJugAgr.AppendText(" - ");
                txtJugAgr.AppendText(registros["Puntaje"].ToString());             
                
            }
            conexion.Close();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consJug = txtIdConsulta.Text;
            string consulta = "select * from Jugadores_Cracks where Id=" + consJug;
            SqlCommand comandoConsultaPorId = new SqlCommand(consulta, conexion);
            SqlDataReader registro = comandoConsultaPorId.ExecuteReader();
            if (registro.Read())
            {
                txtConsulta.Text =  registro["Equipo"].ToString() + " - "+ registro["Jugador"].ToString() +" - "+ registro["Puntaje"].ToString();
            }
            else MessageBox.Show("No existen registros con la Id suminstrada");

            conexion.Close();




        }
    }
    
}


/*SqlConnection conexion = new SqlConnection("server= DESKTOP-MSJO6R8 ; database=Jugadores-Cracks ; integrated security = true");
            conexion.Open();
            string consulta = "select * from Jugadores_Cracks";
            SqlDataAdapter MiAdaptadorSQL= new SqlDataAdapter(consulta, conexion);
            using (MiAdaptadorSQL)
            {
                DataTable JugadoresCracksTabla = new DataTable();
                MiAdaptadorSQL.Fill(JugadoresCracksTabla);
                listBoxJugadoresAgregados.DisplayMember = "Nombre";

            */