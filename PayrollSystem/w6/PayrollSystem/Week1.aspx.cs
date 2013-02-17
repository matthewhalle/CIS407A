using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollSystem
{
    public partial class Week11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var annualHourStr = txtAnnualHours.Text;
            var annualHoursDou = Convert.ToDouble(annualHourStr);
            var rateStr = txtRate.Text;
            var rateDou = Convert.ToDouble(rateStr);
            var resultDou = annualHoursDou * rateDou;
            lblSalary.Text = "$" + Convert.ToString(resultDou);
        }
    }
}