using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Movies_DM.Startup))]
namespace MVC_Movies_DM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
