using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public bool GiftWrap { get; set; }
        public bool Dispatched { get; set; }

        public virtual List<OrderLine> OrderLines { get; set; }
    }


    public class OrderLine
    {
        public int OrderLineID { get; set; }
        public int Quantity { get; set; }
        public Book Book { get; set; }
        public Order Order { get; set; }
    }

}