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
    
    public partial class PRM_EmpStatusChange
    {
        public PRM_EmpStatusChange()
        {
            this.PRM_EmpStatusChangeDetail = new HashSet<PRM_EmpStatusChangeDetail>();
        }
    
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Type { get; set; }
        public System.DateTime EffectiveDate { get; set; }
        public int DivisionId { get; set; }
        public int LocationId { get; set; }
        public int FromDesignationId { get; set; }
        public int ToDesignationId { get; set; }
        public int FromGradeId { get; set; }
        public int ToGradeId { get; set; }
        public int FromStepId { get; set; }
        public int ToStepId { get; set; }
        public int FromEmploymentTypeId { get; set; }
        public int ToEmploymentTypeId { get; set; }
        public decimal FromBasicSalary { get; set; }
        public decimal ToBasicSalary { get; set; }
        public decimal FromGrossSalary { get; set; }
        public decimal ToGrossSalary { get; set; }
        public decimal IncrementAmount { get; set; }
        public string IUser { get; set; }
        public string EUser { get; set; }
        public System.DateTime IDate { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
        public Nullable<bool> IsEffective { get; set; }
    
        public virtual PRM_Designation PRM_Designation { get; set; }
        public virtual PRM_Designation PRM_Designation1 { get; set; }
        public virtual PRM_Division PRM_Division { get; set; }
        public virtual PRM_EmploymentType PRM_EmploymentType { get; set; }
        public virtual PRM_EmploymentType PRM_EmploymentType1 { get; set; }
        public virtual PRM_EmpStatusChange PRM_EmpStatusChange1 { get; set; }
        public virtual PRM_EmpStatusChange PRM_EmpStatusChange2 { get; set; }
        public virtual PRM_GradeStep PRM_GradeStep { get; set; }
        public virtual PRM_GradeStep PRM_GradeStep1 { get; set; }
        public virtual PRM_JobLocation PRM_JobLocation { get; set; }
        public virtual ICollection<PRM_EmpStatusChangeDetail> PRM_EmpStatusChangeDetail { get; set; }
        public virtual PRM_EmploymentInfo PRM_EmploymentInfo { get; set; }
        public virtual PRM_JobGrade PRM_JobGrade { get; set; }
        public virtual PRM_JobGrade PRM_JobGrade1 { get; set; }
    }
}