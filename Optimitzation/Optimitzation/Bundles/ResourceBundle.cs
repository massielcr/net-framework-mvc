using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Optimitzation.Bundles {
    public class ResourceBundle : ScriptBundle {

        public ResourceBundle(string virtualPath)
            :base(virtualPath, null) {
            Builder = new ResourceBundleBuilder();
        }
    }
}