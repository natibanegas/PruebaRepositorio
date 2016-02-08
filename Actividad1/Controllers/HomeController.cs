using Actividad1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Actividad1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var hola = new Hola();
            return View(hola);
        }
        [HttpGet]
        public ActionResult Index(Hola hola)
        {
            return View(hola);
        }
      
    }
}