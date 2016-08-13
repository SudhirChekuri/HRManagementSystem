using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class HR
    {
        SqlConnection con = new SqlConnection(@"Data Source=HP;Initial Catalog=HRManagement;User ID=sa;Password=niit");

        public DataTable DGetAllManagers()
        {
            string strsql = "select MId,UserName from tbl_Manager";
            SqlDataAdapter da = new SqlDataAdapter(strsql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_Manager");
            return ds.Tables["tbl_Manager"];
        }

        public DataTable DGetEmployeeDetails(string MId)
        {
            string strsql = "select Id,UserName from tbl_Register where MId='" + MId + "'";
            SqlDataAdapter da = new SqlDataAdapter(strsql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_Register");
            return ds.Tables["tbl_Register"];
        }

        public SqlDataReader DGetAttendanceDetails(string EId)
        {
            string strsql = "select Sickleaves,PrivilegeLeaves,Fromdate,Todate from tbl_Attendance where Id='" + EId + "'";
            SqlCommand cmd = new SqlCommand(strsql, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public int DCreateAttendance(string SickLeaves,string PrivilegeLeaves,string FromDate,string ToDate,string Id,string MId)
        {
            SqlCommand cmd = new SqlCommand("spAttendance", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Sickleaves", SickLeaves);
            cmd.Parameters.AddWithValue("@PrivilegeLeaves", PrivilegeLeaves);
            cmd.Parameters.AddWithValue("@Fromdate", FromDate);
            cmd.Parameters.AddWithValue("@Todate", ToDate);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@MId", MId);
            SqlParameter outputparameter = new SqlParameter();
            outputparameter.ParameterName = "@AId";
            outputparameter.SqlDbType = System.Data.SqlDbType.Int;
            outputparameter.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(outputparameter);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }

        public string DGetManagerId(string MUsername)
        {
            string strsqlGetMId = "select MId from Tbl_Manager where UserName='" + MUsername+ "'";
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
            if(con.State==ConnectionState.Closed)
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
            SqlCommand cmd = new SqlCommand("Update tbl_Register set status='A' where Id='" + EId+ "'", con);
            if (con.State == ConnectionState.Closed)
            { con.Open(); }
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public int GetManager(int MId,string UserName)
        {
        string strsql = "select MId,UserName from tbl_Manager";
            SqlCommand cmd = new SqlCommand(strsql, con);
            con.Open();
           int i= cmd.ExecuteNonQuery();
           return i;
            
        }

        public int GetHrmanagersEmployee(string Id)
        {
         //GridViewRow row = (GridViewRow)GridView1.Rows[0];
                string strsql = "select Id,UserName from tbl_Register where MId='" +Id  + "'";
                SqlCommand cmd= new SqlCommand(strsql, con);
               con.Open();
            int i=cmd.ExecuteNonQuery();
                return i;

    }

        public int UploadPayslip(string Id,string MId,string Year,string Month,string pdf)
        {
            SqlCommand cmd = new SqlCommand("spPayslips", con);
            //    SqlCommand cmd1 = new SqlCommand("select * from tbl_Payslips", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //string savedFileName = Server.MapPath("..//Payslips//" + txtEmpid.Text + "_" + ddlYear.Text + "_" + ddlMonth.Text + ".pdf");

            //FileUpload1.SaveAs(savedFileName);

            cmd.Parameters.AddWithValue("@Id",Id);
            cmd.Parameters.AddWithValue("@MId",MId);
            cmd.Parameters.AddWithValue("@Year",Year);
            cmd.Parameters.AddWithValue("@Month",Month );
            cmd.Parameters.AddWithValue("@Pdf", Id + "_" + Year + "_" + Month + ".Pdf");


            SqlParameter outputparameter = new SqlParameter();
            outputparameter.ParameterName = "@PId";
            outputparameter.SqlDbType = System.Data.SqlDbType.Int;
            outputparameter.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(outputparameter);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }



        public int GetPayslipDetails(string Id)
        {

            string strsql = "select * from tbl_Payslips where Id='" + Id + "'";
            SqlCommand cmd = new SqlCommand(strsql, con);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
    }
}
