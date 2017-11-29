<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>LOG IN</h1>
<p>
    Please enter your username and password; Register if you don&#39;t have an account.</p>
    <p>
        Please click <a href="RecoverPassword.aspx">here</a> if you wish to recover your password.</p>
<p>
    <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/Home.aspx">
    </asp:Login>
</p>
</asp:Content>

