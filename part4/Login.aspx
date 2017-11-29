<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {}
        .auto-style4 {}
        .auto-style5 {
            margin-left: 120px;
        }
        .auto-style6 {
            margin-left: 120px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>LOG IN</h1>
<p>
    Please enter your username and password; Register if you don&#39;t have an account.</p>
    <p>
        Please click <a href="RecoverPassword.aspx">here</a> if you wish to recover your password.</p>
<h2>
    Login</h2>
    <h4>
        Username:&nbsp;&nbsp;
        <asp:TextBox ID="Username_Input" runat="server" CssClass="auto-style4" Width="180px"></asp:TextBox>
</h4>
    <h4>
        Password:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Password_Input" type="password" runat="server" CssClass="auto-style3" Width="184px"></asp:TextBox>
</h4>
    <p class="auto-style6">
        <asp:Label ID="Invalid_Error" runat="server" ForeColor="Red"></asp:Label>
</p>
    <p class="auto-style5">
        <asp:Button ID="Login_Submit" runat="server" OnClick="Login_Submit_Click" Text="Log in" />
</p>
</asp:Content>

