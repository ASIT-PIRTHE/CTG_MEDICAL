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
    
    public partial class vwEmpForAnnualIncrement
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeInitial { get; set; }
        public string FullName { get; set; }
        public int DesignationId { get; set; }
        public string DesignationName { get; set; }
        public string DivisionName { get; set; }
        public int DivisionId { get; set; }
        public System.DateTime JoiningDate { get; set; }
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public int StepId { get; set; }
        public int StepName { get; set; }
        public string HeadName { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime EffectiveDate { get; set; }
        public Nullable<System.DateTime> NextIncrementDate { get; set; }
        public string EmploymentType { get; set; }
        public int EmploymentTypeId { get; set; }
        public string EmpID { get; set; }
        public Nullable<System.DateTime> NextPositionDate { get; set; }
    }
}