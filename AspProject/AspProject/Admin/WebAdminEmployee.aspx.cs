﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AspProject.Admin
{
    public partial class WebAdminEmployee : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["HRManagementConnectionString"].ConnectionString);
        BAL.WebAdmin bw = new BAL.WebAdmin();
        string strsql;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            //strsql = "select * from tbl_Register";
            //SqlCommand cmd = new SqlCommand(strsql, con);
            //con.Open();

            GrdViewemp.DataSource = bw.AdminEmployee();
           GrdViewemp.DataBind();
           

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //strsql = "select * from tbl_Register where status='I'";
            //SqlCommand cmd = new SqlCommand(strsql, con);
            //con.Open();

            GrdNotAproved.DataSource = bw.AdminApproveEmployee();

            GrdNotAproved.DataBind();
        }
    }
}