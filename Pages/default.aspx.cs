using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using BookStore.Models;

//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

namespace BookStore.Pages
{
    public partial class _default : System.Web.UI.Page
    {
        private BookContext context = new BookContext();
        protected const int BooksOnPage = 3;


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


        private int GetPageFromRequest()
        {
            int page;
            string value = (string)RouteData.Values["page"]
                ?? Request.QueryString["page"];

            page = ((value != null) && int.TryParse(value, out page)) 
                    ? page : 1;

            return page;
        }


        private IEnumerable<Book> FilterBooks()
        {
            IEnumerable<Book> books = context.Books;
            string genre =
                (string)RouteData.Values["genre"]
                ?? Request.QueryString["genre"];

            return genre == null ? books 
                : books.Where( g => g.Genre == genre) ;
        }


        protected string GetPagePath( int _num )
        {
           return RouteTable.Routes.GetVirtualPath(
                            null, null,
                            new RouteValueDictionary() { { "page", _num } }).VirtualPath;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}