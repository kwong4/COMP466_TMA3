<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="Cart" validateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Cart:</h1>
<p>
    <asp:Label ID="Cart_Label" runat="server"></asp:Label>
    </p>
    <p>
        <asp:CheckBoxList ID="cartBox" runat="server">
        </asp:CheckBoxList>
    </p>
<p>
    <asp:Button ID="checkout_Button" runat="server" Text="Checkout" OnClick="checkout_Button_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Delete_Checkboxes" runat="server" OnClick="Delete_Checkboxes_Click" Text="Delete Selected" />
</p>
</asp:Content>

