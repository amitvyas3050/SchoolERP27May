//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace appSchool.Repositories
{
    using System;
    using System.Collections.Generic;
    
    public partial class vTotalFeesReminder
    {
        public Nullable<decimal> FeesAmount { get; set; }
        public Nullable<decimal> Fine { get; set; }
        public Nullable<int> StudentID { get; set; }
        public string FullName { get; set; }
        public string SMSMobileNo { get; set; }
        public bool SMSInHindi { get; set; }
        public string ClassDescription { get; set; }
        public string FeeTermName { get; set; }
        public string FeeTermType { get; set; }
        public byte BranchID { get; set; }
        public byte CompID { get; set; }
        public int FeeTermID { get; set; }
    }
}
