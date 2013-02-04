using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollSystem
{
    public partial class Week3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnClear.Visible = true;
            
            foreach (string item in Request.ServerVariables)
            {
                if (Request.ServerVariables[item].Length > 1)
                {
                    trackingMethod(item, Request.ServerVariables[item]);
                }
            }            
        }
        private void trackingMethod(string trackKey, string value)
        {
            var conn = new SqlConnection();
            conn.ConnectionString ="Server=devrystudentsp10.db.6077598.hostedresource.com;User Id=DeVryStudentSP10;Password=OidLZqBv4;";
            conn.Open();
            var comm = new SqlCommand();
            comm.Connection = conn;
            var SQL ="insert into halletracker (usertrackerid, trackkey, value, trackwhen) values (NEWID(), @trackkey, @value, @trackwhen)";
            comm.CommandText = SQL;

            comm.Parameters.AddWithValue("@trackkey", trackKey);
            comm.Parameters.AddWithValue("@value", value);
            comm.Parameters.AddWithValue("@trackwhen", DateTime.Now);

            comm.ExecuteNonQuery();
        }
        protected void btnClear_Click(object sender, EventArgs e)
        {
            var conn = new SqlConnection();
            conn.ConnectionString = "Server=devrystudentsp10.db.6077598.hostedresource.com;User Id=DeVryStudentSP10;Password=OidLZqBv4;";
            conn.Open();
            var comm = new SqlCommand();
            comm.Connection = conn;
            var SQL = "TRUNCATE TABLE halletracker ";
                   
            comm.CommandText = SQL;
            comm.ExecuteNonQuery();
            Response.Redirect(Request.RawUrl);
        }        
    }
}