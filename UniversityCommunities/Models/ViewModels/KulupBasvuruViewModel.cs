using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityCommunities.Models.ViewModels
{
    public class KulupBasvuruViewModel
    {
        [ScaffoldColumn(false)]
        public int Kulup_Id { get; set; }

        [Required(ErrorMessage = "Kulüp Adı Gerekli")]
        [DisplayName("Kulüp Adı")]
        public string Kulup_Adi { get; set; }

        [Required(ErrorMessage = "Kuruluş Amacınızı Belirtmelisiniz.")]
        [DisplayName("Kuruluş Amacı")]
        public string Kulup_KurulusAmaci { get; set; }


        public int Universite_Id { get; set; }

        [Required(ErrorMessage = "Fakülte Gerekli")]
        public int Fakulte_No { get; set; }

        [Required(ErrorMessage = "Danışman Ünvanını Belirtmelisiniz")]
        [DisplayName("Kuruluş Amacı")]
        public string KulupDanisman_Unvani { get; set; }


        [Required(ErrorMessage = "Danışman Adını Belirtmelisiniz")]
        [DisplayName("Danışman Adı")]
        public string KulupDanisman_Adi { get; set; }

        [Required(ErrorMessage = "Danışman Soyadını Belirtmelisiniz")]
        [DisplayName("Danışman Soyadı")]
        public string KulupDanisman_Soyadi { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "10 Haneli Telefon Numaranızı Girin")]
        [Required(ErrorMessage = "Telefon Numarası Gerekli")]
        public string KulupDanisman_Telefon { get; set; }

        [Required(ErrorMessage = "Danışman Mail Adresi Belirtmelisiniz")]
        [EmailAddress(ErrorMessage = "Geçersiz E-Posta Adresi")]
        [DisplayName("Danışman Mail Adresi")]
        public string KulupDanisman_MailAdresi { get; set; }


        public bool OnayDurumu { get; set; }
        public bool isVisible { get; set; }

    }
}