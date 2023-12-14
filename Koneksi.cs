using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinalFormsApp
{
    class Koneksi
    {
        public SqlConnection Getconn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data source = MSI; initial catalog=DaftarNama; integrated security=true";
            return Conn;
        }

    }
}

