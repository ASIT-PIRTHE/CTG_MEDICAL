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
    
    public partial class PRM_JobVacancyDetails
    {
        public int Id { get; set; }
        public int JobVacancyId { get; set; }
        public int JobGradeId { get; set; }
        public int NoOfPost { get; set; }
        public string IUser { get; set; }
        public string EUser { get; set; }
        public System.DateTime IDate { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
    
        public virtual PRM_JobVacancy PRM_JobVacancy { get; set; }
        public virtual PRM_JobGrade PRM_JobGrade { get; set; }
    }
}