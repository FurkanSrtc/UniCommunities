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
    
    public partial class UniversiteKayit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UniversiteKayit()
        {
            this.KulupKayit = new HashSet<KulupKayit>();
        }
    
        public int Universite_Id { get; set; }
        public string Universite_Adi { get; set; }
        public string Universite_Kampus { get; set; }
        public Nullable<int> Universite_ilNo { get; set; }
        public Nullable<bool> isVisible { get; set; }
        public Nullable<int> Universite_ilceNo { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KulupKayit> KulupKayit { get; set; }
    }
}
