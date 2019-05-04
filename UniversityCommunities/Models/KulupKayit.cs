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
    
    public partial class KulupKayit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KulupKayit()
        {
            this.KulupEtkinlikleri = new HashSet<KulupEtkinlikleri>();
            this.KulupGuvenlikBilgileri = new HashSet<KulupGuvenlikBilgileri>();
            this.KulupLogo = new HashSet<KulupLogo>();
            this.Uyeler = new HashSet<Uyeler>();
        }
    
        public int Kulup_Id { get; set; }
        public string Kulup_Adi { get; set; }
        public string Kulup_KurulusAmaci { get; set; }
        public Nullable<int> Universite_Id { get; set; }
        public Nullable<int> Fakulte_No { get; set; }
        public string KulupDanisman_Unvani { get; set; }
        public string KulupDanisman_Adi { get; set; }
        public string KulupDanisman_Soyadi { get; set; }
        public string KulupDanisman_Telefon { get; set; }
        public string KulupDanisman_MailAdresi { get; set; }
        public Nullable<bool> OnayDurumu { get; set; }
        public Nullable<bool> isVisible { get; set; }
    
        public virtual Fakulteler Fakulteler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KulupEtkinlikleri> KulupEtkinlikleri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KulupGuvenlikBilgileri> KulupGuvenlikBilgileri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KulupLogo> KulupLogo { get; set; }
        public virtual UniversiteKayit UniversiteKayit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uyeler> Uyeler { get; set; }
    }
}