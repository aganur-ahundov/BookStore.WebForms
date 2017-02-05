using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        //public Book(string _title, string _author, string _description, string _genre, decimal _price)
        //{
        //    Title = _title;
        //    Author = _author;
        //    Genre = _genre;
        //    Price = _price;
        //}

        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}