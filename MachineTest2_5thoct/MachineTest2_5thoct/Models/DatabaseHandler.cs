using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace MachineTest2_5thoct.Models
{
    public class DatabaseHandler
    {
        static string constrings = ConfigurationManager.ConnectionStrings["constring"].ToString();
        SqlConnection con = new SqlConnection(constrings);

        public bool Insert_Item(Homepage iList)
        {

            con.Open();
            
            string qr = "insert into User_RegBook values('" + iList.fullname + "','" + iList.Dob + "','" + iList.phonenumber+ "','" + iList.address + "','" + iList.Email + "','" + iList.Password + "')";
            SqlCommand cmd = new SqlCommand(qr, con);
       
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true; 
            else
                return false;
      }


        public bool Insert_Book(AddBook iList1)
        {

            con.Open();
           
            string qr = "insert into AddBook values('" + iList1.BookName + "','" + iList1.MRP + "','" + iList1.Author + "','" + iList1.Category + "','" + iList1.Publisher+ "')";            // con.Open();
            SqlCommand cmd = new SqlCommand(qr, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true; 
            else
                return false;
        }
        public List<AddBook> GetItemList()
        {
            //connection();
            List<AddBook> iList1 = new List<AddBook>();

            string query = "SELECT * FROM AddBook ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);    // Display all reecords into tables
            DataTable dt = new DataTable();

            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList1.Add(new AddBook
                {
  BookName = Convert.ToString(dr["bookname"]),
  MRP=Convert.ToString(dr["mrp"]),
     Author =   Convert.ToString(dr["author"]),
                   Category = Convert.ToString(dr["category"]),
                    Publisher= Convert.ToString(dr["publisher"]),
                });
            }
            return iList1;
    
        }

        public bool updatelist(AddBook updata)
        {
            con.Open();
            string qr = "update AddBook set bookname='" + updata.BookName + "',mrp='" + updata.MRP + "'author='" + updata.Author + "',category='" + updata.Category + "',publisher='" + updata.Publisher + "',";
            SqlCommand cmd = new SqlCommand(qr, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)

                return true;
            else
                return false;



        }

    }


}