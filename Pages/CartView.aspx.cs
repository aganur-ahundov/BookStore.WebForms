using System;
using System.Collections.Generic;
using BookStore.Models;
using BookStore.Models.Helper;

namespace BookStore.Pages
{
    public partial class CartView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public IEnumerable<CartLine> GetLines()
        {
            return SessionHelper.GetCart(Session).Lines;
        }


        public string ReturnURL
        {
            get { return SessionHelper.Get<string>(Session, SessionKey.RETURN_URL); }
        }

        public decimal CartTotal
        {
            get { return SessionHelper.GetCart(Session).ComputeTotalSum(); }
        }


    }
}