using System;
using System.Linq;
using System.Web.Routing;
using BookStore.Models.Helper;


namespace BookStore.Control
{
    public partial class CartSummary : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            csTotalSum.InnerText = SessionHelper.GetCart(Session)
                .ComputeTotalSum()
                .ToString("c");

            csQuantity.InnerText = SessionHelper.GetCart(Session)
                .Lines
                .Sum(b => b.Quantity)
                .ToString();

            cartLink.HRef = RouteTable.Routes
                .GetVirtualPath(null, "cart", null)
                .VirtualPath;
        }
    }
}