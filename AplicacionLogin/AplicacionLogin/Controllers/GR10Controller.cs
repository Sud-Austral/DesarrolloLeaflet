using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionLogin.Controllers
{
    public class GR10Controller : Controller
    {
        // GET: Leaflet
        public ActionResult Index(int id = 13)
        {
            ViewBag.region = id;
            return View();
        }

        public ActionResult MaxMin(int idGlaciar = 0)
        {
            ViewBag.glaciar = idGlaciar;
            return View();
        }

        public ActionResult Dinamica(int idGlaciar = 0, string q = "", string p = "")
        {
            ViewBag.glaciar = idGlaciar;
            ViewBag.q = q;
            ViewBag.p = p;
            return View();
        }
    }
}