using OtelWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtelWebsite.Controllers
{
    public class AdminController : Controller
    {

        OtelEntities3 db = new OtelEntities3();
        // GET: Admin

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listele()
        {
            return View(db.Admins.ToList());
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Admin ekle)
        {
            try
            {
                using (OtelEntities3 db = new OtelEntities3())
                {
                    db.Admins.Add(ekle);
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
                return View(db.Admins.Where(x => x.AdminNo == id).FirstOrDefault());
            }
        }


        [HttpPost]
        public ActionResult Duzenle(int id, Admin duzenle)
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
        public ActionResult Sil(int id, Admin sil)
        {
            try
            {
                using (OtelEntities3 db = new OtelEntities3())
                {
                    sil = db.Admins.Where(x => x.AdminNo == id).FirstOrDefault();
                    db.Admins.Remove(sil);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Musteri()
        {
            return View(db.MusteriKayits.ToList());
        }
        public ActionResult Oda()
        {
            return View(db.Odalars.ToList());
        }
        public ActionResult OdaServisi()
        {
            return View(db.Servislers.ToList());
        }



    }
}