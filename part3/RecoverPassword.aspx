<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RecoverPassword.aspx.cs" Inherits="RecoverPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Recover Password</h1>
    <p>
        Please enter the email associated with the account:</p>
    <p>
        <asp:TextBox ID="Recover_Password_Email" runat="server" CssClass="auto-style3" Width="288px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Recover_Password_Button" runat="server" OnClick="Recover_Password_Button_Click" Text="Submit" />
    </p>
</asp:Content>

