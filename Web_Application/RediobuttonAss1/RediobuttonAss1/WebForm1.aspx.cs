using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RediobuttonAss1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ans = 0;

            if (RadioButton1.Checked)
            {

                ans = ans + 1;
                Response.Write("" + ans);
            }

            else if (RadioButton2.Checked)
            {


                ans = ans - 1;
                Response.Write("" + ans);
            }

            else
            {
            }
            if (RadioButton4.Checked)
            {

                ans = ans + 1;
                Response.Write("" + ans);

            }
            else if (RadioButton3.Checked)
            {

                ans = ans - 1;
                Response.Write("" + ans);
            }

            else
            {
            }
            if (RadioButton5.Checked)
            {


                ans = ans + 1;
                Response.Write("" + ans);
            }

            else if (RadioButton6.Checked)
            {

                ans = ans - 1;
                Response.Write("" + ans);
            }


            else
            {
            }
            if (RadioButton7.Checked)
            {
                
                
                    ans = ans + 1;
                    Response.Write("" + ans);
                
            }
           else if (RadioButton8.Checked)
            {
                ans = ans - 1;
                    Response.Write("" + ans);
                
            }
            else
            {

            }
           
                Label1.Text = "Correct answer is: " + ans;
            
             }
        }
}