//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEPZA_MEDICAL.DAL.CPF
{
    using System;
    
    public partial class CPF_GetMyCPFLoanApplication_Result
    {
        public int Id { get; set; }
        public string EmpID { get; set; }
        public string FullName { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public System.DateTime ApplyDate { get; set; }
        public decimal ApplyLoanAmount { get; set; }
        public string Purpose { get; set; }
        public int ApplyPrincipalInstallmentNo { get; set; }
        public Nullable<decimal> OwnContribution { get; set; }
        public Nullable<decimal> CompanyContribution { get; set; }
        public decimal GrantedLoanAmount { get; set; }
        public decimal IssuedAmount { get; set; }
        public int GrantedPrincipalInstallmentNo { get; set; }
        public string Section { get; set; }
        public string NationalID { get; set; }
    }
}
