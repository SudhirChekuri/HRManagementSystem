using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class User
    {


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ILGP76B;Initial Catalog=HRManagement;Integrated Security=True");

        public int RegisterUser(string Username,string EmailId,string Password,string dt,string MId)
        {   
            SqlCommand cmd = new SqlCommand("spEmployeedetails", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UserName", Username);
            cmd.Parameters.AddWithValue("@EmailId", EmailId);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("CreatedTime", dt);
            cmd.Parameters.AddWithValue("@MId",MId);

            SqlParameter outputparameter = new SqlParameter();
            outputparameter.ParameterName = "@Id";
            outputparameter.SqlDbType = System.Data.SqlDbType.Int;
            outputparameter.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(outputparameter);

            con.Open();
            int i= cmd.ExecuteNonQuery();
            con.Close();
            return i;
        
        }
        public int UserLogin(string UserName, string Password)
        {
           string strsql = "select count(*) from tbl_Register where username='"+UserName+"' and password='"+Password+"' and status='A'";
            SqlCommand cmd = new SqlCommand(strsql, con);
            con.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();
            return i;
       }
        public SqlDataReader UserProfile(string Username)
        {
            
            SqlDataReader dr;
            string strsqlGetId = "select Id from Tbl_Register where UserName='" + Username + "'";
            SqlCommand cmdGetId = new SqlCommand(strsqlGetId, con);
            con.Open();
            string Id = (cmdGetId.ExecuteScalar()).ToString();
            con.Close();
             
            string strsql = "select a.Id,a.UserName,a.EmailId,a.MId,b.UserName from  tbl_Register a inner join tbl_Manager b on a.MId=b.MId where Id='" + Id + "'";
            SqlCommand cmd = new SqlCommand(strsql, con);
            con.Open();
            dr = cmd.ExecuteReader();
           
            

            return dr;
        }

        public SqlDataReader UserLeaves(string Username)
        {
            SqlDataReader dr;

            string strsqlGetId = "select Id from Tbl_Register where UserName='" + Username + "'";
            SqlCommand cmdGetId = new SqlCommand(strsqlGetId, con);
            con.Open();
            string Id = (cmdGetId.ExecuteScalar()).ToString();
            con.Close();

            string strsql = "select Id,Fromdate,Todate,Sickleaves,PrivilegeLeaves,MId from tbl_Attendance where Id='" + Id + "'";
            SqlCommand cmd = new SqlCommand(strsql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            return dr;
            
        }
             public int ApplyLeave(string MId,string Id,string Fromdate,string Todate,string Comments,string Status)
        {
            string dt = DateTime.Now.ToString();
            SqlCommand cmd = new SqlCommand("spLeaves", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
           
            cmd.Parameters.AddWithValue("@MId", MId);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Fromdate", Fromdate);
            cmd.Parameters.AddWithValue("@Todate", Todate);
            cmd.Parameters.AddWithValue("@Comments", Comments);
            cmd.Parameters.AddWithValue("@Status", "I");
            


            SqlParameter outputparameter = new SqlParameter();
            outputparameter.ParameterName = "@LId";
            outputparameter.SqlDbType = System.Data.SqlDbType.Int;
            outputparameter.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(outputparameter);

            con.Open();

            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
            
             
        }

        public string DGetEmployeeId(string EUsername)
        {
            string strsqlGetId = "select Id from Tbl_Register where UserName='" + EUsername + "'";
            SqlCommand cmdGetId = new SqlCommand(strsqlGetId, con);
            con.Open();
            string Id = (cmdGetId.ExecuteScalar()).ToString();
            con.Close();

            return Id;
        }

        public SqlDataReader DGetPayslips(string EId)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlCommand cmd = new SqlCommand("select Year,Month,Pdf from tbl_Payslips where Id=" + EId, con);
            if (con.State == ConnectionState.Closed)
            { con.Open(); }
            return cmd.ExecuteReader();
        }
    }
}
