using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityCommunities.Models.ViewModels
{
    public class KulupEtkinlikleriViewModel
    {
        [ScaffoldColumn(false)]
        public int Etkinlik_Id { get; set; }

        [Required(ErrorMessage = "Etkinlik Adı Gerekli")]
        [DisplayName("Etkinlik Adı")]
        public string Etkinlik_Adi { get; set; }

        [Required(ErrorMessage = "Etkinlik Konusu Gerekli")]
        [DisplayName("Etkinlik Konusu")]
        public string Etkinlik_Konusu { get; set; }

        [Required(ErrorMessage = "Etkinlik Tarihi Gerekli")]
        [DisplayName("Etkinlik Tarihi")]
        [DataType(DataType.Date)]
        public DateTime Etkinlik_Tarihi { get; set; }

        [Required(ErrorMessage = "Etkinlik Türü Gerekli")]
        public short Etkinlik_Turu_Id { get; set; }

        [Required(ErrorMessage = "Faaliyet Türü Gerekli")]
        public short Faaliyet_Turu_Id { get; set; }

        [Required(ErrorMessage = "Adres Gerekli")]
        public string Adres { get; set; }

        public int Kulup_Id { get; set; }

        [Required(ErrorMessage = "Bu Alan Gerekli")]
        [DisplayName("Konferans Salonu Kullanılacak Mı ?")]
        public bool KonferansSalonu { get; set; }

    }
}