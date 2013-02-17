using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PayrollSystem
{
    public class TrackerClass
    {
        private void trackingMethod(string trackKey, string value)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=devrystudentsp10.db.6077598.hostedresource.com;User Id=DeVryStudentSP10;Password=OidLZqBv4;";
            conn.Open();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            var SQL = "insert into halletracker (usertrackerid, trackkey, value, trackwhen) values (NEWID(), @trackkey, @value, @trackwhen)";
            comm.CommandText = SQL;

            comm.Parameters.AddWithValue("@trackkey", trackKey);
            comm.Parameters.AddWithValue("@value", value);
            comm.Parameters.AddWithValue("@trackwhen", DateTime.Now);

            comm.ExecuteNonQuery();
        }
    }
}