<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CartSummary.ascx.cs" Inherits="BookStore.Control.CartSummary" %>

<div id="cart-summary">
    Кол-во книг в корзине: 
    <span id="csQuantity" runat="server"></span>,
    <span id="csTotalSum" runat="server"></span>
    <a id="cartLink" runat="server">Корзина</a>
</div>