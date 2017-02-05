<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="BookStore.Pages._default" 
    MasterPageFile="~/Pages/Store.Master"%>


<asp:Content ContentPlaceHolderID="contentBody" runat="server">
        <div id="content">
            <%
                foreach(BookStore.Models.Book book in Books)
                {
                    Response.Write(
                        String.Format(@"
                        <div class='item'>
                            <h2>{0}</h2>
                                <h3>{1}</h3>
                                <p>{2}</p>
                            <h4>{3:c}</h4>
                        </div>",
                        book.Title, book.Author, book.Description , book.Price
                        )
                        );
                }
                 %>
        </div>

        <div id="pageNum">
                <%
                    for(int i = 1; i <= MaxPages; i++)
                    {
                        Response.Write(
                            String.Format(@"
                                        <a href='/Pages/default.aspx?page={0}' class={1}>{2} </a>"
                                       ,i
                                       , (i == CurrentPage)? "selected" : ""
                                       ,i)
                            );
                    }
                     %>
        </div>
</asp:Content>
