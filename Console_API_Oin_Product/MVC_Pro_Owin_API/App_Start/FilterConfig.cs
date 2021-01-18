using System.Web;
using System.Web.Mvc;

namespace MVC_Pro_Owin_API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
