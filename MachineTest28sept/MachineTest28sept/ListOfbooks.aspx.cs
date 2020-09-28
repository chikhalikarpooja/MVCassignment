using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MachineTest28sept
{
    public partial class ListOfbooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string qr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

            SqlConnection cn = new SqlConnection(qr);
            SqlDataAdapter da = new SqlDataAdapter("select * from AddBook", cn);
                       DataSet ds = new DataSet();
                     da.Fill(ds, "AddBook");
            Response.Write("<table width=70% border=1 align=center>");
            Response.Write("<tr>");
            Response.Write("<th>Book Name</th>");
            Response.Write("<th>MRP</th>");
            Response.Write("<th>Book Author</th>");
            Response.Write("<th>Category</th>");
            Response.Write("<th>Publisher</th>");
            Response.Write("<th>Modify</th>");
            Response.Write("</tr>");
            foreach (DataRow dr in ds.Tables["AddBook"].Rows)
            {
                Response.Write("<tr>");
                                          Response.Write("<td>");
                Response.Write(dr["bookname"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["mrp"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["author"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["category"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["publisher"].ToString());
                Response.Write("</td>");
                Response.Write("</tr>");
            }
            Response.Write("</table>");



        }
    }
}