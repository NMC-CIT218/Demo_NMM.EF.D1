﻿using System.Web;
using System.Web.Mvc;

namespace Demo_NMM.EF.D1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
