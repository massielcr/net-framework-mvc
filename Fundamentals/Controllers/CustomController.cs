using Fundamentals.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fundamentals.Controllers
{
    public class CustomController : Controller
    {
        public static ActionResult JsonNet(object data)
        {
            return new JsonNetResult() { Data = data };
        }
    }
}