﻿using Fundamentals.Extensions;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Fundamentals
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //custom controller
            ControllerBuilder.Current.SetControllerFactory(new ParameterControllerFactory());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //use custom view engine first and razor after it
            ViewEngines.Engines.Insert(0, new ThemeViewEngine());
        }

        protected void Application_PreRequestHandlerExecute()
        {
            Debug.WriteLine("PreExecute");
        }

        protected void Application_PostRequestHandlerExecute()
        {
            Debug.WriteLine("PostExecute");
        }
    }
}
