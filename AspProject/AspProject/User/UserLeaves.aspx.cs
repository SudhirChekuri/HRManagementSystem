using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Data.SqlClient;


namespace AspProject.User
{
    public partial class UserLeaves : System.Web.UI.Page
    {
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                //txtEmployeeid.Text = Session["UserName"].ToString();
                //SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=HRManagement;User ID=sa;Password=niit");
                //string strsqlGetId = "select Id from Tbl_Register where UserName='" + Session["UserName"].ToString() + "'";
                //SqlCommand cmdGetId = new SqlCommand(strsqlGetId, con);
                //con.Open();
                //string Id = (cmdGetId.ExecuteScalar()).ToString();
                //con.Close();
                //txtEmployeeid.Text = Id;
                //string strsql ="select Fromdate,Todate,Sickleaves,Prevelizedleaves,MId from tbl_Attendence where Id='" + txtEmployeeid.Text + "'";
                //SqlCommand cmd = new SqlCommand(strsql, con);
                //con.Open();
                //dr = cmd.ExecuteReader();
                //ShowData();
                //con.Close();
                ////SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=HRManagement;User ID=sa;Password=niit");
                ////string strsql = "select MId,Fromdate,Todate,Sickleaves,Prevelizedleaves from tbl_Attendence";
                ////SqlCommand cmd = new SqlCommand(strsql, con);
                ////con.Open();
                ////dr = cmd.ExecuteReader();
                ShowData();
                ////con.Close();
            }
            else { Response.Redirect("~/User/UserLogin.aspx"); }

        }

        private void ShowData()
        {
            BAL.User bu = new BAL.User();
            dr = bu.UserLeaves(Session["UserName"].ToString());
            if (dr.Read())
            {

                txtEmployeeid.Text = dr[0].ToString();
                txtFromdate.Text = dr[1].ToString();
                txtTodate.Text = dr[2].ToString();
                txtSickleaves.Text = dr[3].ToString();
                txtPrevilizedleaves.Text = dr[4].ToString();
                txtManagerid.Text = dr[5].ToString();
               
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            


            BAL.User bu = new BAL.User();
            int i = bu.ApplyLeave(txtManagerid.Text, txtEmployeeid.Text, txtFrmdate.Text, txtTdate.Text, txtCmments.Text,"I");
            if (i > 0)
            {
                Label3.Text = "Successfully Registered";

                
            }
            else
            {
                Label3.Text = "Failed to register";
            }
            
           
        
        }

        protected void imageFrm_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void ImagebtnTo_Click(object sender, ImageClickEventArgs e)
        {
            Calendar2.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtFrmdate.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            txtTdate.Text = Calendar2.SelectedDate.ToShortDateString();
            Calendar2.Visible = false;
        }

        
    }
    }
