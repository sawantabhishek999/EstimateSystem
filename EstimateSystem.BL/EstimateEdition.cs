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
    
    public partial class EstimateEdition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstimateEdition()
        {
            this.EstimateScheduleds = new HashSet<EstimateScheduled>();
        }
    
        public int EST_EditionID { get; set; }
        public int EST_PUBID { get; set; }
        public int EST_ID { get; set; }
        public string Edition { get; set; }
        public decimal Height { get; set; }
        public decimal Weidth { get; set; }
        public decimal Total_Size { get; set; }
        public decimal Rate { get; set; }
        public int NoOfInsertion { get; set; }
        public decimal Total_Cost { get; set; }
        public decimal Agency_Discount { get; set; }
        public decimal Total_NetCost { get; set; }
    
        public virtual EstimateHeader EstimateHeader { get; set; }
        public virtual EstimatePublication EstimatePublication { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstimateScheduled> EstimateScheduleds { get; set; }
    }
}
