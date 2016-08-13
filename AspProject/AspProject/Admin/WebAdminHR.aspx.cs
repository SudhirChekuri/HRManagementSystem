using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AspProject.Admin
{
    public partial class WebAdminHR : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["HRManagementConnectionString"].ConnectionString);
        BAL.WebAdmin bw = new BAL.WebAdmin();
        int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Fillgrid();
            }
        }
        private void Fillgrid()
        {
            //SqlCommand cmd1 = new SqlCommand("select * from tbl_HR", con);
            //con.Open();
            GridView1.DataSource = bw.GetAdminHR();
            GridView1.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string dt = DateTime.Now.ToString();
           //SqlCommand cmd = new SqlCommand("spHRdetails", con);
            

           // cmd.CommandType = System.Data.CommandType.StoredProcedure;

           // cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
           // cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
           // cmd.Parameters.AddWithValue("@EmailId", txtEmailid.Text);
           // cmd.Parameters.AddWithValue("@CreatedTime", dt);


           // SqlParameter outputparameter = new SqlParameter();
           // outputparameter.ParameterName = "@Id";
           // outputparameter.SqlDbType = System.Data.SqlDbType.Int;
           // outputparameter.Direction = System.Data.ParameterDirection.Output;
           // cmd.Parameters.Add(outputparameter);

           // con.Open();
           
           // int i = cmd.ExecuteNonQuery();
            int i = bw.CreateHR(txtUsername.Text,txtPassword.Text,txtEmailid.Text);
            if (i > 0)
            {
                Label3.Text = "Successfully Registered";
            }
            
            
            Fillgrid();
            txtUsername.Text = "";
            txtEmailid.Text = "";
        }
    }
}