using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rediobuttonbank
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double res = 0;
            int actno = Convert.ToInt32(TextBox1.Text);
            int amt = Convert.ToInt32(TextBox2.Text);
            double bal = 1000;
            if(RadioButton1.Checked)
            {
                 res = bal + amt;
            }else if(RadioButton2.Checked)
            {
                 res = bal - amt;
            }
            Label1.Text = "Your account number is:"+actno+"total amount is: "+ res;
            

        }
    }
}