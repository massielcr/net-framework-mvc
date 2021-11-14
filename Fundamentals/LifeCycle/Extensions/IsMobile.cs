using System;
using System.Reflection;
using System.Web.Mvc;

namespace LifeCycle.Extensions
{
    public class IsMobile : ActionMethodSelectorAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            return controllerContext.HttpContext.Request.Browser.IsMobileDevice; 
        }
    }
}