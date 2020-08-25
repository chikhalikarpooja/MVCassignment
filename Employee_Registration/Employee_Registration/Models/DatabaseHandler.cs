using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Employee_Registration.Models
{
    public class DatabaseHandler

    {
       static string cn = ConfigurationManager.ConnectionStrings["constrings"].ToString();
        SqlConnection con = new SqlConnection(cn);

        public bool createdata(Homepage emp)
        {
            string qr = "insert into Employee_Details values('" + emp.Full_name + "','" + emp.Phonenumber + "','" + emp.Address + "','" + emp.Dob + "','" + emp.Gender + "','" + emp.Martial_status + "','" + emp.Category + "','" + emp.Graduation + "','" + emp.Grad_percentage + "','" + emp.PostGraduation + "','" + emp.Post_Grad_percentage + "','" + emp.Skills + "','" + emp.Occupation + "','" + emp.Monthlysalary + "','" + emp.Email + "','" + emp.Password + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(qr, con);
            int i=cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
                return true; // returning the boolean value of execution of a querry
            else
                return false;
        }
    }
    }
