using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP220131_v1.Controllers
{
    public class SajatController : Controller
    {
        // GET: Sajat
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ValamiMas(int? id)
        {
            ViewBag.Dolog = $"{id}";
            return View();
        }
    }
}