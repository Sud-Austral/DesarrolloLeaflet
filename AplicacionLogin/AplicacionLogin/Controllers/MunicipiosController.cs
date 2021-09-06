using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionLogin.Controllers
{
    public class MunicipiosController : Controller
    {
        // GET: Municipios
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Municipios(int codCom = 0)
        {
            ViewBag.codCom = codCom;
            return View();
        }
    }
}