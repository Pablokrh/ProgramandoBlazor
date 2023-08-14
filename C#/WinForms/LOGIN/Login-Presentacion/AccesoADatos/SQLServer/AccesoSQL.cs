using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoADatos
{
    public abstract class AccesoSQL
    {
        private readonly string connectionString;

        public AccesoSQL()
        {
            connectionString = "Server=DESKTOP-MSJO6R8; DataBase=MyCompany; Integrated Security=true";
        }
      
        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }

    }

    
}
