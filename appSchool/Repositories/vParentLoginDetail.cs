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
    
    public partial class vParentLoginDetail
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public string EmailID { get; set; }
        public Nullable<int> SessionID { get; set; }
        public byte CompID { get; set; }
        public byte BranchID { get; set; }
        public int parentLoginID { get; set; }
        public string ParentName { get; set; }
        public string ParentUserName { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string FatherMobileNo { get; set; }
        public string SMSMobileNo { get; set; }
    }
}
