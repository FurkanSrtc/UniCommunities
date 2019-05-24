using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using UniversityCommunities.Models;
using UniversityCommunities.Models.ViewModels;

namespace UniversityCommunities.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }


        UniversiteKulupYonetimDBEntities db = new UniversiteKulupYonetimDBEntities();
        [HttpPost]
        public ActionResult Index(UniversiteKayit admin)
        {
            UniversiteKayit yntc = db.UniversiteKayit.Where(x => x.KullaniciAdi == admin.KullaniciAdi && x.Sifre == admin.Sifre).FirstOrDefault();
            if (yntc == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                Session["username"] = yntc.KullaniciAdi;
                Session["password"] = yntc.Sifre;

                return RedirectToAction("Home", "Admin");
            }
        }

        public ActionResult Home()
        {
            try
            {
                if (!String.IsNullOrEmpty(Session["username"].ToString()))
                {
                    return View();
                }
                else
                    return RedirectToAction("Index", "Admin");
            }
            catch (Exception)
            {

                return RedirectToAction("Index", "Admin");
            }
        }


        public ActionResult ManagmentActivity()
        {
            List<KulupEtkinlikleri> activityList = new List<KulupEtkinlikleri>();
            activityList = (db.KulupEtkinlikleri.Where(x => x.OnayDurumu == false && x.isVisible == true).ToList());
            return View(activityList);
        }

        public ActionResult ActivityAdd(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                KulupEtkinlikleri activityInfo = db.KulupEtkinlikleri.Find(id);
                activityInfo.OnayDurumu = true;
                KulupKayit KulupAktifMi = db.KulupKayit.Where(x => x.Kulup_Id == activityInfo.Kulup_Id).FirstOrDefault();

                if (KulupAktifMi.OnayDurumu == true)
                {
                    db.Entry(activityInfo).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("ManagmentActivity", "Admin");
                }
                else
                {
                    return Content("Kulüp Aktif Değil");
                }
            }
        }
        public ActionResult ActivityDetails()
        {
            List<KulupEtkinlikleri> activityList = new List<KulupEtkinlikleri>();
            activityList = (db.KulupEtkinlikleri.Where(x => x.OnayDurumu == false && x.isVisible == true).ToList());
            return View(activityList);
        }

        public ActionResult ManagmentSociety()
        {
            List<KulupKayit> societyList = new List<KulupKayit>();
            societyList = (db.KulupKayit.Where(x => x.OnayDurumu == false && x.isVisible == true).ToList());


            List<KulupKayit> societyList2 = new List<KulupKayit>();
           ViewBag.OnaylanmisKulupler = (db.KulupKayit.Where(x => x.OnayDurumu == true && x.isVisible == true).ToList());

            return View(societyList);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                KulupKayit societyInfo = db.KulupKayit.Where(x => x.Kulup_Id == id && x.isVisible == true).FirstOrDefault();

                List<Uyeler> uyeList = db.Uyeler.Where(x => x.Kulup_Id == id && x.isVisible == true).ToList();

                DetailsViewModel dvm = new DetailsViewModel();
                dvm.kulupKayit = societyInfo;
                TempData["listId"] = id;
                dvm.uyeList = uyeList;
                return View(dvm);
            }
        }

        public ActionResult Add(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                KulupKayit societyInfo = db.KulupKayit.Where(x => x.Kulup_Id == id && x.isVisible == true).FirstOrDefault();
                societyInfo.OnayDurumu = true;
                db.Entry(societyInfo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ManagmentSociety", "Admin");
            }
        }
        public ActionResult Duyuru()
        { return View(); }

        [HttpPost]
        public ActionResult Duyuru(UniversiteDuyuruViewModel d)
        {
            Universite_Duyuru duyuru = new Universite_Duyuru();
            duyuru.Duyuru = d.Duyuru;
            duyuru.Duyuru_Aciklama = d.Duyuru_Aciklama;
            duyuru.Duyuru_Url = d.Duyuru_Url;
            duyuru.Tarih = DateTime.Now.Date;
            db.Universite_Duyuru.Add(duyuru);
            db.SaveChanges();
            return View();
        }

    }
}