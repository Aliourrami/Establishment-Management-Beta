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
    
    public partial class Seance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seance()
        {
            this.Stagaire = new HashSet<Stagaire>();
        }
    
        public int numSc { get; set; }
        public Nullable<int> numAff { get; set; }
        public Nullable<System.DateTime> dateSc { get; set; }
        public Nullable<int> duree { get; set; }
        public Nullable<int> salle { get; set; }
    
        public virtual Affectation Affectation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stagaire> Stagaire { get; set; }
    }
}