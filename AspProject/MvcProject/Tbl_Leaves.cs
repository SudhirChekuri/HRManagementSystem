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
    
    public partial class Tbl_Leaves
    {
        public int Lid { get; set; }
        public Nullable<int> Mid { get; set; }
        public Nullable<int> Id { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string Comments { get; set; }
        public string Status { get; set; }
    
        public virtual tbl_Register tbl_Register { get; set; }
        public virtual Tbl_Manager Tbl_Manager { get; set; }
    }
}
