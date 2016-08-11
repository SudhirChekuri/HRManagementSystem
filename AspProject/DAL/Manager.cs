using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Manager
    {
        SqlConnection con = new SqlConnection(@"Data Source=WINBC250150-FVJ\SQLEXPRESS;Initial Catalog=HRManagement;Integrated Security=True");

        public string DGetManagerId(string MUsername)
        {
            string strsqlGetMId = "select MId from Tbl_Manager where UserName='" + MUsername + "'";
            SqlCommand cmdGetMId = new SqlCommand(strsqlGetMId, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string MId = (cmdGetMId.ExecuteScalar()).ToString();
            con.Close();
            return MId;
        }

        public SqlDataReader DGetApprovedEmployees(string MId)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string strsql = "select UserName,EmailId from tbl_Register where MId='" + MId + "' AND Status='A'";
            SqlCommand cmd = new SqlCommand(strsql, con);
            if (con.State == ConnectionState.Closed)
            { con.Open(); }

            return cmd.ExecuteReader();

        }

        public SqlDataReader DGetNotApprovedEmployees(string MId)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string strsql = "select Id,UserName,EmailId,Status from tbl_Register where Status='I' and MId='" + MId + "' ";
            SqlCommand cmd = new SqlCommand(strsql, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return cmd.ExecuteReader();
        }

        public int DApproveEmployee(string EId)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlCommand cmd = new SqlCommand("Update tbl_Register set status='A' where Id='" + EId + "'", con);
            if (con.State == ConnectionState.Closed)
            { con.Open(); }
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
