using System.Web;
using System.Web.Mvc;

namespace Quan_Ly_Diem_Thi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
