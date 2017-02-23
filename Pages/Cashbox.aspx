<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cashbox.aspx.cs" 
    Inherits="BookStore.Pages.Cashbox" 
    MasterPageFile="~/Pages/Store.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentBody" runat="server">

    <div id="content">
        
        <div id="orderForm" runat="server">
            <h3>Ваш заказ</h3>
            <p>Для того, что бы завершить процесс оформления заказа - заполните форму ниже</p>

            <div class="cashbox-field">
                <label for="name">Имя: </label>
                <input id="name" name="name" runat="server" />
            </div>

        
            <div class="cashbox-field">
                <label for="city">Город: </label>
                <input id="city" name="city" runat="server" />
            </div>

            <div class="cashbox-field">
                <label for="address">Адрес: </label>
                <input id="address" name="address" runat="server" />
            </div>

        
            <div class="cashbox-field" >
                <input type="checkbox" id="giftwrap" name="giftwrap" value="true" />
                Использовать подарочную упаковку?
            </div>

          
                <p>
                    <button class="action-button" type="submit">Оформить заказ</button>
                </p>
    
        </div>

        <div id="messageForm" runat="server">
            <h2>Спасибо!</h2>
            Спасибо, что выбрали наш интернет-магазин. Ваш заказ будет отправлен в ближайшее время.
        </div>

    </div>

</asp:Content>