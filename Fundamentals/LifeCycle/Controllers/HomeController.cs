using LifeCycle.Extensions;
using LifeCycle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeCycle.Controllers
{
    [GlobalFilter]
    public class HomeController : CustomController
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

        [ActionFilter1(Order = 1)]
        [ActionFilter2(Order = 2)]
        [AuthorizationFilter]
        public ActionResult Filters()
        {
            return View();
        }

        public ActionResult Person()
        {
            return JsonNet(new Person
            {
               FirstName = "Bob",
               LastName =  "Doe"
            });
        }
    }
}