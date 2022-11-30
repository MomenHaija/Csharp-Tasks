using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Add_Click1(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(Number1.Text);
            num2 = Convert.ToInt32(Number2.Text);
            result = num1 + num2;
            Result.Text=Convert.ToString(result);
        }

        protected void Sub_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(Number1.Text);
            num2 = Convert.ToInt32(Number2.Text);
            result = num1 - num2;
            Result.Text = Convert.ToString(result);
        }

        protected void Div_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(Number1.Text);
            num2 = Convert.ToInt32(Number2.Text);
            result = num1 / num2;
            Result.Text = Convert.ToString(result);
        }


        protected void Mult_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(Number1.Text);
            num2 = Convert.ToInt32(Number2.Text);
            result = num1 * num2;
            Result.Text = Convert.ToString(result);
        }

    }
}