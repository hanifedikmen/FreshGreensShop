using System.Web.Mvc;
using System.Web.Routing;

namespace FreshGreensShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "About Us",
                url: "about-us",
                defaults: new { controller = "Home", action = "AboutUs" }
            );

            routes.MapRoute(
                name: "Contact Us",
                url: "contact-us",
                defaults: new { controller = "Home", action = "ContactUs" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
