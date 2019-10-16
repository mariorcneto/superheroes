using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using SuperHeroes.Models;

namespace SuperHeroes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            return View(user);
        }

        public ActionResult Login(string name, string password)
        {
            //if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(password))
            //    return RedirectToAction("Index");

            ViewBag.login = false;
            return View("Index", new User());

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return RedirectToAction("Index");
        }
    }
}