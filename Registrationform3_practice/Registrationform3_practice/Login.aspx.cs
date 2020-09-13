using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.DynamicData;

namespace Registrationform3_practice
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email = TextBox1.Text;
            string password = TextBox2.Text;

            string qr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection cn = new SqlConnection(qr);
            string qr2 = "select count(*) from EmpReg_Practice where email='"+email+"'";
            cn.Open();
            SqlCommand cmd = new SqlCommand(qr2, cn);

           int r= Convert.ToInt32( cmd.ExecuteScalar());
            if(r==1)
            {
                Session["email"] = email;
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                Label3.Text = "Invalid email and password";
            }
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}