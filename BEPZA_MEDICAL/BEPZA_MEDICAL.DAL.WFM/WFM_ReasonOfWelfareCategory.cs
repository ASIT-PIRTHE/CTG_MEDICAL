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
    
    public partial class WFM_ReasonOfWelfareCategory
    {
        public int Id { get; set; }
        public int WelfareFundCategoryId { get; set; }
        public string Reason { get; set; }
        public string IUser { get; set; }
        public System.DateTime IDate { get; set; }
        public string EUser { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
    
        public virtual WFM_WelfareFundCategory WFM_WelfareFundCategory { get; set; }
    }
}