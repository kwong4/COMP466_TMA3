<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Cart:</h1>
<p>
    Your Cart is empty.</p>
<p>
    <asp:Button ID="checkout_Button" runat="server" Text="Checkout" PostBackUrl="~/Checkout.aspx" />
</p>
</asp:Content>

