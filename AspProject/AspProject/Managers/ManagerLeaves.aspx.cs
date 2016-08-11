using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AspProject.Managers
{
    public partial class ManagerLeaves : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["HRManagementConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

            string strsqlGetMId = "select MId from Tbl_Manager where UserName='" + Session["UserName"].ToString() + "'";
            SqlCommand cmdGetMId = new SqlCommand(strsqlGetMId, con);
            con.Open();
            string MId = (cmdGetMId.ExecuteScalar()).ToString();
            con.Close();
            txtManagerid.Text = MId;
            if (IsPostBack == false)
            {
                Fillgrid();
            }

        }
        private void Fillgrid()
        {
            SqlCommand cmd1 = new SqlCommand("select Id,Fromdate,Todate,Status from tbl_leaves where Status='I' and MId='"+txtManagerid.Text+"'", con);
            con.Open();
            GridView1.DataSource = cmd1.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument.ToString());
            string EmployeeId = GridView1.Rows[index].Cells[0].Text;
            SqlCommand cmd = new SqlCommand("Update tbl_leaves set status='A' where Id='" + EmployeeId + "'", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            Fillgrid();
        }
    }
}