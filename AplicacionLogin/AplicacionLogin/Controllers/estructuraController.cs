using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionLogin.Controllers
{
    public class estructuraController : Controller
    {
        // GET: estructura
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult mapa1(int id=10)
        {
            ViewBag.id = id;
            return View();
        }


        public ActionResult mapa2()
        {
            return View();
        }
        public PartialViewResult Mapa10() {
            return PartialView();
        }

    }
}