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
    
    public partial class termin
    {
        public int PK_Termin { get; set; }
        public Nullable<System.DateTime> Termin_Start { get; set; }
        public Nullable<System.DateTime> Termin_Ende { get; set; }
        public string Bezeichnung { get; set; }
        public Nullable<int> FK_Raum { get; set; }
        public Nullable<int> FK_Patient { get; set; }
    
        public virtual patient patient { get; set; }
        public virtual raum raum { get; set; }
    }
}
