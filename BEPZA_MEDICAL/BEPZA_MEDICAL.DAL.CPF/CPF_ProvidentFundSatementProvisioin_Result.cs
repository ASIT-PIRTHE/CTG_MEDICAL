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
    
    public partial class CPF_ProvidentFundSatementProvisioin_Result
    {
        public string EmpID { get; set; }
        public string EmployeeInitial { get; set; }
        public string EmployeeName { get; set; }
        public string MembershipID { get; set; }
        public Nullable<decimal> EmployeeOpeningBalance { get; set; }
        public Nullable<decimal> EmployerOpeningBalance { get; set; }
        public Nullable<decimal> EmpContribution { get; set; }
        public Nullable<decimal> ComContribution { get; set; }
        public decimal EmpShareOfProfit { get; set; }
        public decimal ComShareOfProfit { get; set; }
        public decimal EmpWithdrawalAmount { get; set; }
        public decimal ComWithdrawalAmount { get; set; }
        public decimal ComSettlementAmt { get; set; }
        public decimal EmpSettlementAmt { get; set; }
        public decimal ComForfeitedAmount { get; set; }
        public decimal EmpForfeitedAmount { get; set; }
        public decimal LoanAmount { get; set; }
        public Nullable<decimal> LoanRefund { get; set; }
    }
}
