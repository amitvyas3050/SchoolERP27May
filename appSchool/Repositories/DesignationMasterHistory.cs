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
    
    public partial class DesignationMasterHistory
    {
        public int ID { get; set; }
        public int DesignationID { get; set; }
        public string DesignationName { get; set; }
        public string DesignationType { get; set; }
        public Nullable<byte> UIDAdd { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public Nullable<byte> UIDMod { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public Nullable<byte> ChangedBy { get; set; }
        public Nullable<System.DateTime> ChangedDate { get; set; }
        public bool IsDeleted { get; set; }
        public byte CompID { get; set; }
        public byte BranchID { get; set; }
    }
}
