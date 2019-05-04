using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityCommunities.Models.ViewModels
{
    public class UniversiteDuyuruViewModel
    {

  
        [DisplayName("Duyuru Adı")]
        public string Duyuru { get; set; }

        [DisplayName("Duyuru Url")]
        public string Duyuru_Url { get; set; }

        [DisplayName("Duyuru Açıklama")]
        public string Duyuru_Aciklama { get; set; }
    }
}