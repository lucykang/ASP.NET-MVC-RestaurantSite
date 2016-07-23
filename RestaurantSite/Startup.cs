using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantSite.Startup))]
namespace RestaurantSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
