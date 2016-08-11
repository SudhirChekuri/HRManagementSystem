using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AspProject.User
{
    public partial class UserProfile : System.Web.UI.Page
    {
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                txtUsername.Text = Session["Username"].ToString();
            //SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=HRManagement;User ID=sa;Password=niit");
            //string strsqlGetId = "select Id from Tbl_Register where UserName='" + Session["UserName"].ToString() + "'";
            //SqlCommand cmdGetId = new SqlCommand(strsqlGetId, con);
            //con.Open();
            //string Id = (cmdGetId.ExecuteScalar()).ToString();
            //con.Close();
            //txtEmployeeid.Text = Id;
            //string strsql = "select a.UserName,a.EmailId,a.MId,b.UserName from  tbl_Register a inner join tbl_Manager b on a.MId=b.MId where Id='"+txtEmployeeid.Text+"'";
            //SqlCommand cmd = new SqlCommand(strsql, con);
            //con.Open();
            //dr = cmd.ExecuteReader();
            ShowData();
                //con.Close();
            }
            else { Response.Redirect("~/User/UserLogin.aspx"); }

        }
        private void ShowData()
        {
            BAL.User bu = new BAL.User();
           
             dr = bu.UserProfile(txtUsername.Text);
            if (dr.Read())
            {
               txtEmployeeid.Text = dr[0].ToString();
                txtUsername.Text = dr[1].ToString();
                txtEmailid.Text = dr[2].ToString();
                txtManagerid.Text = dr[3].ToString();
                txtManagername.Text = dr[4].ToString();
            }
        }
    }
}
