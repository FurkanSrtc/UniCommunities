using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using UniversityCommunities.Models;

namespace UniversiteServis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UniServis" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UniServis.svc or UniServis.svc.cs at the Solution Explorer and start debugging.
    public class UniServis : IUniServis
    {
      

        public List<KonferansSalonlari> GetAuditoriums()
        {

            using (UniversiteKulupYonetimDBEntities db2 = new UniversiteKulupYonetimDBEntities())
            {
                // return db.KonferansSalonlari.Where(x => x.SalonFakultesi == FakulteNo).ToList();
                return db2.KonferansSalonlari.ToList();
            }

        }

        public List<Fakulteler> GetFaculties()
        {
            using (UniversiteKulupYonetimDBEntities db2 = new UniversiteKulupYonetimDBEntities())
            {
                return db2.Fakulteler.ToList();
            }
        }

        public List<Saatler> GetTimes()
        {
            using (UniversiteKulupYonetimDBEntities db2 = new UniversiteKulupYonetimDBEntities())
            {
                return db2.Saatler.ToList();
            }
        }
    }
}
