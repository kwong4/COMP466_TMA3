<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Account_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Register an Account!</h1>
<h3>
    Sign Up for a New Account</h3>
    <h4>
        Username:&nbsp;&nbsp;
        <asp:TextBox ID="Register_Username_Input" runat="server" CssClass="auto-style4" Width="180px"></asp:TextBox>
</h4>
    <h4>
        Password:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Register_Password_Input" type="password" runat="server" CssClass="auto-style3" Width="184px"></asp:TextBox>
</h4>
    <h4>
        Confirm Password:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="RegisterConfirm_Password_Input" type="password" runat="server" CssClass="auto-style3" Width="184px"></asp:TextBox>
</h4>
    <h4>
        E-mail:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Register_Email_Input" type="email" runat="server" CssClass="auto-style3" Width="184px"></asp:TextBox>
</h4>
    <h4>
        Security Question:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Register_Question_Input" runat="server" CssClass="auto-style3" Width="184px"></asp:TextBox>
</h4>
    <h4>
        Security Answer:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Register_Answer_Input" runat="server" CssClass="auto-style3" Width="184px"></asp:TextBox>
</h4>
    <p class="auto-style6">
        <asp:Label ID="Invalid_Register_Error" runat="server" ForeColor="Red"></asp:Label>
</p>
    <p class="auto-style5">
        <asp:Button ID="Register_Submit" runat="server" OnClick="Login_Submit_Click" Text="Register" />
</p>
</asp:Content>

