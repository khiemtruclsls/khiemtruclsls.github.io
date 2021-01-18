using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Movies_WCF.Startup))]
namespace MVC_Movies_WCF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
