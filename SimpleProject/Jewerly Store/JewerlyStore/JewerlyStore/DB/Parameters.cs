//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JewerlyStore.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parameters
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parameters()
        {
            this.Jewelry = new HashSet<Jewelry>();
        }
    
        public int ID { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string Weight { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Jewelry> Jewelry { get; set; }
    }
}
