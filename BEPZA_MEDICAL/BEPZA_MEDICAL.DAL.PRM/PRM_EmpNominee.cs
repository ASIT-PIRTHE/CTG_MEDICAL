//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOM_MPA.DAL.PRM
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRM_EmpNominee
    {
        public PRM_EmpNominee()
        {
            this.PRM_EmpNomineeDetail = new HashSet<PRM_EmpNomineeDetail>();
        }
    
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int NomineeForId { get; set; }
        public string IUser { get; set; }
        public string EUser { get; set; }
        public System.DateTime IDate { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
    
        public virtual PRM_NomineeFor PRM_NomineeFor { get; set; }
        public virtual ICollection<PRM_EmpNomineeDetail> PRM_EmpNomineeDetail { get; set; }
        public virtual PRM_EmploymentInfo PRM_EmploymentInfo { get; set; }
    }
}