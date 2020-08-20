using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Student_registration_assignment
{
    public partial class Student_Profile : System.Web.UI.Page
    {
        string label;
        string labell;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string qr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection cn = new SqlConnection(qr);
            cn.Open();
            string qurry = "select first_name, middle_name,last_name,gender,dob,phone_number,c_address,p_address,pincode,xth_marks,xiith_marks,category,stream,course ,email_id from Registration_ass1 where email_id='"+Session["email_id"]+"'";
            SqlCommand cmd = new SqlCommand(qurry, cn);


            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                label2.Text = dr["first_name"].ToString();
                middlelabel.Text = dr["middle_name"].ToString();
                lastlabel.Text = dr["last_name"].ToString();
                genderlabel.Text = dr["gender"].ToString();
                doblabel.Text= dr["dob"].ToString();
                phonelabel.Text= dr["phone_number"].ToString();
                c_addresslabel.Text= dr["c_address"].ToString();
                p_addresslabel.Text= dr["p_address"].ToString();
                pincodelabel.Text= dr["pincode"].ToString();
                xlabel.Text= dr["xth_marks"].ToString();
                xiilabel.Text= dr["xiith_marks"].ToString();
                catlabel.Text= dr["category"].ToString();
                streamlael.Text= dr["stream"].ToString();
                courselabel.Text= dr["course"].ToString();
                emaillabel.Text= dr["email_id"].ToString();








            }

            dr.Close();
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("update_profile.aspx");


        }
    }
}