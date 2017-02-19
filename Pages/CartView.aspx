<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartView.aspx.cs" Inherits="BookStore.Pages.CartView" 
    MasterPageFile="~/Pages/Store.Master" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="contentBody" runat="server">
        <div id="content">
                <table id="cartTable">
                        <thead>
                            <tr>
                                <th>Кол-во</th>
                                <th>Название</th>
                                <th>Цена</th>
                                <th>Общая стоимость</th>
                            </tr>
                        </thead>
                        <tbody>
                    
                                <asp:Repeater ItemType="BookStore.Models.CartLine" 
                                    SelectMethod="GetLines" EnableViewState="false" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><%# Item.Quantity %></td>
                                            <td><%# Item.Book.Title %></td>
                                            <td><%# Item.Book.Price.ToString("c") %></td>
                                            <td><%# (Item.Book.Price * Item.Quantity).ToString("c") %></td>
                                             <td> 
                                                 <button name="remove" class="cart-button" type="submit"
                                                     value="<%# Item.Book.ID %>" runat="server">
                                                    Убрать из корзины
                                                  </button>
                                             </td>   
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>

                        </tbody>
                        <tfoot>
                            <tr>
                                <td colspan="3">Итого:</td>
                                <td><%= CartTotal.ToString("c") %></td>
                            </tr>
                        </tfoot>
                </table>

                <p class="cart-button">
                        <a href="<%= ReturnURL %>">Продолжить покупки</a>
                </p>
        </div>
    </asp:Content>
