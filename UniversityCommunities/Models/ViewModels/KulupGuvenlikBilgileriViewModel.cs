using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UniversityCommunities.Models
{
    public class KulupGuvenlikBilgileriViewModel
    {
        [ScaffoldColumn(false)]
        public int KGuvenlikId { get; set; }

        public int KulupId { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı Gerekli")]
        [DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage = "Parola Gerekli")]
        [DisplayName("Parola")]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }

        [ScaffoldColumn(false)]
        public bool isVisible { get; set; }

    }
}