using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollSystem
{
    public partial class login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        protected void cmdLogIn_Click(object sender, EventArgs e)
        {
            ////web config method
            //if (System.Web.Security.FormsAuthentication.Authenticate(txtUserName.Text, txtPassword.Text))
            //{
            //    //good you logged in.
            //    System.Web.Security.FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, false);
            //}
            //else
            //{
            //    lblError.Text = "Either your username or password was incorrect";
            //    lblError.Visible = true;
            //}
            SqlConnection conn = new SqlConnection();
            string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["Week3Tracker"].ToString();
            conn.ConnectionString = connectionstring;
            conn.Open();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;

            string sql = "select userlevel from halle_logon where userid = @userid and password = @password";

            comm.CommandText = sql;

            comm.Parameters.AddWithValue("@userid", txtUserName.Text);
            comm.Parameters.AddWithValue("@password", txtPassword.Text);

            object result = comm.ExecuteScalar();
            if (result != null)
            {
                //send them where i choose:
                Session["UserLevel"] = result.ToString();
                System.Web.Security.FormsAuthentication.SetAuthCookie(txtUserName.Text, false);
                Response.Redirect("securedpage.aspx");

                //send them where they tried to go:
                //System.Web.Security.FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, false);
            }
            else
            {
                lblError.Text = "Either your username or password was incorrect";
            }

            conn.Close();
        }
    }
}