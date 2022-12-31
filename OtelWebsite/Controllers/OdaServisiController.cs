using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelWebsite.Models;

namespace OtelWebsite.Controllers
{
    public class OdaServisiController : Controller
    {
        OtelEntities3 db = new OtelEntities3();
        // GET: OdaServisi
        public ActionResult Index()
        {
            return View(db.Servislers.ToList());
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Servisler ekle)
        {
            try
            {
                using (OtelEntities3 db = new OtelEntities3())
                {
                    db.Servislers.Add(ekle);
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
                return View(db.Servislers.Where(x => x.ServisNo == id).FirstOrDefault());
            }
        }


        [HttpPost]
        public ActionResult Duzenle(int id, Servisler duzenle)
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
        public ActionResult Sil(int id, Servisler sil)
        {
            try
            {
                using (OtelEntities3 db = new OtelEntities3())
                {
                    sil = db.Servislers.Where(x => x.ServisNo == id).FirstOrDefault();
                    db.Servislers.Remove(sil);
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