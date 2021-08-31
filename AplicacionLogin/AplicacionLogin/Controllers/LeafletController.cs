using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionLogin.Controllers
{
    public class LeafletController : Controller
    {
        // GET: Leaflet
        public ActionResult Index(int id = 13)
        {
            ViewBag.region = id;
            return View();
        }

        public ActionResult MaxMin(int idGlaciar = 0, int idGlaciar2 = 0)
        {
            ViewBag.glaciar = idGlaciar;
            ViewBag.prueba = idGlaciar2;
            return View();
        }
    }
}