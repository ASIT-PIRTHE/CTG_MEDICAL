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
    
    public partial class vwAccademicQlfy
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int DegreeLevelId { get; set; }
        public int SubjectGroupId { get; set; }
        public int AcademicGradeId { get; set; }
        public Nullable<decimal> CGPA { get; set; }
        public Nullable<decimal> Scale { get; set; }
        public int AcademicInstituteId { get; set; }
        public int YearOfPassing { get; set; }
        public Nullable<decimal> ObtainMarks { get; set; }
        public Nullable<decimal> DegreeDuration { get; set; }
        public int DegreeCountryId { get; set; }
        public string MajorSubject { get; set; }
        public string Board { get; set; }
        public string SpecialAchievement { get; set; }
        public string IUser { get; set; }
        public string EUser { get; set; }
        public System.DateTime IDate { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
        public string ExamLevel { get; set; }
        public string SubjectGroup { get; set; }
        public string Result { get; set; }
        public string Institute { get; set; }
        public string Country { get; set; }
    }
}
