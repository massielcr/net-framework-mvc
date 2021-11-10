using Fundamentals.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fundamentals.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        [IsMobile]
        public ActionResult Details()
        {
            ViewBag.Message = "Message: This is running on a mobile";

            return View();
        }

        public ActionResult Details(string name)
        {
            ViewBag.Message = "Message: This is not running on a mobile";

            return View();
        }
    }
}