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
    
    public partial class KulupGuvenlikBilgileri
    {
        public int KGuvenlikId { get; set; }
        public Nullable<int> KulupId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public Nullable<bool> isVisible { get; set; }
    
        public virtual KulupKayit KulupKayit { get; set; }
    }
}