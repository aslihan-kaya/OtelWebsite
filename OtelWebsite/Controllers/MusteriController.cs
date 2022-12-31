using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelWebsite.Models;

namespace OtelWebsite.Controllers
{
    public class MusteriController : Controller
    {

OtelEntities3 db = new OtelEntities3();
        // GET: Musteri
        public ActionResult Index()
        {
            return View(db.MusteriHesaps.ToList());
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(MusteriHesap ekle)
        {
            try
            {
                using (OtelEntities3 db = new OtelEntities3())
                {
                    db.MusteriHesaps.Add(ekle);
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
                return View(db.MusteriHesaps.Where(x => x.IslemNo == id).FirstOrDefault());
            }
        }


        [HttpPost]
        public ActionResult Duzenle(int id, MusteriHesap duzenle)
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
        public ActionResult Sil(int id, MusteriHesap sil)
        {
            try
            {
                using (OtelEntities3 db = new OtelEntities3())
                {
                    sil = db.MusteriHesaps.Where(x => x.IslemNo == id).FirstOrDefault();
                    db.MusteriHesaps.Remove(sil);
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