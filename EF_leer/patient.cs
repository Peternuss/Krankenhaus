//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_leer
{
    using System;
    using System.Collections.Generic;
    
    public partial class patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public patient()
        {
            this.diagnose = new HashSet<diagnose>();
            this.termin = new HashSet<termin>();
        }
    
        public int PK_Patient { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public Nullable<int> FK_Krankheit { get; set; }
        public Nullable<int> FK_Krankenkasse { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<diagnose> diagnose { get; set; }
        public virtual krankenkassenkarte krankenkassenkarte { get; set; }
        public virtual krankheit krankheit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<termin> termin { get; set; }
    }
}
