using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Optimization;

namespace Optimitzation.Bundles {
    public class TemplateBundleBuilder : IBundleBuilder {
        public string BuildBundleContent(Bundle bundle, BundleContext context, IEnumerable<BundleFile> files) {
            var sb = new StringBuilder();
            foreach (var file in files) {
                var fileName = file.IncludedVirtualPath.Split('/').Last();
                using (var streamReader = new StreamReader(BundleTable.VirtualPathProvider.GetFile(file.IncludedVirtualPath).ToString()) {

                }
            }
        }
    }
}