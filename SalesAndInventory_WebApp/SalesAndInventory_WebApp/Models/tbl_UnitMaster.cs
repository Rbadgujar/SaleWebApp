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
    
    public partial class tbl_UnitMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_UnitMaster()
        {
            this.tbl_ItemServicemaster = new HashSet<tbl_ItemServicemaster>();
        }
    
        public int UnitID { get; set; }
        public string UnitName { get; set; }
        public string SubUnitName { get; set; }
        public string AdditionalFeild1 { get; set; }
        public string AdditionalFeild2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ItemServicemaster> tbl_ItemServicemaster { get; set; }
    }
}