//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project1
{
    using System;
    using System.Collections.Generic;
    
    public partial class MSBrand
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSBrand()
        {
            this.MSVehicles = new HashSet<MSVehicle>();
        }
    
        public int Id { get; set; }
        public string BrandName { get; set; }
        public bool Status { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public Nullable<System.Guid> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSVehicle> MSVehicles { get; set; }
    }
}
