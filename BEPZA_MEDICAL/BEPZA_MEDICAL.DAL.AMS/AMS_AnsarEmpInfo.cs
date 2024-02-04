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
    
    public partial class AMS_AnsarEmpInfo
    {
        public AMS_AnsarEmpInfo()
        {
            this.AMS_AnsarDegree = new HashSet<AMS_AnsarDegree>();
            this.AMS_AnsarPhoto = new HashSet<AMS_AnsarPhoto>();
            this.AMS_AnsarExperience = new HashSet<AMS_AnsarExperience>();
            this.AMS_Blacklist = new HashSet<AMS_Blacklist>();
            this.AMS_AnsarPersonalInfo = new HashSet<AMS_AnsarPersonalInfo>();
            this.AMS_AnsarServiceHistory = new HashSet<AMS_AnsarServiceHistory>();
        }
    
        public int Id { get; set; }
        public string BEPZAId { get; set; }
        public string AnsarId { get; set; }
        public Nullable<int> TitleId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string FullNameBangla { get; set; }
        public Nullable<int> DesignationId { get; set; }
        public Nullable<System.DateTime> DateofBirth { get; set; }
        public Nullable<System.DateTime> AnsarJoiningDate { get; set; }
        public System.DateTime DateofJoining { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public string Gender { get; set; }
        public Nullable<int> ReligionId { get; set; }
        public int StatusId { get; set; }
        public Nullable<System.DateTime> InactiveDate { get; set; }
        public string MobileNo { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public string IUser { get; set; }
        public System.DateTime IDate { get; set; }
        public string EUser { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
        public int ZoneInfoId { get; set; }
        public bool IsFinalized { get; set; }
        public int CategoryId { get; set; }
    
        public virtual ICollection<AMS_AnsarDegree> AMS_AnsarDegree { get; set; }
        public virtual AMS_DesignationInfo AMS_DesignationInfo { get; set; }
        public virtual AMS_EmpStatus AMS_EmpStatus { get; set; }
        public virtual PRM_ZoneInfo PRM_ZoneInfo { get; set; }
        public virtual ICollection<AMS_AnsarPhoto> AMS_AnsarPhoto { get; set; }
        public virtual ICollection<AMS_AnsarExperience> AMS_AnsarExperience { get; set; }
        public virtual AMS_Category AMS_Category { get; set; }
        public virtual ICollection<AMS_Blacklist> AMS_Blacklist { get; set; }
        public virtual ICollection<AMS_AnsarPersonalInfo> AMS_AnsarPersonalInfo { get; set; }
        public virtual ICollection<AMS_AnsarServiceHistory> AMS_AnsarServiceHistory { get; set; }
    }
}
