using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityCommunities.Models;

namespace UniversityCommunities.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<KulupEtkinlikleri> kulupEtkinlikleri = new List<KulupEtkinlikleri>();

          

            kulupEtkinlikleri = db.KulupEtkinlikleri.Where(x=> x.OnayDurumu == true && x.isVisible == true && x.Etkinlik_Tarihi>DateTime.Now).OrderBy(x=>x.Etkinlik_Tarihi).ToList();

            ViewBag.Duyurular = db.Universite_Duyuru.ToList();
           
            return View(kulupEtkinlikleri);
        }

        public ActionResult Login()
        {
            return View();
        }

 
        [HttpPost]
        public ActionResult Login(KulupGuvenlikBilgileri kgb)
        {
            KulupGuvenlikBilgileri kulupGuvenlikBilgileri = db.KulupGuvenlikBilgileri.Where(x => x.KullaniciAdi == kgb.KullaniciAdi && x.Sifre == kgb.Sifre).FirstOrDefault();


            if (kulupGuvenlikBilgileri == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                Session["SocietyUsername"] = kulupGuvenlikBilgileri.KullaniciAdi;
                Session["SocietyId"] = kulupGuvenlikBilgileri.KulupId;


                return RedirectToAction("Activities", "Societies");
            }
        }


        public ActionResult Test()
        {
            return View();
        }
        UniversiteKulupYonetimDBEntities db = new UniversiteKulupYonetimDBEntities();
            
        public ActionResult Register()
        {
            ManagmentUsers();

            return View();
           

        }
 
        public ActionResult Register2()
        {
            ManagmentUsers();
            return View();
        }
        public ActionResult Register3()
        {
            ManagmentUsers();
            return View();
        }

        public ActionResult Register4()
        {
            ManagmentUsers();
            return View();
        }

        public ActionResult Register5()
        {
            ManagmentUsers();
            return View();
        }
        public ActionResult Register6()
        {
            ManagmentUsers();
            return View();
        }

        public ActionResult Register7()
        {
            ManagmentUsers();
            return View();
        }

        public ActionResult Register8()
        {
            ManagmentUsers();
            return View();
        }
        public ActionResult Register9()
        {
            ManagmentUsers();
            return View();
        }



        public JsonResult GetStateList(int Fakulte_no)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<Bolumler> departmentList = db.Bolumler.Where(x => x.Fakulte_No == Fakulte_no).ToList();

           
            return Json(departmentList, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        public ActionResult Register(KulupKayitViewModel kulupKayitViewModel)
        {
            // kulupKayitViewModel.Baskan.Unvan_Id = 1;
          
            
  
            KulupKayit kulupKayit = new KulupKayit();
            kulupKayit.OnayDurumu = false;
            kulupKayit.Universite_Id = 1;
            kulupKayit.isVisible = true;
            kulupKayit.Fakulte_No= kulupKayitViewModel.Fakulte_No;
            kulupKayit.KulupDanisman_Adi = kulupKayitViewModel.kulupKayit.KulupDanisman_Adi;
            kulupKayit.KulupDanisman_Soyadi = kulupKayitViewModel.kulupKayit.KulupDanisman_Soyadi;
            kulupKayit.KulupDanisman_MailAdresi = kulupKayitViewModel.kulupKayit.KulupDanisman_MailAdresi;
            kulupKayit.KulupDanisman_Telefon = kulupKayitViewModel.kulupKayit.KulupDanisman_Telefon;
            kulupKayit.KulupDanisman_Unvani = kulupKayitViewModel.kulupKayit.KulupDanisman_Unvani;
            kulupKayit.Kulup_KurulusAmaci = kulupKayitViewModel.kulupKayit.Kulup_KurulusAmaci;
            kulupKayit.Kulup_Adi = kulupKayitViewModel.kulupKayit.Kulup_Adi;
            Session["KulupKayit"] = kulupKayit;



            KulupGuvenlikBilgileri KulupGuvenlik = new KulupGuvenlikBilgileri();
            KulupGuvenlik.isVisible = true;
            KulupGuvenlik.KullaniciAdi = kulupKayitViewModel.KulupGuvenlikBilgileri.KullaniciAdi;
            KulupGuvenlik.Sifre = kulupKayitViewModel.KulupGuvenlikBilgileri.Sifre;

            Session["KulupGuvenlik"] = KulupGuvenlik;




            //db.KulupKayit.Add(kulupKayitViewModel.kulupKayit);
            //db.SaveChanges();

            if (ModelState.IsValid)
                return RedirectToAction("Register2");
            else
            {
                ManagmentUsers();
                return View();
            }
           
        }

       
        public void RegisterUser(KulupKayitViewModel kulupKayitViewModel, int Unvan,string UnvanName)
        {
            Uyeler uye = new Uyeler();
            uye.isVisible = true;
            uye.Unvan_Id = Unvan;
            uye.Uye_FakulteNo = kulupKayitViewModel.Fakulte_No;
            uye.Uye_BolumNo = kulupKayitViewModel.Bolum_No;
            uye.Uye_Adi = kulupKayitViewModel.Uye.Uye_Adi;
            uye.Uye_Soyadi = kulupKayitViewModel.Uye.Uye_Soyadi;
            uye.Uye_OkulNo = kulupKayitViewModel.Uye.Uye_OkulNo;
            uye.Uye_Telefon = kulupKayitViewModel.Uye.Uye_Telefon;
            uye.Uye_DogumTarihi = kulupKayitViewModel.Uye.Uye_DogumTarihi;
            uye.Uye_EPosta = kulupKayitViewModel.Uye.Uye_EPosta;
            Session[UnvanName] =uye;




        }

        [HttpPost]
        public ActionResult Register2(KulupKayitViewModel kulupKayitViewModel)
        {
            RegisterUser(kulupKayitViewModel, 1, "Baskan");


            if (ModelState.IsValid)
                return RedirectToAction("Register3");
            else {
            ManagmentUsers();
            return View();
            }
        }

        [HttpPost]
        public ActionResult Register3(KulupKayitViewModel kulupKayitViewModel)
        {
            RegisterUser(kulupKayitViewModel, 2, "BaskanYardimcisi");

            if (ModelState.IsValid)
                return RedirectToAction("Register4");
            else
            {
                ManagmentUsers();
                return View();
            }
        }
        [HttpPost]
        public ActionResult Register4(KulupKayitViewModel kulupKayitViewModel)
        {
            RegisterUser(kulupKayitViewModel, 3, "Sayman");


            if (ModelState.IsValid)
                return RedirectToAction("Register5");
            else
            {
                ManagmentUsers();
                return View();
            }
        }
        [HttpPost]
        public ActionResult Register5(KulupKayitViewModel kulupKayitViewModel)
        {
            RegisterUser(kulupKayitViewModel, 4, "Sekreter");


            if (ModelState.IsValid)
                return RedirectToAction("Register6");
            else
            {
                ManagmentUsers();
                return View();
            }
        }
        [HttpPost]
        public ActionResult Register6(KulupKayitViewModel kulupKayitViewModel)
        {
            RegisterUser(kulupKayitViewModel, 5, "AsilUye1");

            if (ModelState.IsValid)
                return RedirectToAction("Register7");
            else
            {
                ManagmentUsers();
                return View();
            }
        }
        [HttpPost]
        public ActionResult Register7(KulupKayitViewModel kulupKayitViewModel)
        {
            RegisterUser(kulupKayitViewModel, 5, "AsilUye2");


            if (ModelState.IsValid)
                return RedirectToAction("Register8");
            else
            {
                ManagmentUsers();
                return View();
            }
        }
        [HttpPost]
        public ActionResult Register8(KulupKayitViewModel kulupKayitViewModel)
        {
            RegisterUser(kulupKayitViewModel, 5, "AsilUye3");


            if (ModelState.IsValid)
                return RedirectToAction("Register9");
            else
            {
                ManagmentUsers();
                return View();
            }
        }
      

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register9(KulupKayitViewModel kulupKayitViewModel)
        {
            if (ModelState.IsValid)
            {

          


            Uyeler uye = new Uyeler();

            db.KulupKayit.Add((KulupKayit)Session["KulupKayit"]);
            db.SaveChanges();

            KulupKayit kulup = new KulupKayit();
            kulup = (KulupKayit)Session["KulupKayit"];
            kulup = db.KulupKayit.Where(x => x.Kulup_Adi == kulup.Kulup_Adi).FirstOrDefault();

            int klpId = kulup.Kulup_Id;
            KulupGuvenlikBilgileri kgb = new KulupGuvenlikBilgileri();
            kgb = (KulupGuvenlikBilgileri)Session["KulupGuvenlik"];
            kgb.KulupId = klpId;

                db.KulupGuvenlikBilgileri.Add(kgb);



                uye = (Uyeler)Session["Baskan"];
                uye.Kulup_Id = klpId;
                db.Uyeler.Add(uye);


                uye = (Uyeler)Session["BaskanYardimcisi"];
                uye.Kulup_Id = klpId;
                db.Uyeler.Add(uye);

                uye = (Uyeler)Session["Sayman"];
                uye.Kulup_Id = klpId;
                db.Uyeler.Add(uye);

                uye = (Uyeler)Session["Sekreter"];
                uye.Kulup_Id = klpId;
                db.Uyeler.Add(uye);

                uye = (Uyeler)Session["AsilUye1"];
                uye.Kulup_Id = klpId;
                db.Uyeler.Add(uye);

                uye = (Uyeler)Session["AsilUye2"];
                uye.Kulup_Id = klpId;
                db.Uyeler.Add(uye);

                uye = (Uyeler)Session["AsilUye3"];
                uye.Kulup_Id = klpId;
                db.Uyeler.Add(uye);


                RegisterUser(kulupKayitViewModel, 6, "YedekUye1");


            uye = (Uyeler)Session["YedekUye1"];
            uye.Kulup_Id = klpId;
            db.Uyeler.Add(uye);

            db.SaveChanges();

                Session.Clear();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ManagmentUsers();
                return View();
            }

        }

   
      

        public void ManagmentUsers()
        {
            List<Fakulteler> FacultyList = db.Fakulteler.ToList();


            ViewBag.DepartmentList = new SelectList(FacultyList, "Fakulte_No", "Fakulte_Adi");
           // Session["DepartmentList"]= new SelectList(FacultyList, "Fakulte_No", "Fakulte_Adi");



            //KulupKayitViewModel model = new KulupKayitViewModel();

            //model.uyeUnvanlari = db.UyeUnvanlari.ToList();





            //List<SelectListItem> Unvan = (from k in model.uyeUnvanlari
            //                              select new SelectListItem
            //                              {

            //                                  Text = k.Unvan_Adi,
            //                                  Value = k.Unvan_Id.ToString()
            //                              }).ToList();
            //ViewBag.UnvanBox = Unvan;
        }

    }
}