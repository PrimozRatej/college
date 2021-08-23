using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebMatrix.WebData;
namespace dsr_vaja1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            WebSecurity.InitializeDatabaseConnection("UporabnikContext", "Uporabnik", "Id", "ime", autoCreateTables: true);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Igras", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
