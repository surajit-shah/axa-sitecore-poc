﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mirabeau.Feature.Forms
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            RouteTable.Routes.MapRoute("SCContactProfiles", "SCContactProfiles/GetContactProfileFields", new { Controller = "SCContactProfiles", Action = "GetContactProfileFields" });
            RouteTable.Routes.MapRoute("SCSearch", "SCSearch/Search", new { Controller = "SCSearch", Action = "Search" });
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
            //routes.MapRoute(
            //    name: "DefaultApi",
            //    url: "api/Sitecore/{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
