using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollSystem
{
    public partial class Week2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //make the output text box not visable 
            //pnlOutput.Visible = false;
            if (Request.Params["debug"] != "true")
            {
                pnlOutput.Visible = false;
            }
            if (Request.Params["lastname"] != null)
            {
                txtFirstName.Text = Request.Params["lastname"];
            }


        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            pnlInput.Visible = false;
            pnlOutput.Visible = true;

            //take the text inputed and put into one text box
            txtVerifiedInfo.Text = txtFirstName.Text + "\n" + txtLastName.Text + "\n" + txtPayRate.Text + "\n" +
                                   txtStartDate.Text + "\n" + txtEndDate.Text;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            clearMethod();
        }

        protected void btnRedo_Click(object sender, EventArgs e)
        {
            //on redo clear and go back to start page
            pnlInput.Visible = true;
            pnlOutput.Visible = false;
            clearMethod();
        }
        private void clearMethod()
        {
            // create a method as I use this twice and did not make sense to write twice
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPayRate.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
        }
    }
}