using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace Student_registration_assignment
{
    public partial class update_profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
                con.Open();
                string checkUser = "select first_name, middle_name,last_name,gender,dob,phone_number,c_address,p_address,pincode,xth_marks,xiith_marks,category,stream,course ,email_id,password from Registration_ass1 where email_id='" + Session["email_id"] + "'";
                SqlCommand cmd = new SqlCommand(checkUser, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    first_nametxt.Text = dr["first_name"].ToString();
                    middle_nametxt.Text = dr["middle_name"].ToString();
                    last_nametxt.Text = dr["last_name"].ToString();
                    gender_txt.Text = dr["gender"].ToString();
                    dob_txt.Text = dr["dob"].ToString();
                    phonenumber_txt.Text = dr["phone_number"].ToString();
                    caddresstxt.Text = dr["c_address"].ToString();
                    paddresstxt.Text = dr["p_address"].ToString();
                    pincodetxt.Text = dr["pincode"].ToString();
                    xthmarkstxt.Text = dr["xth_marks"].ToString();
                    xiithmarkstxt.Text = dr["xiith_marks"].ToString();
                    category_txt.Text = dr["category"].ToString();
                    stream_txt.Text = dr["stream"].ToString();
                    course_txt.Text = dr["course"].ToString();
                    email_txt.Text = dr["email_id"].ToString();
                    password_txt.Text = dr["password"].ToString();
                }
                dr.Close();
                con.Close();
            }
          

        }

        protected void last_nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
            cn.Open();
            string qurry = "update Registration_ass1 set first_name=@first_name ,middle_name=@middle_name,last_name=@last_name,gender=@gender,dob=@dob,phone_number=@phone_number,c_address=@c_address,p_address=@p_address,pincode=@pincode,xth_marks=@xth_marks,xiith_marks=@xiith_marks,category=@category,stream=@stream,course=@course,email_id=@email_id,password=@password where email_id='" + Session["email_id"]+ " ' ";
            SqlCommand cmd = new SqlCommand(qurry,cn);
            cmd.Parameters.AddWithValue("@first_name", first_nametxt.Text);
            cmd.Parameters.AddWithValue("@middle_name", middle_nametxt.Text);
            cmd.Parameters.AddWithValue("@last_name", last_nametxt.Text);
            cmd.Parameters.AddWithValue("@gender", gender_txt.Text);
            cmd.Parameters.AddWithValue("@dob", dob_txt.Text);
            cmd.Parameters.AddWithValue("@phone_number", phonenumber_txt.Text);
            cmd.Parameters.AddWithValue("@c_address", caddresstxt.Text);
            cmd.Parameters.AddWithValue("@p_address", paddresstxt.Text);
            cmd.Parameters.AddWithValue("@pincode", pincodetxt.Text);
            cmd.Parameters.AddWithValue("@xth_marks", xthmarkstxt.Text);
            cmd.Parameters.AddWithValue("@xiith_marks", xiithmarkstxt.Text);
            cmd.Parameters.AddWithValue("@category", category_txt.Text);
            cmd.Parameters.AddWithValue("@stream", stream_txt.Text);
            cmd.Parameters.AddWithValue("@course", course_txt.Text);
            cmd.Parameters.AddWithValue("@email_id", email_txt.Text);
            cmd.Parameters.AddWithValue("@password", password_txt.Text);
          
            cmd.ExecuteNonQuery();
            cn.Close();

            if (IsPostBack)
            {
              
                Response.Redirect("Student_Profile.aspx");
            }
        }
    }
}