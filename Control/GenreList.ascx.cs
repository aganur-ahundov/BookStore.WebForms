using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStore.Models;

namespace BookStore.Control
{
    public partial class GenreList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string CreateHomeLinkHtml()
        {
            string path = RouteTable.Routes.GetVirtualPath( null, null ).VirtualPath;
            return String.Format(@"<a href='{0}'>Главная</a>", path);
        }

        protected IEnumerable<string> GetGenreList()
        {
            return new BookContext().Books
                .Select(g => g.Genre)
                .Distinct()
                .OrderBy(x => x);
        }

        protected string CreateGenreLinkHtml(string _genre)
        {
            string selectedCategory = (string)Page.RouteData.Values["genre"]
                ?? Request.QueryString["genre"];

            string path = RouteTable.Routes.GetVirtualPath(
                  null
                , null
                , new RouteValueDictionary(){ { "genre", _genre }, { "page", "1" } }).VirtualPath;

            return String.Format(@"<a href='{0}' {1}>{2}</a>"
                    , path
                    , selectedCategory == _genre ? "class='selected'" : ""
                    , _genre);
        }
    }
}