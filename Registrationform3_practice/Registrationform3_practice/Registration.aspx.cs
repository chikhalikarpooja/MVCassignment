using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Registrationform3_practice
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fullname = TextBox1.Text;
            string dob = TextBox2.Text;
            string phone = TextBox3.Text;
            string gender = "";
            string address = TextBox4.Text;
            string qual = TextBox5.Text;
            string occu = TextBox6.Text;
            string email = TextBox7.Text;
            string password = TextBox8.Text;
            if(RadioButton1.Checked)
            {
                gender = RadioButton1.Text; ;
                RadioButton2.Visible = false;
            }
            if (RadioButton2.Checked)
                        {
                gender = RadioButton2.Text; ;
                RadioButton1.Visible = false;
            }
            string qr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection cn = new SqlConnection(qr);
            string qr1 = "insert into EmpReg_Practice values('"+fullname+"','"+dob+"','"+phone+"','"+gender+"','"+address+"','"+qual+"','"+occu+"','"+email+"','"+password+"')";
            cn.Open();
            SqlCommand cmd = new SqlCommand(qr1, cn);
            cmd.ExecuteNonQuery();
            cn.Close();

        }
    }
}