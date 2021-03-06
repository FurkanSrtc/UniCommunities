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
    
    public partial class KulupEtkinlikleri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KulupEtkinlikleri()
        {
            this.KulupEtkinlikFotograflari = new HashSet<KulupEtkinlikFotograflari>();
        }
    
        public int Etkinlik_Id { get; set; }
        public string Etkinlik_Adi { get; set; }
        public string Etkinlik_Konusu { get; set; }
        public Nullable<System.DateTime> Etkinlik_Tarihi { get; set; }
        public Nullable<short> Etkinlik_Turu_Id { get; set; }
        public Nullable<short> Faaliyet_Turu_Id { get; set; }
        public string Adres { get; set; }
        public Nullable<bool> isVisible { get; set; }
        public Nullable<int> Kulup_Id { get; set; }
        public Nullable<bool> OnayDurumu { get; set; }
        public Nullable<int> SalonId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KulupEtkinlikFotograflari> KulupEtkinlikFotograflari { get; set; }
        public virtual KulupKayit KulupKayit { get; set; }
        public virtual EtkinlikTurleri EtkinlikTurleri { get; set; }
        public virtual FaaliyetTurleri FaaliyetTurleri { get; set; }
        public virtual KonferansSalonlari KonferansSalonlari { get; set; }
    }
}
