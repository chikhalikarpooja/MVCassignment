using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Registration_Login_Practice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fullname = TextBox1.Text;
            string dob = TextBox2.Text;
            string address = TextBox3.Text;
            string phone = TextBox4.Text;
            string email = TextBox5.Text;
            string password = TextBox6.Text;
            //SqlConnection cn;
            //string qr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection cn = new SqlConnection("data source= DESKTOP-7DJ3CV1\\SQLEXPRESS; integrated security=true;database= Asp_Practice ");
            string qr = "insert into RegForm1_practice values('"+fullname+"','"+dob+"','"+address+"','"+phone+"','"+email+"','"+password+"')";
            cn.Open();
            SqlCommand cmd = new SqlCommand(qr, cn);
            
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}