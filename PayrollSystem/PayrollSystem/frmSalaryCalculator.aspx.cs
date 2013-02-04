using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollSystem
{
    public partial class frmSalaryCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string annualHourStr = txtAnnualHours.Text;
            double annualHoursDou = Convert.ToDouble(annualHourStr);
            string rateStr = txtRate.Text;
            double rateDou = Convert.ToDouble(rateStr);
            double resultDou = annualHoursDou*rateDou;
            lblSalary.Text = "$" + Convert.ToString(resultDou);

        }
    }
}