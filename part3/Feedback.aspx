﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Feedback.aspx.cs" Inherits="Feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style3 {}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Feedback</h1>
<p>
    Welcome to the Feedback Form! Please feel free to give us any feedback.</p>
<p>
    Just enter your anonymous message below and hit Submit after your done!</p>
<p>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3" Height="194px" Width="795px" TextMode="MultiLine"></asp:TextBox>
</p>
<p>
    <asp:Button ID="feedback_Button" runat="server" Text="Submit" PostBackUrl="~/FeedbackSubmit.aspx" />
</p>
</asp:Content>

