using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuildingAppsWithMvc4.Startup))]
namespace BuildingAppsWithMvc4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
