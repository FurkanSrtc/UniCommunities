using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityCommunities.Models
{
    public class UyelerViewModel
    {
        [ScaffoldColumn(false)]
        public int Uye_Id { get; set; }

        [Required(ErrorMessage = "Okul Numarası Gerekli")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "9 Haneli Okul Numaranızı Girin")]
        [DisplayName("Okul Numarası")]
        public string Uye_OkulNo { get; set; }

        [Required(ErrorMessage = "Üye Adı Gerekli")]
        public string Uye_Adi { get; set; }

        [Required(ErrorMessage = "Üye Soyadı Gerekli")]
        public string Uye_Soyadi { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Doğum Tarihi Gerekli")]
        public DateTime Uye_DogumTarihi { get; set; }

        [Required(ErrorMessage = "Fakülte No Gerekli")]
        public int Uye_FakulteNo { get; set; }

        [Required(ErrorMessage = "Bölüm No Gerekli")]
        public int Uye_BolumNo { get; set; }

        [Required(ErrorMessage = "E-Posta Gerekli")]
        [EmailAddress(ErrorMessage = "Geçersiz E-Posta Adresi")]
        public string Uye_EPosta { get; set; }


        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "10 Haneli Telefon Numaranızı Girin")]
        [Required(ErrorMessage = "Telefon Numarası Gerekli")]
        public string Uye_Telefon { get; set; }
        public int Unvan_Id { get; set; }
        public bool isVisible { get; set; }
        public int Kulup_Id { get; set; }

    }
}