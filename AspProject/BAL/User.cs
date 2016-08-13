using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BAL
{
    public class User
    {
        DAL.User du = new DAL.User();

        public int RegisterUser(string Username, string EmailId, string Password, string MId)
        {
            string dt = DateTime.Now.ToString();
            int i = du.RegisterUser(Username, EmailId, Password, dt, MId);

            return i;
        }

        public int UserLogin(string UserName, string Password)
        {
            int i = du.UserLogin(UserName, Password);
            return i;
        }
        public SqlDataReader UserProfile(string Username)
        {

            string dt = DateTime.Now.ToString();
            SqlDataReader dr = du.UserProfile(Username);

            return dr;
        }

        public SqlDataReader UserLeaves(string Username)
        {

            string dt = DateTime.Now.ToString();
              SqlDataReader dr = du.UserLeaves(Username);

            return dr;
        }
        public int ApplyLeave(string MId, string Id, string Fromdate, string Todate, string Comments, string Status)
        {
            string dt = DateTime.Now.ToString();
            int i = du.ApplyLeave(MId,Id,Fromdate,Todate,Comments,Status);

            return i;
        }

        public string BGetEmployeeId(string EUsername)
        {
            return du.DGetEmployeeId(EUsername);
        }
        public SqlDataReader BGetPayslips(string EId)
        {
            return du.DGetPayslips(EId);
        }

    
    }
}
