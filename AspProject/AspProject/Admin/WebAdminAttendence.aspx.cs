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
    public partial class WebAdminAttendence : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["HRManagementConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            string strsql = "select * from tbl_Attendance";
            SqlCommand cmd = new SqlCommand(strsql, con);
            con.Open();

            grdattendence.DataSource = cmd.ExecuteReader();
            grdattendence.DataBind();
            con.Close();
        }
    }
}