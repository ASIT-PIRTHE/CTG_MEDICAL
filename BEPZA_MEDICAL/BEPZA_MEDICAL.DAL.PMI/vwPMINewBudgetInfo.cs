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
    
    public partial class vwPMINewBudgetInfo
    {
        public int Id { get; set; }
        public string yearName { get; set; }
        public string Status { get; set; }
        public string BudgetType { get; set; }
        public Nullable<int> ZoneId { get; set; }
        public Nullable<int> ProjectForId { get; set; }
    }
}
