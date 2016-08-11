using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace AspProject.HR
{
    public partial class HRPayslips : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["HRManagementConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Fillgrid();
                ddlyear();
                ddlmonth();
            }
           
        }

        private void ddlyear()
        {
            int currentYear = DateTime.Now.Year;
            for (int i = 2000; i <= currentYear; i++)
            {
                // string date = DateTime.Now.AddYears(i).ToString();
                ddlYear.Items.Add(i.ToString());
                //DropDownList1.Items.FindByValue(System.DateTime.Now.Year.ToString()).Selected = true;
            }

        }
        private void ddlmonth()
        {
            for (int i = 1; i <= 12; i++)
            {
                ddlMonth.Items.Add(i.ToString());
            }

        }
        private void Fillgrid()
        {
            string strsql = "select MId,UserName from tbl_Manager";
            SqlDataAdapter da = new SqlDataAdapter(strsql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_Manager");
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument.ToString());
            if (index > -1)
            {

                GridViewRow row = (GridViewRow)GridView1.Rows[0];
                string strsql = "select Id,UserName from tbl_Register where MId='" + GridView1.Rows[index].Cells[0].Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(strsql, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tbl_Register");
                GridView2.DataSource = ds;
                GridView2.DataBind();

                //display mid in label2
                if (e.CommandName == "Select")
                {
                    txtMId.Text= GridView1.Rows[index].Cells[0].Text;
                }

            }
            else {txtMId.Text = "No employees available under this manager"; }

        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument.ToString());
            if (e.CommandName == "Select")
            {
                txtEmpid.Text = GridView2.Rows[index].Cells[0].Text;
            }

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
           SqlCommand cmd = new SqlCommand("spPayslips", con);
        //    SqlCommand cmd1 = new SqlCommand("select * from tbl_Payslips", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            string savedFileName = Server.MapPath("..//Payslips//" +txtEmpid.Text + "_" + ddlYear.Text + "_" + ddlMonth.Text + ".pdf");

            FileUpload1.SaveAs(savedFileName);

            cmd.Parameters.AddWithValue("@Id", txtEmpid.Text);
            cmd.Parameters.AddWithValue("@MId", txtMId.Text);
            cmd.Parameters.AddWithValue("@Year",ddlYear.Text);
            cmd.Parameters.AddWithValue("@Month",ddlMonth.Text);
            cmd.Parameters.AddWithValue("@Pdf", txtEmpid.Text + "_" + ddlYear.Text + "_" + ddlMonth.Text + ".Pdf");


            SqlParameter outputparameter = new SqlParameter();
            outputparameter.ParameterName = "@PId";
            outputparameter.SqlDbType = System.Data.SqlDbType.Int;
            outputparameter.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(outputparameter);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                Label1.Text = "Successfully Uploaded";
                Fillgrid();
            }

            //GridView3.DataSource = cmd1.ExecuteReader();
            //GridView3.DataBind();
          

            //save file in Payslips folder

           


        //    txtMId.Text = "";
          //  txtEmpid.Text = "";
           // ddlYear.Text = "";
           // ddlMonth.Text = "";
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Id"] = txtEmpid.Text;
            string strsql = "select * from tbl_Payslips where Id='" +txtEmpid.Text + "'";
            SqlCommand cmd = new SqlCommand(strsql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_Payslips");
            GridView3.DataSource = ds;
            GridView3.DataBind();
        }
    }
}