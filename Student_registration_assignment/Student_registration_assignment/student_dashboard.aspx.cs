using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
namespace Student_registration_assignment
{
    public partial class student_dashboard : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

            Label1.Text = "welcome" + Session["email_id"];
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string qr;
          
            string strcn = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(strcn);
            qr = "select first_name,middle_name,last_name,gender,dob,phone_number,c_address,p_address,pincode,xth_marks,xiith_marks,category,stream,course,email_id from Registration_ass1";
            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Registration_ass1");

            Response.Write("<table width=70% border=1 align=center>");
            Response.Write("<tr>");
            Response.Write("<th> first name</th>");
            Response.Write("<th>Middle name</th>");
            Response.Write("<th>Last name</th>");
            Response.Write("<th>Gender</th>");
            Response.Write("<th>DOB</th>");
            Response.Write("<th>Phone number</th>");
            Response.Write("<th>C_Address</th>");
            Response.Write("<th>P_Address</th>");
            Response.Write("<th>pincode</th>");
            Response.Write("<th>Xth Marks</th>");
            Response.Write("<th>XIIth Marks</th>");
            Response.Write("<th>Category</th>");
            Response.Write("<th>Stream</th>");
            Response.Write("<th>Course</th>");
            Response.Write("<th>Email</th>");

            Response.Write("</tr>");

            foreach (DataRow dr in ds.Tables["Registration_ass1"].Rows)
            {
                Response.Write("<tr>");

                Response.Write("<td>");
                Response.Write(dr["first_name"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["middle_name"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["last_name"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["gender"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");

                Response.Write(dr["dob"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["phone_number"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["c_address"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["p_address"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["pincode"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["xth_marks"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["xiith_marks"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["category"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["stream"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["course"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["email_id"].ToString());
                Response.Write("</td>");

            
                Response.Write("</tr>");

            }
          
            

            Response.Write("</table>");
            
        }

            protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session["email_id"] = "";
            Session.Abandon();
            Session.RemoveAll();
            Response.Redirect("Registration.aspx");

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {

        }
    }
}