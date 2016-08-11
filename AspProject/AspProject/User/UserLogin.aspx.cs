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
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=HRManagement;User ID=sa;Password=niit");
            //string strsql = "select * from tbl_Register where UserName='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "' and Status='A'";
            //SqlCommand cmd = new SqlCommand(strsql, con);
            //con.Open();
            //int i = Convert.ToInt32(cmd.ExecuteScalar());

            //con.Close();
            BAL.User bu = new BAL.User();
            int i = bu.UserLogin(txtUsername.Text, txtPassword.Text);
            if (i > 0)
            {
                Session["UserName"] = txtUsername.Text;
           //     Session["Password"] = txtPassword.Text;
                Response.Redirect("~/User/UserHome.aspx");
            }
            else
            {

                Label1.Text = "inavalid username/password";
            }
        }
    }
}