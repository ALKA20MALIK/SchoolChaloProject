using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolChalo.Models;

namespace SchoolChalo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Register()
        {
            return View();

        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(xtRegistration obj)

        {
            if (ModelState.IsValid)
            {
                LOCALEntities db = new LOCALEntities();
                db.xtRegistrations.Add(obj);
                db.SaveChanges();
            }
            return View("Login");
        }
    }
}