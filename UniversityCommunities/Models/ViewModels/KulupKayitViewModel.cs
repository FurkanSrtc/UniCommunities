using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityCommunities.Models.ViewModels;

namespace UniversityCommunities.Models
{
    public class KulupKayitViewModel
    {
        public KulupBasvuruViewModel kulupKayit { get; set; }
        public int Fakulte_No { get; set; }
        public int Bolum_No { get; set; }
       
        public List <UyeUnvanlari> uyeUnvanlari { get; set; }


        public KulupGuvenlikBilgileriViewModel KulupGuvenlikBilgileri { get; set; }

        public UyelerViewModel Uye { get; set; }

    }
}