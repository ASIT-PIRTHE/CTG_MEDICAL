//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEPZA_MEDICAL.DAL.FMS
{
    using System;
    
    public partial class SP_FMS_StatementOfFRDInserestEncashmentMonthly_Result
    {
        public string FDRNumber { get; set; }
        public decimal InitialDeposit { get; set; }
        public decimal FDRAmount { get; set; }
        public decimal InterestRate { get; set; }
        public System.DateTime FDRDate { get; set; }
        public System.DateTime MaturityDate { get; set; }
        public decimal TotalInterestAmount { get; set; }
        public Nullable<decimal> DistributedAmount { get; set; }
        public decimal BankCharge { get; set; }
    }
}
