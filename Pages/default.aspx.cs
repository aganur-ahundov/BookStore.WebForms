using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using BookStore.Models;
using BookStore.Models.Helper;

//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

namespace BookStore.Pages
{
    public partial class _default : System.Web.UI.Page
    {
        //class' fields
        private BookContext context = new BookContext();
        protected const int BooksOnPage = 3;



        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                string value = Request.Form["add"];

                int bookID;
                if (int.TryParse(value, out bookID))
                {
                    Book book = context.Books
                                .Where(b => b.ID == bookID)
                                .FirstOrDefault();

                    if (book != null)
                    {
                        SessionHelper.GetCart(Session).AddBookToCart(book,1);
                        SessionHelper.Set(Session, SessionKey.RETURN_URL, Request.RawUrl);

                        //Response.Redirect(
                        //    RouteTable.Routes.GetVirtualPath( null, "cart", null).VirtualPath
                        //    );
                    }
                }
                
            }
        }


        

        //****************************
        //Properties and getters
        //****************************


        public IEnumerable<Book> Books()
        {
                return FilterBooks()
                    .OrderBy(x => x.ID)
                    .Skip((CurrentPage - 1) * BooksOnPage)
                    .Take(BooksOnPage);
        }
        


        protected int CurrentPage
        {
            get
            {
                int page = GetPageFromRequest();
                return (page > MaxPages) ? MaxPages : page; 
            }
        }



        protected int MaxPages
        {            
            get { return (int)Math.Ceiling( (decimal)FilterBooks().Count() / BooksOnPage ); }
        }


        
        protected string GetPagePath( int _num )
        {
           string genre = GetGenreFromRequest();

            return RouteTable.Routes.GetVirtualPath(
                            null, null,
                            new RouteValueDictionary() {
                                { "genre", genre },
                                { "page", _num } }
                            ).VirtualPath;
        }
        
        //
        //*********************************************************
        //


        //******************************************************
        //Private helper methods
        //******************************************************

        private IEnumerable<Book> FilterBooks()
        {
            IEnumerable<Book> books = context.Books;
            string genre = GetGenreFromRequest();

            return genre == null ? books
                : books.Where(g => g.Genre == genre);
        }



        private string GetGenreFromRequest()
        {
            return (string)RouteData.Values["genre"]
                ?? Request.QueryString["genre"];
        }



        private int GetPageFromRequest()
        {
            int page;
            string value = (string)RouteData.Values["page"]
                ?? Request.QueryString["page"];

            page = ((value != null) && int.TryParse(value, out page))
                    ? page : 1;

            return page;
        }

        //*********************************************************************
    }
}