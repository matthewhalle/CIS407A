﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassCalc;

namespace PayrollSystem
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void cmdCalc_Click(object sender, EventArgs e)
        {
            lblResult.Text = ulator.Add(txtNum1.Text, txtNum2.Text).ToString();
        }
        protected void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtNum2.Text) == 0)
                {
                    lblResult.Text = "You cannot divide by zero";
                }
                else
                {
                    try
                    {
                        lblResult.Text = ulator.Divide(txtNum1.Text, txtNum2.Text).ToString();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception er)
            {
                throw er;
            }
        }
    }
}