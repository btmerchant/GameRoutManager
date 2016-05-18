using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameRouteManager.Startup))]
namespace GameRouteManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
