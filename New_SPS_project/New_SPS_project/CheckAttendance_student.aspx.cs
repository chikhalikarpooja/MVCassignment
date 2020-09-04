using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace New_SPS_project
{
    public partial class CheckAttendance_student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("data source = DESKTOP-7DJ3CV1\\SQLEXPRESS; integrated security = true; database = student_database");
            cn.Open();
            //string firstname = TextBox2.Text;
            //string lastname = TextBox3.Text;
            string course1 = DropDownList1.SelectedValue;
            //Response.Write(course1);

            string qr = "select first_name,last_name,course,attendance,date from student_attendance where course = '" + DropDownList1.SelectedValue + "' ";
            //         
            SqlCommand cmd = new SqlCommand(qr, cn);
            cmd.ExecuteNonQuery();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(qr, cn);
            da.Fill(ds);

            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            cn.Close();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Label1.Text = string.Format("{0:dd-MM-yyyy}", Convert.ToDateTime(TextBox1.Text));
        }
    }
}