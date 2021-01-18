using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Owin;

namespace Console_API_Oin_Product
{
    public class Startup
    {
        public void Configuration(IAppBuilder appbuilder)
        {
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute("default api", "api/{Controller}/{id}", new { id = RouteParameter.Optional });
            appbuilder.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            appbuilder.UseWebApi(config);
        }
    }
}
