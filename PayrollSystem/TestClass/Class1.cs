using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestClass
{
    public class DatabaseObject
    {
        public void UpdateDBSimple(string sql, string connectionstring)
        {
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();

            conn.ConnectionString = connectionstring;
            conn.Open();

            System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
            comm.Connection = conn;

            comm.CommandText = sql;
            comm.ExecuteNonQuery();
            conn.Close();
        }

    }
}
