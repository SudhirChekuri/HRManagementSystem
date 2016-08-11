using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AspProject.Managers
{
    public partial class ManagersEmployee : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["HRManagementConnectionString"].ConnectionString);
        BAL.Manager bm = new BAL.Manager();

        protected void Page_Load(object sender, EventArgs e)
        {


            TextBox1.Text = bm.BGetManagerId(Session["UserName"].ToString());


            FillApprovedEmployees();
            
                Fillgrid();
          
           
        }

        public void FillApprovedEmployees()
        {
            GridView1.DataSource = bm.BGetApprovedEmployees(TextBox1.Text);
            GridView1.DataBind();
            con.Close();
        }
        private void Fillgrid()
        {
            
            GridView2.DataSource = bm.BGetNotApprovedEmployees(TextBox1.Text);
            GridView2.DataBind();
            con.Close();
        }

       

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument.ToString());
            string EmployeeId = GridView2.Rows[index].Cells[0].Text;

            int i = bm.BApproveEmployee(EmployeeId);
            
            Fillgrid();
            
        }

        

        
    }
}