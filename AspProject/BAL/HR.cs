using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BAL
{
    public class HR
    {
        SqlConnection con = new SqlConnection(@"Data Source=WINBC250150-FVJ\SQLEXPRESS;Initial Catalog=HRManagement;Integrated Security=True");
        DAL.HR dh = new DAL.HR();
        public DataTable BGetAllManagers()
        {

            return dh.DGetAllManagers();
        }

        public DataTable BGetEmployeeDetails(string MId)
        {

            return dh.DGetEmployeeDetails(MId);
        }

        public SqlDataReader BGetAttendanceDetails(string EId)
        {
            return dh.DGetAttendanceDetails(EId);
        }

        public int BCreateAttendance(string SickLeaves, string PrivilegeLeaves, string FromDate, string ToDate, string Id, string MId)
        {

            return dh.DCreateAttendance(SickLeaves, PrivilegeLeaves, FromDate, ToDate, Id, MId);

        }


    }
}
