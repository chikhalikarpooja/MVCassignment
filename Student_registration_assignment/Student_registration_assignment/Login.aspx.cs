using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
namespace Student_registration_assignment
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string em = TextBox1.Text;
            string pass = TextBox2.Text;
            string qr;
            string strcn = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(strcn);
            con.Open();
            qr = "select count(*) from Registration_ass1 where email_id='" + em + "' and password='" + pass + "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            int res = Convert.ToInt32(cmd.ExecuteScalar());
            if(res==1)
            {
                Session["email_id"] = em;
                Response.Redirect("student_dashboard.aspx");
            }
            else
            {
                Label3.Text = "invalid credential";
            }
          
            con.Close();
           
        }

        protected void LogOut_Click(object sender, EventArgs e)
        {
           
        }
    }
}