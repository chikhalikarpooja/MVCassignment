using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace MachineTest28sept
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string bname = TextBox1.Text;
            string mrp = TextBox2.Text;
            string author = DropDownList1.Text;
            string cat = DropDownList2.Text;
            string publisher = DropDownList3.Text;
            
            string qr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection cn = new SqlConnection(qr);

            string query = "insert into AddBook values('"+bname+"','"+mrp+"','"+author+"','"+cat+"','"+publisher+"')";
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.ExecuteNonQuery();
            cn.Close();

            TextBox1.Text = "";
            TextBox2.Text = "";

        }
    }
}