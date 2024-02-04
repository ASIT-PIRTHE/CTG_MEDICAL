//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEPZA_MEDICAL.DAL.FAR
{
    using System;
    using System.Collections.Generic;
    
    public partial class FAR_Catagory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FAR_Catagory()
        {
            this.FAR_SubCategory = new HashSet<FAR_SubCategory>();
            this.FAR_FixedAsset = new HashSet<FAR_FixedAsset>();
        }
    
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
        public decimal MinimumCost { get; set; }
        public int DepreciationMethodId { get; set; }
        public long ReservedIDFrom { get; set; }
        public long ReservedIDTo { get; set; }
        public string Remarks { get; set; }
        public string IUser { get; set; }
        public string EUser { get; set; }
        public System.DateTime IDate { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
    
        public virtual FAR_DepreciationMethod FAR_DepreciationMethod { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAR_SubCategory> FAR_SubCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAR_FixedAsset> FAR_FixedAsset { get; set; }
    }
}