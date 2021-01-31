using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Optimitzation.Startup))]
namespace Optimitzation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
