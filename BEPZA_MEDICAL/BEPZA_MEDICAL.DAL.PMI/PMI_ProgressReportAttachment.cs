//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEPZA_MEDICAL.DAL.PMI
{
    using System;
    using System.Collections.Generic;
    
    public partial class PMI_ProgressReportAttachment
    {
        public int Id { get; set; }
        public int ProgressReportId { get; set; }
        public Nullable<System.DateTime> PreviousDate { get; set; }
        public Nullable<System.DateTime> CurrentDate { get; set; }
        public string PreviousFileName { get; set; }
        public string CurrentFileName { get; set; }
        public byte[] PreviousAttachment { get; set; }
        public byte[] CurrentAttachment { get; set; }
        public string NameofWork { get; set; }
    
        public virtual PMI_ProgressReportMaster PMI_ProgressReportMaster { get; set; }
    }
}
