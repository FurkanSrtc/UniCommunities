//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversityCommunities.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EtkinlikTurleri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EtkinlikTurleri()
        {
            this.KulupEtkinlikleri = new HashSet<KulupEtkinlikleri>();
        }
    
        public short Etkinlik_Turu_Id { get; set; }
        public string Etkinlik_Turu_Adi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KulupEtkinlikleri> KulupEtkinlikleri { get; set; }
    }
}
