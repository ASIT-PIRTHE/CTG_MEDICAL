//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOM_MPA.DAL.PRM
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwEmpPublication
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string PublicationName { get; set; }
        public string SerialNo { get; set; }
        public string PublicationArea { get; set; }
        public string JournalName { get; set; }
        public Nullable<System.DateTime> PublicationDate { get; set; }
    }
}
