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
    
    public partial class FAR_AdditionalInfoofVehicleDetail
    {
        public int Id { get; set; }
        public int AdditionalInfoofVehicleId { get; set; }
        public int SparePartInfoId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string IUser { get; set; }
        public string EUser { get; set; }
        public System.DateTime IDate { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
    
        public virtual FAR_AdditionalInfoofVehicle FAR_AdditionalInfoofVehicle { get; set; }
        public virtual FAR_SparePartInformation FAR_SparePartInformation { get; set; }
    }
}