//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class Knygo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Knygo()
        {
            this.Egzempliorius = new HashSet<Egzemplioriu>();
        }
    
        public int Isbn { get; set; }
        public string Autorius { get; set; }
        public string Pavadinimas { get; set; }
        public string Leidykla { get; set; }
        public Nullable<System.DateTime> Metai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Egzemplioriu> Egzempliorius { get; set; }
    }
}
