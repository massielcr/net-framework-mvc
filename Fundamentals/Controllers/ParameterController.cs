using Fundamentals.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Fundamentals.Controllers
{
    public class ParameterController : IController
    {
        public ParameterController(ILogger logger)
        {
                // do something with the logger
        }

        public void Execute(RequestContext requestContext)
        {
            HttpContext.Current.Response.Write("This is a Controller with parameters");
        }
    }
}