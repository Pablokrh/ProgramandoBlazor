using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace ConSQL
{
    public class ConectaSQL
    {
        NpgsqlConnection conn = new NpgsqlConnection ("Server = localHost; User Id = postgres; Password = Post22Futi; Database = postgres");

        public void   Conectar() {
            conn.Open();
            MessageBox.Show("Listo");
        }



    }
}
