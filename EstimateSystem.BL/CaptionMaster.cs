//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstimateSystem.BL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CaptionMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CaptionMaster()
        {
            this.EstimateScheduleds = new HashSet<EstimateScheduled>();
        }
    
        public int CaptionID { get; set; }
        public string Caption { get; set; }
        public int BrandID { get; set; }
    
        public virtual BrandMaster BrandMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstimateScheduled> EstimateScheduleds { get; set; }
    }
}
