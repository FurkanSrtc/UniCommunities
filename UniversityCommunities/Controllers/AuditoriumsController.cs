using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using UniversityCommunities.Models;

namespace UniversityCommunities.Controllers
{
    public class AuditoriumsController : Controller
    {

        UniversiteKulupYonetimDBEntities db = new UniversiteKulupYonetimDBEntities();
        //public JsonResult GetStateList(int Fakulte_no)
        //{
            

        //        db.Configuration.ProxyCreationEnabled = false;
        //        List<KonferansSalonlari> salontList = db.KonferansSalonlari.Where(x => x.SalonFakultesi == Fakulte_no).ToList();
        //    return Json(salontList, JsonRequestBehavior.AllowGet);
            
        //}



        // GET: Auditoriums
        public ActionResult Index()
        {
            //using (UniServiceReference.UniServisClient servisClient = new UniServiceReference.UniServisClient())
            //{



            //    //ViewBag.Times = new SelectList(servisClient.GetTimes(), "Saat", "Saat");
            //    ViewBag.Times = new SelectList(db.Saatler.ToList(), "Saat", "Saat");
            //    List<Fakulteler> FacultyList = db.Fakulteler.ToList();
            //    ViewBag.Faculties = new SelectList(FacultyList, "Fakulte_No", "Fakulte_Adi");
                return View();
            //}
         
        }
    }
}