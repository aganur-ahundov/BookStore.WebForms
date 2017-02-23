using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.ModelBinding;
using BookStore.Models;
using BookStore.Models.Helper;
using BookStore.Models.DbRepository;

namespace BookStore.Pages
{
    public partial class Cashbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            messageForm.Visible = false;
            orderForm.Visible = true;

            if(IsPostBack)
            {
                Order myOrder = new Order();

                if (TryUpdateModel(myOrder, new FormValueProvider(ModelBindingExecutionContext)))
                {
                    myOrder.OrderLines = new List<OrderLine>();

                    Cart myCart = SessionHelper.GetCart(Session);

                    foreach(CartLine line in myCart.Lines )
                    {
                        myOrder.OrderLines.Add(new OrderLine
                        {
                            Order = myOrder,
                            Book = line.Book,
                            Quantity = line.Quantity
                        });
                    }

                    new Repository().SaveOrder(myOrder);
                    myCart.clear();

                    messageForm.Visible = true;
                    orderForm.Visible = false;
                }

            }
        }
    }
}