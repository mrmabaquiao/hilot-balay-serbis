using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeService.Web.Startup))]
namespace HomeService.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
