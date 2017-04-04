using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeAssignment1_5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        double[] balances = { 30345.90, 40785.22, 5643.23 };

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!IsPostBack)
            {
                accountDropDown.Items.Add("Savings Account");
                accountDropDown.Items.Add("Checking Account");
                accountDropDown.Items.Add("Student Account");
            }
        }

        protected void withdrawBtn_Click(object sender, EventArgs e)
        {
            string message;
            double withdrawAmount = double.Parse(withdrawTxtBox.Text);
            double newBalance = balances[accountDropDown.SelectedIndex] - withdrawAmount;

            if(newBalance >= 0)
            {
                message = "Withdrawal successful. Your new balance is " + newBalance.ToString("c");
            }
            else
            {
                message = "Withdrawal amount is greater than the balance which is " + balances[accountDropDown.SelectedIndex].ToString("c");
            }
            messageLabel.Text = message;
        }
    }
}