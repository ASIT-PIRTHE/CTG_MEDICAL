//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEPZA_MEDICAL.DAL.WFM
{
    using System;
    using System.Collections.Generic;
    
    public partial class WFM_PaymentInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WFM_PaymentInfo()
        {
            this.WFM_PaymentInfoEmployeeDetails = new HashSet<WFM_PaymentInfoEmployeeDetails>();
        }
    
        public int Id { get; set; }
        public int ZoneInfoId { get; set; }
        public int ApprovalWelfareFundInfoId { get; set; }
        public string PayOrderNo { get; set; }
        public System.DateTime PayOrderDate { get; set; }
        public string Comments { get; set; }
        public string IUser { get; set; }
        public System.DateTime IDate { get; set; }
        public string EUser { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFM_PaymentInfoEmployeeDetails> WFM_PaymentInfoEmployeeDetails { get; set; }
        public virtual WFM_ApprovalWelfareFundInfo WFM_ApprovalWelfareFundInfo { get; set; }
    }
}