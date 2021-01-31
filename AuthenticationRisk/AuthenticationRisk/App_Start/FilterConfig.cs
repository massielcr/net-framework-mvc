using System.Web;
using System.Web.Mvc;

namespace AuthenticationRisk {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
