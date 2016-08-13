using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BAL
{
    public class WebAdmin
    {
        DAL.WebAdmin du=new DAL.WebAdmin();
        public int AdminLogin(string UserName, string Password)
        {
            if (UserName == "admin" && Password == "admin")
            {

                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int HRLogin(string UserName, string Password)
        {
            int i = du.HRLogin(UserName, Password);
            return i;
        }

        public int ManagerLogin(string UserName, string Password)
        {
            int i = du.ManagerLogin(UserName, Password);
            return i;
        }

        public SqlDataReader AdminEmployee()
        {
            return du.AdminEmployee();
        }

        public SqlDataReader AdminApproveEmployee()
        {
            return du.AdminApproveEmployee();
        }

        public SqlDataReader GetAdminManagers()
        {
            return du.GetAdminManagers();
        }

        public int CreateManager(string Username, string Password, string EmailId)
        {
            string dt = DateTime.Now.ToString();
            int i = du.CreateManager(Username, Password, EmailId, dt);

            return i;
        }

        public SqlDataReader GetAdminHR()
        {
            return du.GetAdminHR();
        }

        public int CreateHR(string Username, string Password, string EmailId)
        {
            string dt = DateTime.Now.ToString();
            int i = du.CreateHR(Username, Password, EmailId, dt);

            return i;
        }

        public SqlDataReader GetAttendance()
        {
            return du.GetAttendance();
        }

        public SqlDataReader Payslips()
        {
            return du.Payslips();
        }
    }
}
