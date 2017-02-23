using System;
using System.Linq;
using System.Web.Routing;
using System.Collections.Generic;
using BookStore.Models;
using BookStore.Models.Helper;

namespace BookStore.Pages
{
    public partial class CartView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int bookID;
                string value = Request["remove"];

                if (int.TryParse(value, out bookID))
                {
                    BookContext bc = new BookContext();

                    Book bookToRemove = bc.Books
                                        .Where(b => b.ID == bookID)
                                        .FirstOrDefault();

                    if (bookToRemove != null)
                        SessionHelper.GetCart(Session).RemoveLine(bookToRemove);
                }
            }
        }


        public IEnumerable<CartLine> GetLines()
        {
            return SessionHelper.GetCart(Session).Lines;
        }


        public string ReturnURL
        {
            get { return SessionHelper.Get<string>(Session, SessionKey.RETURN_URL); }
        }


        public string CashboxURL
        {
            get {
                return RouteTable.Routes
                  .GetVirtualPath(null, "cashbox", null)
                  .VirtualPath;
            }
        }


        public decimal CartTotal
        {
            get { return SessionHelper.GetCart(Session).ComputeTotalSum(); }
        }


    }
}