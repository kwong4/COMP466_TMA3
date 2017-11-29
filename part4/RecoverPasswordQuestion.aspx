<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RecoverPasswordQuestion.aspx.cs" Inherits="RecoverPasswordQuestion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Recover Password - Security Question:</h1>
    <p>
        <asp:Label ID="Recover_Password_Security" runat="server"></asp:Label>
    </p>
    <div id="Recover_Password_UserFields">
        <asp:Label ID="Recover_Password_SecurityQuestion" runat="server"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="Recover_Password_UserInput" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Invalid_RecoverQuestion_Error" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Submit_SecurityQuestion" runat="server" OnClick="Submit_SecurityQuestion_Click" Text="Submit" />
    </div>
</asp:Content>

