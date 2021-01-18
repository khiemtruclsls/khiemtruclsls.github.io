using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Confluent.Kafka;
using Owin;

namespace Console_Owin
{

    public class Startup
    {
        public void Configuration(IAppBuilder appbuilder) { 
        HttpConfiguration config = new HttpConfiguration();
        config.Routes.MapHttpRoute("default api", "api/{Controller}/{id}", new { id = RouteParameter.Optional });
            appbuilder.UseWebApi(config);
        }
    }
}
