//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Payslips
    {
        public int PId { get; set; }
        public Nullable<int> Id { get; set; }
        public Nullable<int> MId { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string Pdf { get; set; }
    
        public virtual Tbl_Manager Tbl_Manager { get; set; }
        public virtual tbl_Register tbl_Register { get; set; }
    }
}