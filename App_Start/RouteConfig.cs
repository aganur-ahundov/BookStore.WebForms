using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace BookStore.App_Start
{
    public class RouteConfig
    {
        public static void RouteRegister( RouteCollection routes )
        {
            routes.MapPageRoute(null, "list/{genre}/{page}", "~/Pages/default.aspx");
            routes.MapPageRoute(null, "list/{page}", "~/Pages/default.aspx");
            routes.MapPageRoute(null, "", "~/Pages/default.aspx");
            routes.MapPageRoute(null, "list", "~/Pages/default.aspx");
        }
    }
}