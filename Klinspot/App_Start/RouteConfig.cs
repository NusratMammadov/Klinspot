using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Klinspot
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ServiceDetails",
                url: "service/{slug}",
                defaults: new { controller = "services", action = "details", slug = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "NewsList",
                url: "news",
                defaults: new { controller = "news", action = "index" }
            );

            routes.MapRoute(
                name: "NewsDetails",
                url: "news/{slug}",
                defaults: new { controller = "news", action = "details", slug = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "home", action = "index", id = UrlParameter.Optional }
            );
        }
    }
}
