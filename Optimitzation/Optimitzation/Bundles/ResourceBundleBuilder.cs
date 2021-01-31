using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Web;
using System.Web.Optimization;

namespace Optimitzation.Bundles {
    public class ResourceBundleBuilder : IBundleBuilder {

        public string BuildBundleContent(Bundle bundle, BundleContext context, IEnumerable<BundleFile> files) {

            var content = new StringBuilder();

            foreach (var file in files) {
                var resourceDictionary = new Dictionary<string, string>();
                var fileName = file.IncludedVirtualPath.Replace(".resx", string.Empty).Split('/').Last();
                var resource = GetType()
                              .Assembly.GetManifestResourceNames()
                              .FirstOrDefault(t => t.Contains(fileName + ".resources"));

                if(resource != null) {
                    using (var stream = GetType().Assembly.GetManifestResourceStream(resource))
                    using (var reader = new ResourceReader(stream)) {
                        foreach (DictionaryEntry entry in reader) {
                            resourceDictionary.Add(entry.Key.ToString(), entry.Value.ToString());
                        }
                    }

                }

                var serializedDictionary = JsonConvert.SerializeObject(resourceDictionary);
                var javascript = string.Format("var Resources = Resources || {{}}; Resources.{0} = {1}", fileName, serializedDictionary);
                content.AppendLine(javascript);
            }

            return content.ToString();
        }
    }
}