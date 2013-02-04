using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var len = Talker.BlahBlahBlah(TextBox1.Text, Convert.ToInt16(DropDownList1.SelectedValue));
            //MessageBox.Show("The message length is " + len);
            ClientScript.RegisterClientScriptBlock(this.GetType(), "23", "<script>alert('The message length is ' + len)</script>");
        }
    }
}