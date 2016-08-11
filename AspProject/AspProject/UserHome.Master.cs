using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspProject
{
    public partial class UserHome : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                Label2.Text = "Welcome To"+" "+Session["Username"].ToString();
            }
            else
            {
                Response.Redirect("~/User/UserLogin.aspx");
            }
        }

        protected void lblogout_Click(object sender, EventArgs e)
        {
            Session["UserName"] = null;
            Response.Redirect("~/User/UserLogin.aspx");
        }
    }
}