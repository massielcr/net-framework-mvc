using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Optimitzation.Bundles {
    public class CustomBundleResolver : IBundleResolver {
        private readonly IBundleResolver _defaultResolver = new BundleResolver(BundleTable.Bundles);

        public IEnumerable<string> GetBundleContents(string virtualPath) {
            return _defaultResolver.GetBundleContents(virtualPath);
        }

        public string GetBundleUrl(string virtualPath) {
            return _defaultResolver.GetBundleUrl(virtualPath);
        }

        public bool IsBundleVirtualPath(string virtualPath) {
            if (virtualPath.Contains("resources")) {
                return false;
            }

            return _defaultResolver.IsBundleVirtualPath(virtualPath);
        }
    }
}