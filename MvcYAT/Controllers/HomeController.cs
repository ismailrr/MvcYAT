using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcYAT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Qurban()
        {
            return View();
        }

        public ActionResult Donasi()
        {
            return View();
        }

        public ActionResult Struktur()
        {
            return View();
        }
        public ActionResult VisiMisi()
        {
            return View();
        }

        public ActionResult Liputan()
        {
            return View();
        }

        public ActionResult Sejarah()
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
    }
}