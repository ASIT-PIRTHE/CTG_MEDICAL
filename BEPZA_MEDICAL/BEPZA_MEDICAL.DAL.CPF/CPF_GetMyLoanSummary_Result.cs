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
    
    public partial class CPF_GetMyLoanSummary_Result
    {
        public int EmployeeId { get; set; }
        public int LoanId { get; set; }
        public string LoanNo { get; set; }
        public System.DateTime LoanDate { get; set; }
        public decimal LoanAmount { get; set; }
        public int GrantedPrincipalInstallmentNo { get; set; }
        public int GrantedInterestInstallmentNo { get; set; }
        public decimal Installment { get; set; }
        public decimal Interest { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public int NoOfPrincipalPaid { get; set; }
        public int NoOfInterestPaid { get; set; }
        public decimal InterestRate { get; set; }
        public string EmpID { get; set; }
        public string FullName { get; set; }
        public string MembershipID { get; set; }
        public Nullable<decimal> MembershipLength { get; set; }
    }
}