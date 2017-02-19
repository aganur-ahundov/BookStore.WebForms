using System;
using System.Web.Routing;

namespace BookStore.Pages
{
    public partial class Store : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            homeLink.HRef = RouteTable.Routes
                .GetVirtualPath(null, null)
                .VirtualPath;
        }
    }
}