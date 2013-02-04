using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace PayrollSystem
{
    public partial class week4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptDisplay.ViewStateMode = ViewStateMode.Disabled;
           
        }

        protected void cmdSearch_OnClick(object sender, EventArgs e)
        {
            basicSearch();
        }

        private void basicSearch()
        {
            var conn = new SqlConnection();
            conn.ConnectionString = "Server=devrystudentsp10.db.6077598.hostedresource.com;User Id=DeVryStudentSP10;Password=OidLZqBv4;";
            conn.Open();
            var comm = new SqlCommand();
            comm.Connection = conn;

            var SQL = "";
           
            if (drpResults.SelectedValue != null && drpResults.SelectedValue != "null")
            {
                var searchResults = Convert.ToInt16(drpResults.SelectedValue);

                SQL = "select TOP "+ searchResults +" UserTrackerID, TrackKey, value, trackwhen from HalleTracker where 1=1";
            }
            else
            {
                SQL = "select UserTrackerID, TrackKey, value, trackwhen from HalleTracker where 1=1";
            }
            if (txtKey.Text.Length > 0)
            {
                SQL += " and trackkey like @trackkey";
                comm.Parameters.AddWithValue("@trackkey", "%" + txtKey.Text + "%");
            }
            if (txtValue.Text.Length > 0)
            {
                SQL += " and value like @value ";
                comm.Parameters.AddWithValue("@value", "%" + txtValue.Text + "%");
            }
            if (txtWhen.Text.Length > 0)
            {
                SQL += " and trackwhen like @trackwhen ";
                comm.Parameters.AddWithValue("@trackwhen", "%" + txtWhen.Text + "%");
            }
            //if (drpResults.SelectedValue != null)
            //{
            //    //SQL += "TOP ' " + drpResults.SelectedValue + "'";
            //    SQL += "select TOP 5 UserTrackerID, TrackKey, value, trackwhen from HalleTracker";
            //    var searchResults = Convert.ToInt16(drpResults.SelectedValue);
            //    comm.Parameters.AddWithValue("@top", searchResults);
                
            //}
            //else
            //{
            //    SQL += "select TOP (100) UserTrackerID, TrackKey, value, trackwhen from HalleTracker"; 
            //}

            Response.Write(SQL);
            //var da = new SqlDataAdapter();
            comm.CommandText = SQL;

           
            SqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                rptDisplay.DataSource = dr;
                rptDisplay.DataBind();
            }
        }

    }
}