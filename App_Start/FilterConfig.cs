﻿using System.Web;
using System.Web.Mvc;

namespace SimpleProject_server_api
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
