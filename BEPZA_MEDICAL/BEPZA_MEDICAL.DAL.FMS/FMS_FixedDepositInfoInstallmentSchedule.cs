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
    using System.Collections.Generic;
    
    public partial class FMS_FixedDepositInfoInstallmentSchedule
    {
        public int Id { get; set; }
        public int FixedDepositInfoId { get; set; }
        public System.DateTime InsDate { get; set; }
        public decimal InsAmount { get; set; }
        public decimal Tax { get; set; }
        public decimal BankCharge { get; set; }
        public decimal Profit { get; set; }
        public string IUser { get; set; }
        public System.DateTime IDate { get; set; }
        public string EUser { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
    
        public virtual FMS_FixedDepositInfo FMS_FixedDepositInfo { get; set; }
    }
}