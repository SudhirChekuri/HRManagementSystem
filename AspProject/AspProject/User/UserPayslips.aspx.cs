using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace AspProject.User
{
    public partial class UserPayslips : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["HRManagementConnectionString"].ConnectionString);
        BAL.User bu = new BAL.User();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            { 
                TextBox1.Text = bu.BGetEmployeeId(Session["UserName"].ToString());
                if (IsPostBack == false)
                {
                    Fillgrid();
                }
            }
            else { Response.Redirect("~/User/UserLogin.aspx"); }

        }

        private void Fillgrid()
        {
            GridView1.DataSource = bu.BGetPayslips(TextBox1.Text);
            GridView1.DataBind();
           
        }
    }
}