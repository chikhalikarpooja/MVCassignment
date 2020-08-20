using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Data;

namespace Student_RegistrationMVC.Models
{
    public class DataBaseHandler
    {

        //private SqlConnection con;

        static string constring = ConfigurationManager.ConnectionStrings["constrings"].ToString();
        SqlConnection con = new SqlConnection(constring);
        //  SqlConnection cn = new SqlConnection("Data source =DESKTOP-7DJ3CV1\\SQLEXPRESS;integrated security = true; Database = StudentDatabase");

        public bool Insert_Item(HomePage iList) // model name with calling object
        {

            con.Open();
            // connection();
            string qr = "insert into Registration_ass1 values('" + iList.first_name + "','" + iList.middle_name + "','" + iList.last_name + "','" + iList.gender + "','" + iList.dob + "','" + iList.phone_number + "','" + iList.c_address + "','" + iList.p_address + "','" + iList.pincode + "','" + iList.xth_marks + "','" + iList.xiith_marks + "','" + iList.category + "','" + iList.stream + "','" + iList.course + "','" + iList.email_id + "','" + iList.password + "')";

            SqlCommand cmd = new SqlCommand(qr, con);
            // con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true; // returning the boolean value of execution of a querry
            else
                return false;
        }
        public List<HomePage> GetItemList()
        {
            //connection();
            List<HomePage> iList = new List<HomePage>();

            string query = "SELECT * FROM Registration_ass1";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);    // Display all reecords into tables
            DataTable dt = new DataTable();

            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new HomePage
                {
                    first_name = Convert.ToString(dr["first_name"]),
                    middle_name = Convert.ToString(dr["middle_name"]),
                    last_name = Convert.ToString(dr["last_name"]),
                    gender = Convert.ToString(dr["gender"]),
                    dob = Convert.ToString(dr["dob"]),
                    phone_number = Convert.ToString(dr["phone_number"]),
                    c_address = Convert.ToString(dr["c_address"]),
                    p_address = Convert.ToString(dr["p_address"]),
                    pincode = Convert.ToString(dr["pincode"]),
                    xth_marks = Convert.ToString(dr["xth_marks"]),
                    xiith_marks = Convert.ToString(dr["xiith_marks"]),
                    category = Convert.ToString(dr["category"]),
                    stream = Convert.ToString(dr["stream"]),
                    course = Convert.ToString(dr["course"]),
                    email_id = Convert.ToString(dr["email_id"]),
                    password = Convert.ToString(dr["password"]),
                });
            }
            return iList;
        }

        public bool updatelist(HomePage updata)
        {
            con.Open();
            string qr = "update Registration_ass1 set first_name='"+updata.first_name+"',middle_name='"+updata.middle_name+ "',last_name='" + updata.last_name + "',gender='" + updata.gender + "',dob='" + updata.dob + "',phone_number='" + updata.phone_number + "',c_address='" + updata.c_address + "',p_address='" + updata.p_address + "',pincode='" + updata.pincode + "',xth_marks='" + updata.xth_marks + "',xiith_marks='" + updata.xiith_marks + "',category='" + updata.category + "',stream='" + updata.stream + "',course='" + updata.course + "',password='" + updata.password + "'  where email_id=' "+updata.email_id+"'";
            SqlCommand cmd = new SqlCommand(qr, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)

                return true;
            else
                return false;
           

             
        }
        public bool deletelist(HomePage delete)
        {
            con.Open();
            string qr = "delete from Registration_ass1 where email_id='" + delete.email_id + "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            int i = cmd.ExecuteNonQuery();
            if (i >= 1)
                return true;
            else
                return false;
        }
        public bool login(Login login)
        {
            con.Open();
            string qr = "select * from Registration_assq where email_id='"+login.email_id+"','"+login.password+"'";
            SqlCommand cmd = new SqlCommand(qr,con);

            int i = cmd.ExecuteNonQuery();
            if (i >= 1)
                return true;
            else
                return false;

        }
    }
    }