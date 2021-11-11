using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fundamentals.Extensions
{
    public class ThemeViewEngine : RazorViewEngine
    {
        public ThemeViewEngine()
        {
            ViewLocationFormats = new[] { "~/Themes/{1}/{0}.cshtml" };
            PartialViewLocationFormats = new[] { "~/Themes/{1}/{0}.cshtml" };
        }
    }
}