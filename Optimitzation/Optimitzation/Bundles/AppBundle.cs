using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Optimitzation.Bundles {
    public class AppBundle : Bundle {

        public AppBundle(string virtualPath) 
            : base(virtualPath, new JsMinify(), new JsTimeStampTransform()) {

            IncludeDirectory("~/Scripts/app/", "*.js");
        }
    }
}