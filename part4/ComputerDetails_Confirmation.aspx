<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ComputerDetails_Confirmation.aspx.cs" Inherits="ComputeDetails_Confirmation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            font-weight: normal;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Confirmation</h1>
    <p>
        <asp:Label ID="Confirmation_Label" runat="server"></asp:Label>
    </p>
    <h2><span class="auto-style3">Computer:</span>
        <asp:Label ID="OS_Cart_Label" runat="server"></asp:Label>
    </h2>
    <h2><span class="auto-style3">CPU:</span>
        <asp:Label ID="CPU_Cart_Label" runat="server"></asp:Label>
    </h2>
    <h2><span class="auto-style3">RAM:</span>
        <asp:Label ID="RAM_Cart_Label" runat="server"></asp:Label>
    </h2>
    <h2><span class="auto-style3">Hard Drive:</span>
        <asp:Label ID="HD_Cart_Label" runat="server"></asp:Label>
    </h2>
    <h2><span class="auto-style3">Monitor: </span>
        <asp:Label ID="Display_Cart_Label" runat="server"></asp:Label>
    </h2>
    <h2><span class="auto-style3">Sound Card:</span>
        <asp:Label ID="SC_Cart_Label" runat="server"></asp:Label>
    </h2>
    <h1><span class="auto-style3">Cost:</span>
        <asp:Label ID="Cost_Label" runat="server"></asp:Label>
    </h1>
</asp:Content>

