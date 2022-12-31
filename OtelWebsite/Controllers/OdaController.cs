using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelWebsite.Models;

namespace OtelWebsite.Controllers
{
    public class OdaController : Controller
    {
        OtelEntities3 db = new OtelEntities3();
        // GET: Oda
        public ActionResult Index()
        {
            return View(db.Odalars.ToList());
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Odalar ekle)
        {
            try
            {
                using (OtelEntities3 db = new OtelEntities3())
                {
                    db.Odalars.Add(ekle);
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
                return View(db.Odalars.Where(x => x.OdaNo == id).FirstOrDefault());
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
        public ActionResult Sil(int id, Odalar sil)
        {
            try
            {
                using (OtelEntities3 db = new OtelEntities3())
                {
                    sil = db.Odalars.Where(x => x.OdaNo == id).FirstOrDefault();
                    db.Odalars.Remove(sil);
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