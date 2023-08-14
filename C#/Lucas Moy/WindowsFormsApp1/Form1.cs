using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localHost; User id= postgres; Password= Post22Futi; Database= pp");
        public void Conectar()
        {
            conn.Open();
            System.Windows.Forms.MessageBox.Show("Listo");

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Conectar_Click(object sender, EventArgs e)
        {

        }
    }
}
