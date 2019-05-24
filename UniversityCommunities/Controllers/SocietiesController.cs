using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityCommunities.Models;
using UniversityCommunities.Models.ViewModels;

namespace UniversityCommunities.Controllers
{
    public class SocietiesController : Controller
    {
        UniversiteKulupYonetimDBEntities db = new UniversiteKulupYonetimDBEntities();
        // GET: Societies
        public ActionResult Index()
        {
            List<KulupKayit> kulupList = new List<KulupKayit>();
            kulupList = (db.KulupKayit.Where(x => x.OnayDurumu == true && x.isVisible == true).ToList());

            return View(kulupList);
        }

        public ActionResult Activities()
        {
            List<KulupEtkinlikleri> kulupEtkinlikleri = new List<KulupEtkinlikleri>();

            int a = Convert.ToInt32(Session["SocietyId"]);

            kulupEtkinlikleri = db.KulupEtkinlikleri.Where(x => x.Kulup_Id == a && x.isVisible == true).ToList();


            return View(kulupEtkinlikleri);

        }

        public ActionResult LogOut()
        {
            Session.Clear();
            Session.RemoveAll();

            return RedirectToAction("Index", "Home");
        }



        public ActionResult AddActivity()
        {
            try
            {
                KulupEtkinlikleriViewModel kulupEtkinlikleri = new KulupEtkinlikleriViewModel();
                int a = Convert.ToInt32(Session["SocietyId"]);
                kulupEtkinlikleri.Kulup_Id = a;


                List<FaaliyetTurleri> faaliyetTurleri = db.FaaliyetTurleri.ToList();
                ViewBag.FaaliyetTurList = new SelectList(faaliyetTurleri, "Faaliyet_Turu_Id", "Faaliyet_Turu_Adi");

                
                List<EtkinlikTurleri> etkinlikTurleri = db.EtkinlikTurleri.ToList();
                ViewBag.EtkinlikTurList = new SelectList(etkinlikTurleri, "Etkinlik_Turu_Id", "Etkinlik_Turu_Adi");


                //KONFERANS SALONLARI



                List<KonferansSalonlari> konferansSalonlari = db.KonferansSalonlari.ToList();




                ServiceReference1.UniServisClient uniServis = new ServiceReference1.UniServisClient();

                //  ViewBag.KonferansList = new SelectList(uniServis.GetAuditoriums(),"id", "SalonAdi");
                ViewBag.KonferansList = new SelectList(uniServis.GetAuditoriums(), "id", "SalonAdi");
                return View(kulupEtkinlikleri);
            }
            catch (Exception)
            {

                return RedirectToAction("Login", "Home");

            }

        }




        public ActionResult Details(int id)
        {
            return View(db.KulupEtkinlikleri.ToList().Where(x => x.Kulup_Id == id));
        }

        [HttpPost]
        public ActionResult AddActivity(KulupEtkinlikleriViewModel kev)
        {

            if (ModelState.IsValid)
            {
                int a = Convert.ToInt32(Session["SocietyId"]);
                KulupEtkinlikleri kulupEtkinlikleri = new KulupEtkinlikleri();
                kulupEtkinlikleri.Etkinlik_Adi = kev.Etkinlik_Adi;
                kulupEtkinlikleri.Etkinlik_Konusu = kev.Etkinlik_Konusu;
                kulupEtkinlikleri.Adres = kev.Adres;
                kulupEtkinlikleri.Etkinlik_Tarihi = kev.Etkinlik_Tarihi;
                kulupEtkinlikleri.Etkinlik_Turu_Id = kev.Etkinlik_Turu_Id;
                kulupEtkinlikleri.Faaliyet_Turu_Id = kev.Faaliyet_Turu_Id;
                kulupEtkinlikleri.isVisible = true;
                kulupEtkinlikleri.OnayDurumu = false;
                kulupEtkinlikleri.Kulup_Id = a;
                kulupEtkinlikleri.SalonId = kev.KonferansSalonuId;
           //     Session["konfolcakmi"] = kev.KonferansSalonu;
                db.KulupEtkinlikleri.Add(kulupEtkinlikleri);
                db.SaveChanges();

                return RedirectToAction("Activities");
            }
            else
            {

                return View();
            }

        }


        public ActionResult AddLogo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddLogo(KulupLogo img, HttpPostedFileBase file)
        {

            if (ModelState.IsValid)
            {
                if (db.KulupLogo.Where(x => x.Kulup_No == Convert.ToInt32(Session["SocietyId"])) == null)
                {
                    if (file != null)
                    {
                        file.SaveAs(HttpContext.Server.MapPath("~/images/Logos/")
                                                              + file.FileName);
                        img.Logo_Adresi = file.FileName;
                    }

                    img.Kulup_No = Convert.ToInt32(Session["SocietyId"]);

                    db.KulupLogo.Add(img);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    if (ModelState.IsValid)
                    {
                        int societyId = Convert.ToInt32(Session["SocietyId"]);
                        KulupLogo klp = db.KulupLogo.Where(x => x.Kulup_No == societyId).FirstOrDefault();
                        if (file != null)
                        {
                            file.SaveAs(HttpContext.Server.MapPath("~/images/Logos/")
                                                                  + file.FileName);
                            img.Logo_Adresi = file.FileName;
                        }

                        klp.Logo_Adresi = img.Logo_Adresi;

                        db.SaveChanges();
                    }
                }
            }
            return View(img);
        }

    }
}