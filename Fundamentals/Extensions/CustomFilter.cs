using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fundamentals.Extensions
{
    public class ActionFilter1 : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            HttpContext.Current.Application["Order"] += " Action 1 Executed <br/>";
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext.Current.Application["Order"] += " Action 1 Executing <br/>";
        }
    }

    public class ActionFilter2 : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            HttpContext.Current.Application["Order"] += " Action 2 Executed <br/>";
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext.Current.Application["Order"] += " Action 2 Executing <br/>";
        }
    }

    public class GlobalFilter : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            HttpContext.Current.Application["Order"] += " Global Executed <br/>";
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext.Current.Application["Order"] += " Global Executing <br/>";
        }
    }

    public class AuthorizationFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            HttpContext.Current.Application["Order"] += " Authorization <br/>";
        }
    }
}