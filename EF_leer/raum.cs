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
    
    public partial class raum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public raum()
        {
            this.termin = new HashSet<termin>();
        }
    
        public int PK_Raum { get; set; }
        public Nullable<int> Raumnummer { get; set; }
        public string Bezeichnung { get; set; }
        public Nullable<int> FK_Gebäude { get; set; }
        public Nullable<int> FK_Abteilung { get; set; }
    
        public virtual abteilung abteilung { get; set; }
        public virtual gebaeude gebaeude { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<termin> termin { get; set; }
    }
}
