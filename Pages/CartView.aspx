<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartView.aspx.cs" Inherits="BookStore.Pages.CartView" 
    MasterPageFile="~/Pages/Store.Master" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="contentBody" runat="server">
        <div id="content">
                <table id="cartTable">
                    <thead>
                        <tr>
                            <td>Кол-во</td>
                            <td>Название</td>
                            <td>Цена</td>
                            <td>Общая стоимость</td>
                        </tr>
                    </thead>
                    <tbody>
                    
                            <asp:Repeater ItemType="BookStore.Models.CartLine" 
                                SelectMethod="GetLines" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Item.Quantity %></td>
                                        <td><%# Item.Book.Title %></td>
                                        <td><%# Item.Book.Price.ToString("c") %></td>
                                        <td><%# (Item.Book.Price * Item.Quantity).ToString("c") %></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>

                    </tbody>
                    <tfoot>
                        <td colspan"3">Итого:</td>
                        <td><%= CartTotal.ToString("c") %></td>
                    </tfoot>
                    </table>
                <p class="actionButtons">
                <a href="<%= ReturnURL %>">Продолжить покупки</a>
            </p>
        </div>
    </asp:Content>
