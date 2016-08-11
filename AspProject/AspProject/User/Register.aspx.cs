using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AspProject.User
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BAL.User bu = new BAL.User();
         int i=   bu.RegisterUser(txtUsername.Text, txtPassword.Text, txtEmailid.Text,txtMid.Text);
         if (i > 0)
         {
             Label1.Text = "Successfully Registered";

             txtUsername.Text = "";
             txtEmailid.Text = "";
             txtMid.Text = "";
         }
         else {
             Label1.Text = "Failed to register";
         }

        }
    }
}