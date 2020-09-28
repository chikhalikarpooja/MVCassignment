using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
namespace MachineTest28sept
{
    public partial class signup_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fullname = TextBox1.Text;
            string dob = TextBox2.Text;
            string phonenumber = TextBox3.Text;
            string address = TextBox4.Text;
            string email = TextBox5.Text;
            string password = TextBox6.Text;

            string qr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection cn = new SqlConnection(qr);

            string querry = "insert into User_RegBook values('" + fullname + "','" + dob + "','" + phonenumber + "','" + address + "','" + email + "','" + password + "')";                                               
            cn.Open();
            SqlCommand cmd = new SqlCommand(querry, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        
        
        
        }
    }
}