//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Establishment_Management
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stagaire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stagaire()
        {
            this.Seance = new HashSet<Seance>();
        }
    
        public int numStg { get; set; }
        public string nomStg { get; set; }
        public string prenomStg { get; set; }
        public Nullable<System.DateTime> dateNStg { get; set; }
        public Nullable<int> numGrp { get; set; }
        public string Cin { get; set; }
    
        public virtual Groupe Groupe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seance> Seance { get; set; }
    }
}
