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
                // // Session["UserName"] = txtEmployeeid.Text;
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
                ////ShowData();
                ////con.Close();
            }
            else { Response.Redirect("~/User/UserLogin.aspx"); }

        }

        private void ShowData()
        {
            if (dr.Read())
            {
                
               
                txtFromdate.Text = dr[0].ToString();
                txtTodate.Text = dr[1].ToString();
                txtSickleaves.Text = dr[2].ToString();
                txtPrevilizedleaves.Text = dr[3].ToString();
                txtManagerid.Text = dr[4].ToString();
               
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //string dt = DateTime.Now.ToString();
            //SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=HRManagement;User ID=sa;Password=niit");
            //SqlCommand cmd = new SqlCommand("spLeaves", con);
            //SqlCommand cmd1 = new SqlCommand("select * from tbl_leaves where Id="+txtEmployeeid.Text, con);

            //cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@Id",txtEmployeeid.Text);
            //cmd.Parameters.AddWithValue("@Fromdate",txtFrmdate.Text);
            //cmd.Parameters.AddWithValue("@Todate",txtTdate.Text);
            //cmd.Parameters.AddWithValue("@Comments",txtCmments.Text);
            //cmd.Parameters.AddWithValue("@Status","I");
            //cmd.Parameters.AddWithValue("@MId",txtManagerid.Text);


            //SqlParameter outputparameter = new SqlParameter();
            //outputparameter.ParameterName = "@LId";
            //outputparameter.SqlDbType = System.Data.SqlDbType.Int;
            //outputparameter.Direction = System.Data.ParameterDirection.Output;
            //cmd.Parameters.Add(outputparameter);

            //con.Open();

            //int i = cmd.ExecuteNonQuery();
            //if (i > 0)
            //{
            //    Label3.Text = "Successfully Registered";
            //}
            //GridView1.DataSource = cmd1.ExecuteReader();
            //GridView1.DataBind();
            //con.Close();
           
        
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
