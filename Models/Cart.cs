using System;
using System.Collections.Generic;
using System.Linq;


namespace BookStore.Models
{
    public class CartLine
    {
        public int Quantity { get; set; }
        public Book Book { get; set; }
    }


    public class Cart
    {
        private List<CartLine> m_cartLineList = new List<CartLine>();

        

        public IEnumerable<CartLine> Lines
        {
            get { return m_cartLineList; }
        }


        public void AddBookToCart(Book _book, int _quantity)
        {
            CartLine line = m_cartLineList
                .Where(b => b.Book.ID == _book.ID)
                .FirstOrDefault();

            if(line == null)
            {
                m_cartLineList.Add( new CartLine()
                {
                    Quantity = _quantity,
                    Book = _book                    
                });

            }
            else
            {
                line.Quantity += _quantity;
            }
        }


        public void RemoveLine(Book _book)
        {
            m_cartLineList.RemoveAll(b => b.Book.ID == _book.ID);
        }


        public decimal ComputeTotalSum()
        {
            return m_cartLineList.Sum(b => b.Quantity * b.Book.Price);
        }


        public void clear()
        {
            m_cartLineList.Clear();
        }
    }
}