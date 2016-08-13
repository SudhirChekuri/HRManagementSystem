using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AspProject.Admin
{
    public partial class WebAdminManager : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["HRManagementConnectionString"].ConnectionString);
        BAL.WebAdmin bw = new BAL.WebAdmin();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Fillgrid();
            }
        }
        private void Fillgrid()
        {
            //SqlCommand cmd1 = new SqlCommand("select * from tbl_Manager", con);
            //con.Open();
            GridView1.DataSource = bw.GetAdminManagers();
            GridView1.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string dt = DateTime.Now.ToString();
            int i = bw.CreateManager(txtUsername.Text, txtPassword.Text, txtEmailid.Text);
            //SqlCommand cmd = new SqlCommand("spManagerdetails", con);
            

            //cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
            //cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            //cmd.Parameters.AddWithValue("@EmailId", txtEmailid.Text);
            //cmd.Parameters.AddWithValue("@CreatedTime", dt);


            //SqlParameter outputparameter = new SqlParameter();
            //outputparameter.ParameterName = "@Id";
            //outputparameter.SqlDbType = System.Data.SqlDbType.Int;
            //outputparameter.Direction = System.Data.ParameterDirection.Output;
            //cmd.Parameters.Add(outputparameter);

            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
            Fillgrid();
            txtUsername.Text = "";
            txtEmailid.Text = "";
        }
    }
}