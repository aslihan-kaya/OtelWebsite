using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OtelWebsite.Models;
using Microsoft.SqlServer.Server;

namespace OtelWebsite.Controllers
{
    [AllowAnonymous]
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            using (OtelEntities3 db = new OtelEntities3())
            {
                var result = db.Admins.Where(x => x.KullaniciAdi == user.KullaniciAdi && x.Sifre == user.Sifre);
                if (result.Count() != 0)
                {
                    FormsAuthentication.SetAuthCookie(user.KullaniciAdi, false);
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    TempData["msg"] = "hatalı";
                }
            }
            return View();

        }
        public ActionResult Logout()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            return View("Login");
        }
    }
}