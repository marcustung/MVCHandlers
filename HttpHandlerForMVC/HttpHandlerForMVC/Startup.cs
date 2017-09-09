using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HttpHandlerForMVC.Startup))]
namespace HttpHandlerForMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
