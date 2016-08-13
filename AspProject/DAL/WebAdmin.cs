using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class WebAdmin
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ILGP76B;Initial Catalog=HRManagement;Integrated Security=True");
        

        public int ManagerLogin(string UserName, string Password)
        {
            string strsql = "select * from tbl_Manager where UserName='" + UserName + "' and Password='" + Password + "'";
            SqlCommand cmd = new SqlCommand(strsql, con);
            con.Open();
            int i =Convert.ToInt32(cmd.ExecuteScalar());
            return i;
           
        }

        public int  HRLogin(string UserName, string Password)
        {
            string strsql1 = "select * from tbl_HR where UserName='" +UserName + "' and Password='" + Password + "'";
           
                SqlCommand cmd1 = new SqlCommand(strsql1, con);
                if (con.State == ConnectionState.Closed)
                {
                con.Open();
            }
                int i = Convert.ToInt32(cmd1.ExecuteScalar());
            
            return i;
        }

         public SqlDataReader AdminEmployee()
        {
            string  strsql = "select * from tbl_Register";
            SqlCommand cmd = new SqlCommand(strsql, con);
            con.Open();
             SqlDataReader dr= cmd.ExecuteReader();
             return dr;
           
         }

         public SqlDataReader AdminApproveEmployee()
         {
             string strsql = "select * from tbl_Register where status='I'";
             SqlCommand cmd = new SqlCommand(strsql, con);
             con.Open();
             SqlDataReader dr = cmd.ExecuteReader();
             return dr;

         }

         public SqlDataReader GetAdminManagers()
         {
             SqlCommand cmd1 = new SqlCommand("select * from tbl_Manager", con);
             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             } SqlDataReader dr = cmd1.ExecuteReader();
            // con.Close();
             return dr;
         }

         public int CreateManager(string Username, string Password, string EmailId, string dt)
         {
             SqlCommand cmd = new SqlCommand("spManagerdetails", con);


             cmd.CommandType = System.Data.CommandType.StoredProcedure;

             cmd.Parameters.AddWithValue("@UserName",Username);
             cmd.Parameters.AddWithValue("@Password",Password);
             cmd.Parameters.AddWithValue("@EmailId",EmailId);
             cmd.Parameters.AddWithValue("@CreatedTime", dt);


             SqlParameter outputparameter = new SqlParameter();
             outputparameter.ParameterName = "@Id";
             outputparameter.SqlDbType = System.Data.SqlDbType.Int;
             outputparameter.Direction = System.Data.ParameterDirection.Output;
             cmd.Parameters.Add(outputparameter);

             con.Open();
             int i=cmd.ExecuteNonQuery();
             return i;
         }

         public SqlDataReader GetAdminHR()
         {
             SqlCommand cmd1 = new SqlCommand("select * from tbl_HR", con);
             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             SqlDataReader dr = cmd1.ExecuteReader();
             return dr;
         }

         public int CreateHR(string Username, string Password, string EmailId,string dt)
         {
             SqlCommand cmd = new SqlCommand("spHRdetails", con);


             cmd.CommandType = System.Data.CommandType.StoredProcedure;

             cmd.Parameters.AddWithValue("@UserName", Username);
             cmd.Parameters.AddWithValue("@Password", Password);
             cmd.Parameters.AddWithValue("@EmailId",EmailId);
             cmd.Parameters.AddWithValue("@CreatedTime", dt);


             SqlParameter outputparameter = new SqlParameter();
             outputparameter.ParameterName = "@Id";
             outputparameter.SqlDbType = System.Data.SqlDbType.Int;
             outputparameter.Direction = System.Data.ParameterDirection.Output;
             cmd.Parameters.Add(outputparameter);

             con.Open();

             int i = cmd.ExecuteNonQuery();
             return i;
         }
         public SqlDataReader GetAttendance()
         {
             string strsql = "select * from tbl_Attendance";
             SqlCommand cmd = new SqlCommand(strsql, con);
             con.Open();
             SqlDataReader dr = cmd.ExecuteReader();
             return dr;


         }

         public SqlDataReader Payslips()
         {
             string strsql = "select * from tbl_Attendance";
             SqlCommand cmd = new SqlCommand(strsql, con);
             con.Open();
             SqlDataReader dr = cmd.ExecuteReader();
             return dr;

         }


    }
}
