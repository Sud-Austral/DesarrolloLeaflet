using AplicacionLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionLogin.Controllers
{
    public class GlaciaresController : Controller
    {
        // GET: Glaciares
        public ActionResult Index(int id = 10)
        {
            ViewBag.Region = id;
            DataBase db = new DataBase();
            var reg = db.Regiones.Where(x => x.id == id).First();
            ViewBag.Region = reg;
            return View();
        }

        public ActionResult heroku()
        {
            return View();
        }

        public ActionResult SuperficieMaxMin()
        {
            return View();
        }
    }
}