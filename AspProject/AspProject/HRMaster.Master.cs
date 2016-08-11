using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspProject
{
    public partial class HRMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                Label1.Text = "Welcome To"+" "+Session["UserName"].ToString();
            }
            else
            {
                Response.Redirect("~/HR/HRHome.aspx");
            }
        }
    }
}