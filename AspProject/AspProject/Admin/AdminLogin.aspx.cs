using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AspProject.Admin
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["HRManagementConnectionString"].ConnectionString);
        
        BAL.WebAdmin bu = new BAL.WebAdmin();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            if (ddlAdmin.SelectedIndex == 0 && txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                Response.Redirect("~/Admin/WebAdminHome.aspx");

            }
            else
            {
                Label1.Text = "Invalid Username/Password";
            }

            //string strsql = "select * from tbl_Manager where UserName='"+txtUsername.Text+"' and Password='"+txtPassword.Text+"'";
            //SqlCommand cmd = new SqlCommand(strsql, con);
            //con.Open();
            //int i =Convert.ToInt32(cmd.ExecuteScalar());

            //con.Close();
            int i = bu.ManagerLogin(txtUsername.Text, txtPassword.Text);
            if (ddlAdmin.SelectedIndex == 2 && i >0)
            {
                Session["UserName"] = txtUsername.Text;
                Session["Password"] = txtPassword.Text;
                Response.Redirect("~/Managers/ManagerHome.aspx");
            }
            else
            {
                Label1.Text = "Invalid username/password";
            }

            //string strsql1 = "select * from tbl_HR where UserName='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'";
            //SqlCommand cmd1 = new SqlCommand(strsql1, con);
            //con.Open();
            //int i = Convert.ToInt32(cmd1.ExecuteScalar());

           
            int j = bu.HRLogin(txtUsername.Text, txtPassword.Text);
            if (ddlAdmin.SelectedIndex == 1 && j > 0)
            {
                Session["UserName"] = txtUsername.Text;
                Session["Password"] = txtPassword.Text;
                Response.Redirect("~/HR/HRHome.aspx");
            }
            else
            {
                Label1.Text = "Invalid username/password";
            }

         
        }
    }
}