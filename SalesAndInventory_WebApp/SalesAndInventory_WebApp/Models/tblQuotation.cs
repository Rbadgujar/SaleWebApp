//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCwebInvenotry.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblQuotation
    {
        public int RefNo { get; set; }
        public string PartyName { get; set; }
        public string BillingAddress { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string StateofSupply { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string Tax1 { get; set; }
        public Nullable<double> CGST { get; set; }
        public Nullable<double> SGST { get; set; }
        public Nullable<double> TaxAmount1 { get; set; }
        public Nullable<int> TotalDiscount { get; set; }
        public Nullable<double> DiscountAmount1 { get; set; }
        public Nullable<double> RoundFigure { get; set; }
        public Nullable<double> Total { get; set; }
        public string Feild1 { get; set; }
        public string Feild2 { get; set; }
        public string Feild3 { get; set; }
        public string Feild4 { get; set; }
        public string Feild5 { get; set; }
        public Nullable<int> PartiesID { get; set; }
        public string ContactNo { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> ID { get; set; }
        public string Status { get; set; }
        public string TableName { get; set; }
    
        public virtual tbl_QuotationInner tbl_QuotationInner { get; set; }
        public virtual tbl_QuotationInner tbl_QuotationInner1 { get; set; }
    }
}
