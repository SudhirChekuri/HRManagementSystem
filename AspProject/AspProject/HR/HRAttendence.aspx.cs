using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace AspProject.HR
{
    public partial class HRAttendence : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["HRManagementConnectionString"].ConnectionString);

        SqlDataReader dr;
        BAL.HR bh = new BAL.HR();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == false)
            {
                Fillgrid();
            }
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
                Calendar2.Visible = false;
            }

        }

        private void Fillgrid()
        {
          
            GridView1.DataSource = bh.BGetAllManagers();
            GridView1.DataBind();

        }


        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int index = Convert.ToInt32(e.CommandArgument.ToString());
            if (index > -1)
            {

                GridViewRow row = (GridViewRow)GridView1.Rows[0];

                GridView2.DataSource = bh.BGetEmployeeDetails(GridView1.Rows[index].Cells[0].Text);
;
                GridView2.DataBind();

                //display mid in label2
                if (e.CommandName == "Select")
                {
                    TextBox6.Text = GridView1.Rows[index].Cells[0].Text;
                }

            }
            else { TextBox6.Text = "No employees available under this manager"; }


        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument.ToString());

            if (e.CommandName == "Select")
            {
                TextBox5.Text = GridView2.Rows[index].Cells[0].Text;
            }


            dr = bh.BGetAttendanceDetails(GridView2.Rows[index].Cells[0].Text);
            ShowData();
            con.Close();


        }
        private void ShowData()
        {
            if (dr.HasRows)
            {
                Button1.Text = "Update Leaves";
                if (dr.Read())
                {

                    TextBox1.Text = dr[0].ToString();
                    TextBox2.Text = dr[1].ToString();
                    TextBox3.Text = dr[2].ToString();
                    TextBox4.Text = dr[3].ToString();
                }

            }
            else
            {
                Button1.Text = "Create Leaves";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Calendar2.Visible = true;

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

            TextBox3.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TextBox4.Text = Calendar2.SelectedDate.ToShortDateString();
            Calendar2.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //TextBox3.Text = Calendar1.SelectedDate.ToShortDateString();
            //TextBox4.Text = Calendar2.SelectedDate.ToShortDateString();

        
           
            int i = bh.BCreateAttendance(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text);
            if (i > 0)
            {
                
                if (Button1.Text == "Update Leaves")
                    lblCreateleave.Text = "Leaves Updated Successfully";
                else
                    lblCreateleave.Text = "Leaves Created Successfully";

            }
        }
    }
}