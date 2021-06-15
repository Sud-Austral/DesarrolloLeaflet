using AplicacionLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionLogin.Controllers
{
    public class FiltrosController : Controller
    {
        // GET: Filtros
        public ActionResult Region(int id = 1)
        {
            DataBase db = new DataBase();
            var reg = db.Regiones.Where(x => x.id == id).First();
            ViewBag.Region = reg;
            return View();
        }

        public ActionResult Comuna(int id = 1, int id2 = 101)
        {

            DataBase db = new DataBase();
            var reg = db.Regiones.Where(x => x.id == id).First();
            ViewBag.Region = reg;
            ViewBag.Comuna = id2;
            return View();
        }
    }
}