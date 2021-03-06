//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hpapp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Polyclinic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Polyclinic()
        {
            this.Employee = new HashSet<Employee>();
            this.Patient = new HashSet<Patient>();
            this.PolyclinicDistrict = new HashSet<PolyclinicDistrict>();
        }
    
        public int ID { get; set; }
        public string NumberPolyclinic { get; set; }
        public string AddressPolyclinic { get; set; }
        public System.DateTime ReportingYear { get; set; }
        public int NSWHE { get; set; }
        public int NSWSSE { get; set; }
        public int CountSupportStaf { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolyclinicDistrict> PolyclinicDistrict { get; set; }
    }
}
