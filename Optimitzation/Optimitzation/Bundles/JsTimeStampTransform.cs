using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Optimitzation.Bundles {
    public class JsTimeStampTransform : IBundleTransform {

        public void Process(BundleContext context, BundleResponse response) {
            response.Content = string.Format("/* Time Stamp: {0} */ {1}", DateTime.Now.ToString(), response.Content);
        }
    }
}