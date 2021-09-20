using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionLogin.Controllers
{
    public class BiofisicaController : Controller
    {
        // GET: Biofisica
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Biofisica(int comuna = 0, string var = "")
        {
            ViewBag.codCom = comuna;
            ViewBag.variable = var;
            return View();
        }
    }
}