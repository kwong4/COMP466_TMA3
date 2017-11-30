<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Orders.aspx.cs" Inherits="Orders" validateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Orders</h2>
    <h4>
        <asp:Label ID="Order_info" runat="server"></asp:Label>
    </h4>
        <asp:CheckBoxList ID="orderBox" runat="server">
        </asp:CheckBoxList>
    <br />
    <asp:Button ID="Delete_Order_Checkboxes" runat="server" OnClick="Delete_Orders_Click" Text="Remove" />
</asp:Content>

