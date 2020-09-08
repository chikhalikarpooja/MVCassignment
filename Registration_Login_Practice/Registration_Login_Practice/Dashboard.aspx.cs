using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_Login_Practice
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
            Response.Redirect("login.aspx");

        }
    }
}