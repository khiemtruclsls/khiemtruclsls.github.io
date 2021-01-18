using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Pro_Owin_API.Startup))]
namespace MVC_Pro_Owin_API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
