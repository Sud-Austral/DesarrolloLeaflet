using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionLogin.Controllers
{
    public class CuidadesController : Controller
    {
        // GET: Cuidades
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cuidades(int id = 0)
        {
            ViewBag.cuidad = id;
            return View();
        }
    }
}