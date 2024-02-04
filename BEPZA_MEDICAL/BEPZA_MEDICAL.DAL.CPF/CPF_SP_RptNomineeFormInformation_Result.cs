//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEPZA_MEDICAL.DAL.CPF
{
    using System;
    
    public partial class CPF_SP_RptNomineeFormInformation_Result
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string NomineeName { get; set; }
        public string NomineeAddress { get; set; }
        public string Relation { get; set; }
        public Nullable<bool> IsImmatureOrDisable { get; set; }
        public System.DateTime NomineeBirthDate { get; set; }
        public decimal NomineeParcentOfShare { get; set; }
        public Nullable<int> AgeOfNominee { get; set; }
        public string PersonOnBehalfName { get; set; }
        public string PersonOnBehalfAddress { get; set; }
        public Nullable<decimal> PersonOnBehalfShare { get; set; }
        public string PersonOnBehalfSex { get; set; }
        public byte[] NomineePhoto { get; set; }
        public string Witness1Name { get; set; }
        public string Witness1MembershipID { get; set; }
        public string Witness1Designation { get; set; }
        public string Witness1Address { get; set; }
        public byte[] Witness1Signature { get; set; }
        public string Witness2Name { get; set; }
        public string Witness2MembershipID { get; set; }
        public string Witness2Designation { get; set; }
        public string Witness2Address { get; set; }
        public byte[] SignatureofMember { get; set; }
        public byte[] SignatureofSecretary { get; set; }
    }
}