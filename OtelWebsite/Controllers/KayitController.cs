using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelWebsite.Models;

namespace OtelWebsite.Controllers
{
    public class KayitController : Controller
    {
        OtelEntities3 db = new OtelEntities3();
        // GET: Kayit

        public ActionResult Index()
        {
            return View(db.MusteriKayits.ToList());
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(MusteriKayit ekle)
        {
            try
            {
                using (OtelEntities3 db = new OtelEntities3())
                {
                    db.MusteriKayits.Add(ekle);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Duzenle(int id)
        {
            using (OtelEntities3 db = new OtelEntities3())
            {
                return View(db.MusteriKayits.Where(x => x.MusteriNo == id).FirstOrDefault());
            }
        }


        [HttpPost]
        public ActionResult Duzenle(int id, MusteriKayit duzenle)
        {
            try
            {
                using (OtelEntities3 db = new OtelEntities3())
                {
                    db.Entry(duzenle).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Sil(int id, MusteriKayit sil)
        {
            try
            {
                using (OtelEntities3 db = new OtelEntities3())
                {
                    sil = db.MusteriKayits.Where(x => x.MusteriNo == id).FirstOrDefault();
                    db.MusteriKayits.Remove(sil);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



    }
}