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
    
    public partial class tbl_CreditNoteInner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CreditNoteInner()
        {
            this.tbl_CreditNote1 = new HashSet<tbl_CreditNote1>();
            this.tbl_CreditNote11 = new HashSet<tbl_CreditNote1>();
            this.tbl_DebitNote = new HashSet<tbl_DebitNote>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public string ItemName { get; set; }
        public string BasicUnit { get; set; }
        public string ItemCode { get; set; }
        public Nullable<double> SalePrice { get; set; }
        public string TaxForSale { get; set; }
        public Nullable<double> SaleTaxAmount { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<int> freeQty { get; set; }
        public string Discount { get; set; }
        public Nullable<double> DiscountAmount { get; set; }
        public Nullable<int> ItemAmount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CreditNote1> tbl_CreditNote1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CreditNote1> tbl_CreditNote11 { get; set; }
        public virtual tbl_ItemMaster tbl_ItemMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DebitNote> tbl_DebitNote { get; set; }
    }
}
