//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEPZA_MEDICAL.DAL.AMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class AMS_AnsarExperience
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Organization1 { get; set; }
        public int OrganizationTypeId { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Responsibility { get; set; }
        public string IUser { get; set; }
        public string EUser { get; set; }
        public System.DateTime IDate { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
        public string Address { get; set; }
        public string Remarks { get; set; }
    
        public virtual AMS_AnsarEmpInfo AMS_AnsarEmpInfo { get; set; }
        public virtual PRM_OrganizationType PRM_OrganizationType { get; set; }
    }
}
