using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravellinDollarWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "TravellingDollar";

            return View();
        }

        public ActionResult Privacy()
        {
            ViewBag.Title = "TravellingDollar - Privacy Policy";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "TravellingDollar - About";
            return View();
        }
    }
}
