﻿using System.Web;
using System.Web.Mvc;

namespace CodeFirst_QLDT_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
