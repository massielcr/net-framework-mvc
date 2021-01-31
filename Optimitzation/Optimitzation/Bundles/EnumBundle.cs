using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Optimization;

namespace Optimitzation.Bundles {
    public class EnumBundle : ScriptBundle{
        private readonly List<Type> _enumTypes = new List<Type>();

        public EnumBundle(string virtualPath)
            :base(virtualPath, null) {

        }

        public EnumBundle Include(params Type[] types) {
            if(types.ToList().Any(t => !t.IsEnum)) {
                throw new InvalidOperationException("You can only add an object of type enum");
            }

            _enumTypes.AddRange(types);
            return this;
        }

        public override BundleResponse GenerateBundleResponse(BundleContext context) {

            var resources = EnumerateFiles(context).ToList();
            var bundleContent = BuildEnumContext(context, _enumTypes);
            var response = ApplyTransforms(context, bundleContent, resources);

            response.ContentType = "text/javascript";

            return response;
        }

        private string BuildEnumContext(BundleContext context, List<Type> _enumTypes) {
            var sb = new StringBuilder();

            foreach (var type in _enumTypes) {
                var values = Enum.GetValues(type).Cast<object>();
                var dict = values.ToDictionary(e => e.ToString(), Convert.ToUInt32);
                var json = JsonConvert.SerializeObject(dict);
                var script = string.Format("var Enums = Enums || {{}}; Enums.{0} = {1};", type.Name, json);

                sb.Append(script);
            }

            return sb.ToString();
        }

        public override Bundle Include(params string[] virtualPaths) {
            throw new NotSupportedException("Not Supported");
        }

        public override Bundle Include(string virtualPath, params IItemTransform[] transforms) {
            throw new NotSupportedException("Not Supported");
        }

        public override Bundle IncludeDirectory(string directoryVirtualPath, string searchPattern) {
            throw new NotSupportedException("Not Supported");
        }

        public override Bundle IncludeDirectory(string directoryVirtualPath, string searchPattern, bool searchSubdirectories) {
            throw new NotSupportedException("Not Supported");
        }
    }
}