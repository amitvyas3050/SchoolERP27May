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
    
    public partial class GradeMaster
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }
        public Nullable<decimal> PFrom { get; set; }
        public Nullable<decimal> PTo { get; set; }
        public string Remark { get; set; }
        public Nullable<int> Rank { get; set; }
        public Nullable<decimal> GradePoint { get; set; }
        public Nullable<byte> UIDAdd { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public Nullable<byte> UIDMod { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public byte BranchID { get; set; }
        public byte CompID { get; set; }
    }
}
