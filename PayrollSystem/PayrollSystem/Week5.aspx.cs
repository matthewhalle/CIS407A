using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace PayrollSystem
{
    public partial class Week5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TestClass.DatabaseObject mydbobj = new TestClass.DatabaseObject();
            mydbobj.UpdateDBSimple("update HalleAccounts set balance = 2000 where accountid = 1",
                                   System.Configuration.ConfigurationManager.ConnectionStrings[2].ToString());
        }


        protected void btnGo_Click(object sender, EventArgs e)
        {
            lblBalance.Text = ProcessCheck(double.Parse(txtCheck1.Text)).ToString();
            lblBalance.Text = ProcessCheck(double.Parse(txtCheck2.Text)).ToString();
            lblBalance.Text = ProcessCheck(double.Parse(txtCheck3.Text)).ToString();
            lblBalance.Text = ProcessCheck(double.Parse(txtCheck4.Text)).ToString();
            lblBalance.Text = ProcessCheck(double.Parse(txtCheck5.Text)).ToString();

        }

        public double ProcessCheck(double value)
        {
            var conn = new System.Data.SqlClient.SqlConnection();
            var connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["Week3Tracker"].ToString();
            conn.ConnectionString = connectionstring;
            conn.Open();
            var comm = new System.Data.SqlClient.SqlCommand {Connection = conn};
            System.Data.SqlClient.SqlTransaction trans;
            trans = conn.BeginTransaction();
            comm.Transaction = trans;

            string sql = "update HalleAccounts set balance = balance - @balance where accountid = 1";

            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@balance", value);

            comm.ExecuteNonQuery();

            sql = "select balance from HalleAccounts where accountid = 1";

            comm.Parameters.Clear();
            comm.CommandText = sql;
            object result = comm.ExecuteScalar();

            if (Convert.ToDouble(result) < .01)
            {
                trans.Rollback();
                conn.Close();

            }
            else
            {
                trans.Commit();
                conn.Close();

            }
            return Convert.ToDouble(result);
        }

      
    }

}

