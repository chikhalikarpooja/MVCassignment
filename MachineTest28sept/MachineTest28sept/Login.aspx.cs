using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace MachineTest28sept
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email = TextBox1.Text;
            string password = TextBox3.Text;

            string qr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection cn = new SqlConnection(qr);

            string querry = " select count (*) from User_RegBook  where email= '"+email+"' ";
            cn.Open();
            SqlCommand cmd = new SqlCommand(querry, cn);
            int r = Convert.ToInt32(cmd.ExecuteScalar());

            if (r == 1)
            {
                Session["email"] = email;
                Response.Redirect("BookDashboard.aspx");
            }
            else
            {
                Label3.Text = "Invalid Credential";
            }
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}