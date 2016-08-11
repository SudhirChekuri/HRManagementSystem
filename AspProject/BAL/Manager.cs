using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
   public class Manager
    {
        DAL.Manager dm  = new DAL.Manager();

        public string BGetManagerId(string MUsername)
        {
            return dm.DGetManagerId(MUsername);
        }
        public SqlDataReader BGetApprovedEmployees(string MId)
        {
            return dm.DGetApprovedEmployees(MId);
        }

        public SqlDataReader BGetNotApprovedEmployees(string MId)
        {
            return dm.DGetNotApprovedEmployees(MId);
        }
        public int BApproveEmployee(string EId)
        {
            return dm.DApproveEmployee(EId);
        }
    }
}
