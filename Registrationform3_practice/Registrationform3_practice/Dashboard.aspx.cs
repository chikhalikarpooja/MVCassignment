using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Registrationform3_practice
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["email"].ToString();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["email"] = "";
            Session.Abandon();
            Session.RemoveAll();
            Response.Redirect("Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string qr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection cn = new SqlConnection(qr);
            string qr1 = "select fullname , dob, phonenumber,gender,address,qualification,occupation from EmpReg_Practice";
            cn.Open();
            SqlCommand cmd = new SqlCommand(qr1, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            cn.Close();
        }
    }
}