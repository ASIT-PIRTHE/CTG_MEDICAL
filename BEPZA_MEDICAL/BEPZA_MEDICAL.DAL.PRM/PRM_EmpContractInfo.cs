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
    
    public partial class PRM_EmpContractInfo
    {
        public PRM_EmpContractInfo()
        {
            this.PRM_EmpContactFiles = new HashSet<PRM_EmpContactFiles>();
        }
    
        public int Id { get; set; }
        public int EmpoyeeId { get; set; }
        public System.DateTime ContractStartDate { get; set; }
        public System.DateTime ContractEndDate { get; set; }
        public string Remarks { get; set; }
        public bool isExtension { get; set; }
        public string IUser { get; set; }
        public string EUser { get; set; }
        public System.DateTime IDate { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
    
        public virtual ICollection<PRM_EmpContactFiles> PRM_EmpContactFiles { get; set; }
        public virtual PRM_EmploymentInfo PRM_EmploymentInfo { get; set; }
    }
}