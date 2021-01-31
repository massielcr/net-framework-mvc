using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecureCookies.Startup))]
namespace SecureCookies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
