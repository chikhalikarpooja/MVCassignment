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
    public partial class Registration : System.Web.UI.Page
    {
       
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        
        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            DateTime dob = Convert.ToDateTime(TextBox4.Text);
           
            Label6.Text =Convert.ToString(calculate_age(dob));
        }
        public int calculate_age(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.Subtract(dob).Days;
            age = age / 365;
            return age;
        }
        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
     

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strcn = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(strcn);
            string first_name1 = TextBox1.Text;
            string middle_name1 = TextBox2.Text;
            string last_name1 = TextBox3.Text;
            string gender1 = "";
            if(RadioButton1.Checked)
            {
                gender1 = RadioButton1.Text;
                RadioButton2.Visible = false;
            }
            else if(RadioButton2.Checked)
            {
                gender1 = RadioButton2.Text;
                RadioButton1.Visible = false;
            }
            string dob1 = TextBox4.Text;
            string phone_number1 = TextBox5.Text;
            string c_address1 = TextBox6.Text;
            string p_address1 = TextBox7.Text;
            string pincode1 = TextBox11.Text;
            string xthmarks1 = TextBox12.Text;
            string xiithmarks1 = TextBox13.Text;
            string category1 = "";
            if(RadioButton7.Checked)
            {
               category1 = RadioButton7.Text;
                RadioButton8.Visible = false;
                RadioButton9.Visible = false;
                RadioButton10.Visible = false;
            }
            else if(RadioButton8.Checked)
            {
                category1 = RadioButton8.Text;
                RadioButton7.Visible = false;
                RadioButton9.Visible = false;
                RadioButton10.Visible = false;
            }
            else if(RadioButton9.Checked)
            {

                category1 = RadioButton9.Text;
                RadioButton7.Visible = false;
                RadioButton8.Visible = false;
                RadioButton10.Visible = false;
            }
            else if(RadioButton10.Checked)
            {

                category1= RadioButton10.Text;
                RadioButton7.Visible = false;
                RadioButton8.Visible = false;
                RadioButton9.Visible = false;
            }
            string stream1 = "";
            if(RadioButton3.Checked)
            {
                stream1 = RadioButton3.Text;
                RadioButton4.Visible = false;
                RadioButton5.Visible = false;
                RadioButton6.Visible = false;
            }
            else if(RadioButton4.Checked)
            {
                stream1 = RadioButton4.Text;
                RadioButton3.Visible = false;
                RadioButton5.Visible = false;
                RadioButton6.Visible = false;
            }
            else if(RadioButton5.Checked)
            {
                stream1 = RadioButton5.Text;
                RadioButton3.Visible = false;
                RadioButton4.Visible = false;
                RadioButton6.Visible = false;
            }
            else if(RadioButton6.Checked)
            {
                stream1 = RadioButton6.Text;
                RadioButton3.Visible = false;
                RadioButton4.Visible = false;
                RadioButton5.Visible = false;
            }
            string course1 = DropDownList1.Text;
            string email1 = TextBox8.Text;
            string password1 = TextBox9.Text;
            string confirmpassword = TextBox10.Text;


          

            con.Open();
            string qr;
            qr = "insert into Registration_ass1 values('" + first_name1+"','"+middle_name1+"','"+last_name1+"','"+gender1+"','"+dob1+"','"+phone_number1+"','"+c_address1+"','"+p_address1+"','"+pincode1+"','"+xthmarks1+"','"+xiithmarks1+"','"+category1+"','"+stream1+"','"+course1+"','"+email1+"','"+password1+"')";
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.ExecuteNonQuery();
            con.Close();
            //  Label18.Text = "Registration Sucsessful";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            Response.Redirect("Login.aspx");
        }
        
        protected void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}