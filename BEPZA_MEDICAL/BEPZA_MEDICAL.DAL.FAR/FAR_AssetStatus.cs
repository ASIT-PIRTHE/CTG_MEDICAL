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
    
    public partial class FAR_AssetStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FAR_AssetStatus()
        {
            this.FAR_AssetCondition = new HashSet<FAR_AssetCondition>();
            this.FAR_AssetTransfer = new HashSet<FAR_AssetTransfer>();
            this.FAR_Repair = new HashSet<FAR_Repair>();
            this.FAR_SaleDisposal = new HashSet<FAR_SaleDisposal>();
            this.FAR_FixedAsset = new HashSet<FAR_FixedAsset>();
            this.FAR_DepreciationDetail = new HashSet<FAR_DepreciationDetail>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public string Remarks { get; set; }
        public string IUser { get; set; }
        public System.DateTime IDate { get; set; }
        public string EUser { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAR_AssetCondition> FAR_AssetCondition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAR_AssetTransfer> FAR_AssetTransfer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAR_Repair> FAR_Repair { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAR_SaleDisposal> FAR_SaleDisposal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAR_FixedAsset> FAR_FixedAsset { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAR_DepreciationDetail> FAR_DepreciationDetail { get; set; }
    }
}
