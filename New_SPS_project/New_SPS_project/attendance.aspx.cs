using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace New_SPS_project
{
    public partial class attendance : System.Web.UI.Page
    {

        string first_name;
        string last_name;
        string course;
        //string attendance1;
        // string date;
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e) // marks attendance button
        {

            SqlConnection cn = new SqlConnection("data source = DESKTOP-7DJ3CV1\\SQLEXPRESS; integrated security = true; database = student_database");
            cn.Open();
            //string firstname = TextBox2.Text;
            //string lastname = TextBox3.Text;
            string course1 = DropDownList2.SelectedValue;
            //Response.Write(course1);

            string qr = "select first_name,last_name,course from Register_db where role = 'Student' and course = '" + DropDownList2.Text + "' ";
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
        //private  void saveattendance(string first_name, string last_name, string course, string attendance)
        // {

        //SqlConnection con = new SqlConnection("data source = DESKTOP-7DJ3CV1\\SQLEXPRESS; integrated security = true; database = student_database");

        //con.Open();

        //string insertQry = "INSERT INTO student_attendance(first_name, last_name,course,attendance,date) " +
        //                   "VALUES(' " + first_name + "', ' " + last_name + "', ' " + course + " ',' " + attendance + " ',' "
        //                   + Label1.Text + " '";



        //SqlCommand cmd1 = new SqlCommand(insertQry, con);


        ////cmd.ExecuteNonQuery();
        //con.Close();

        //}


        protected void Button2_Click(object sender, EventArgs e) // save attendance code

        {
            string a = "";
            SqlConnection con = new SqlConnection("data source = DESKTOP-7DJ3CV1\\SQLEXPRESS; integrated security = true; database = student_database");

            con.Open();
            for (int i = 0; i < GridView1.Rows.Count; i++)

            {

                first_name = GridView1.Rows[i].Cells[0].Text;
                last_name = GridView1.Rows[i].Cells[1].Text;
                RadioButton rb1 = (GridView1.Rows[i].Cells[2].FindControl("RadioButton1") as RadioButton);
                RadioButton rb2 = (GridView1.Rows[i].Cells[2].FindControl("RadioButton2") as RadioButton);

                if (rb1.Checked)
                {
                    a = rb1.Text;
                    rb2.Visible = false;
                    //attendance1 = "Present";
                }
                else if (rb2.Checked)
                {
                    a = rb2.Text;
                    rb1.Visible = false;
                    //attendance1 = "Absent";
                }
                else
                {
                    Label2.Text = "Please choose one option";
                }
                string course = DropDownList2.SelectedValue;



                string insertQry = "INSERT INTO student_attendance(first_name, last_name,course,attendance,date)VALUES('"+first_name+"','"+last_name+"','"+course+"','"+a+"','"+Label1.Text+"')";



                SqlCommand cmd1 = new SqlCommand(insertQry, con);


                cmd1.ExecuteNonQuery();

            }





            con.Close();



        }



        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

            Label1.Text = string.Format("{0:dd-MM-yyyy}", Convert.ToDateTime(TextBox1.Text));


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click1(object sender, EventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
         
          


            SqlConnection cn = new SqlConnection("data source = DESKTOP-7DJ3CV1\\SQLEXPRESS; integrated security = true; database = student_database");
            cn.Open();
          
            string course1 = DropDownList2.SelectedValue;
            //Response.Write(course1);

            string qr = "SELECT first_name,last_name,course,attendance,date from student_attendance where course='"+course1+"' and date= '"+Label1.Text+"' ";
            
            SqlCommand cmd = new SqlCommand(qr, cn);
            cmd.ExecuteNonQuery();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            GridView2.DataSource = ds.Tables[0];
            GridView2.DataBind();
            cn.Close();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

        }
    
