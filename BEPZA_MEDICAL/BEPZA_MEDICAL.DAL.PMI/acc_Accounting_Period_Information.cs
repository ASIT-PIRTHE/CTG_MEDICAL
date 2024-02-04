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
    
    public partial class acc_Accounting_Period_Information
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public acc_Accounting_Period_Information()
        {
            this.PMI_BudgetDetailsYearlyCost = new HashSet<PMI_BudgetDetailsYearlyCost>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> createdUserDate { get; set; }
        public string createdUserId { get; set; }
        public Nullable<System.DateTime> updatedUserDate { get; set; }
        public string updatedUserId { get; set; }
        public bool isActive { get; set; }
        public bool isClosed { get; set; }
        public System.DateTime periodEndDate { get; set; }
        public System.DateTime periodStartDate { get; set; }
        public string yearName { get; set; }
        public int fundControlInformation_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMI_BudgetDetailsYearlyCost> PMI_BudgetDetailsYearlyCost { get; set; }
    }
}
