//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEPZA_MEDICAL.DAL.PMI
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwPMIEstimation
    {
        public int Id { get; set; }
        public int EstimationDetailId { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int EstimationItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount { get; set; }
        public Nullable<int> ZoneId { get; set; }
        public string ZoneCode { get; set; }
        public decimal EstimatedCost { get; set; }
        public System.DateTime EstimationDate { get; set; }
    }
}