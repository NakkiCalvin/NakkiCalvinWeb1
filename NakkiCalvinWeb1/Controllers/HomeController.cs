using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NakkiCalvinWeb1.Models;

namespace NakkiCalvinWeb1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Animals animal = new Animals("Cow", 3);
            ViewBag.animalName = animal.getName;
            ViewBag.animalAge = animal.getAge;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}