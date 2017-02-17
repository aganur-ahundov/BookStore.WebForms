<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="BookStore.Pages._default" 
    MasterPageFile="~/Pages/Store.Master"%>

<asp:Content ContentPlaceHolderID="contentBody" runat="server">
        <div id="content">
            <asp:Repeater ItemType="BookStore.Models.Book" 
                SelectMethod="Books" runat="server" >
                <ItemTemplate>

                    <div class="item" >
                        <h2><%# Item.Title %></h2>
                        <h3><%# Item.Author %></h3>
                        <p> <%# Item.Description %></p>
                        <h4><%# Item.Price.ToString("c") %></h4>
                    </div>

                    <button name="add" type="submit" value="<%# Item.ID %>" runat="server">
                        Добавить в корзину
                    </button>

                </ItemTemplate>
            </asp:Repeater>
        </div>

        <div id="pageNum">
                <%
                    for(int i = 1; i <= MaxPages; i++)
                    {
                        Response.Write(
                            String.Format(@"
                                        <a href='{0}' class={1}>{2}</a>"
                                       , GetPagePath(i)
                                       , (i == CurrentPage)? "selected" : ""
                                       ,i)
                            );
                    }
                     %>
        </div>
</asp:Content>
