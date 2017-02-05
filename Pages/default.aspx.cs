using System;
using System.Collections.Generic;
using System.Linq;
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


        protected IEnumerable<Book> Books
        {
            get
            {
                return context.Books
                    .OrderBy(x => x.ID)
                    .Skip((CurrentPage - 1) * BooksOnPage)
                    .Take(BooksOnPage);
                    
            }
        }


        protected int CurrentPage
        {
            get
            {
                int page;
                string value = Request.QueryString["page"];

                page = (value != null) && int.TryParse(value, out page) ? page : 1;
                return (page > MaxPages) ? MaxPages : page; 
            }
        }

        protected int MaxPages
        {            
            get { return (int)Math.Ceiling( (decimal)context.Books.Count() / BooksOnPage ); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}