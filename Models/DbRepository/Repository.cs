using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace BookStore.Models.DbRepository
{
    public class Repository
    {
        private BookContext context = new BookContext();

        public IEnumerable<Book> Books
        {
            get { return context.Books; }
        }

        public IEnumerable<Order> Orders
        {
            get
            {
                return context.Orders
                  .Include(o => o.OrderLines.Select(b => b.Book));  //binding books with there order lines
            }
        }


        public void SaveOrder(Order _order)
        {
            if (_order.OrderID == 0)
            {
                _order = context.Orders.Add(_order);

                foreach (OrderLine line in _order.OrderLines)
                {
                    context.Entry(line.Book).State
                        = EntityState.Modified;
                }
            }
            else
            {
                Order dbOrder = context.Orders.Find(_order.OrderID);

                if(dbOrder != null)
                {
                    dbOrder.Name = _order.Name;
                    dbOrder.GiftWrap = _order.GiftWrap;
                    dbOrder.Dispatched = _order.Dispatched;
                    dbOrder.Address = _order.Address;
                    dbOrder.City = _order.City;
                    
                }
            }

            context.SaveChanges();
        }
    }
}