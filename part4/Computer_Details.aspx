<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Computer_Details.aspx.cs" Inherits="Computer_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .computer_image {
            height: 254px;
            width: 345px;
        }
        .auto-style3 {
            width: 894px;
            float: left;
        }
        .auto-style4 {}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Computer Details</h1>
    <h2>
        <asp:Label ID="Computer_Detail_Label" runat="server"></asp:Label>
    </h2>
        <div style ="float:left;">
            <img alt="" class="computer_image" src="computer.png" />
        </div>
        <div class="auto-style3">
                <p><strong>OS:</strong>
                    <asp:DropDownList ID="OSDropDownList" runat="server" OnSelectedIndexChanged="SelectedIndexChanged" AutoPostBack="True" DataSourceID="OSLinqDataSource" DataTextField="Name" DataValueField="ID">
                    </asp:DropDownList>
                    <asp:LinqDataSource ID="OSLinqDataSource" runat="server" ContextTypeName="ShopNowDataContext" EntityTypeName="" TableName="Os">
                    </asp:LinqDataSource>
                    <asp:Label ID="OSCost" runat="server"></asp:Label>
                </p>
                <p><strong>CPU:</strong> 
                    <asp:DropDownList ID="CPUDropDownList" runat="server" OnSelectedIndexChanged="SelectedIndexChanged" AutoPostBack="True" DataSourceID="CPULinqDataSource" DataTextField="Name" DataValueField="ID">
                    </asp:DropDownList>
                    <asp:LinqDataSource ID="CPULinqDataSource" runat="server" ContextTypeName="ShopNowDataContext" EntityTypeName="" TableName="CPUs">
                    </asp:LinqDataSource>
                    <asp:Label ID="CPUCost" runat="server"></asp:Label>
                </p>
                <p><strong>RAM:</strong>
                    <asp:DropDownList ID="RAMDropDownList" runat="server" OnSelectedIndexChanged="SelectedIndexChanged" AutoPostBack="True" DataSourceID="RAMLinqDataSource" DataTextField="Name" DataValueField="ID">
                    </asp:DropDownList>
                    <asp:LinqDataSource ID="RAMLinqDataSource" runat="server" ContextTypeName="ShopNowDataContext" EntityTypeName="" TableName="RAMs">
                    </asp:LinqDataSource>
                    <asp:Label ID="RAMCost" runat="server"></asp:Label>
                </p>
                <p><strong>HARD DRIVE:</strong> 
                    <asp:DropDownList ID="HardDriveDropDownList" runat="server" OnSelectedIndexChanged="SelectedIndexChanged" AutoPostBack="True" DataSourceID="HardDriveLinqDataSource" DataTextField="Name" DataValueField="ID">
                    </asp:DropDownList>
                    <asp:LinqDataSource ID="HardDriveLinqDataSource" runat="server" ContextTypeName="ShopNowDataContext" EntityTypeName="" TableName="HardDrives">
                    </asp:LinqDataSource>
                    <asp:Label ID="HDCost" runat="server"></asp:Label>
                </p>
                <p><strong>DISPLAY:</strong> 
                    <asp:DropDownList ID="DisplayDropDownList" runat="server" OnSelectedIndexChanged="SelectedIndexChanged" AutoPostBack="True" DataSourceID="DisplayLinqDataSource" DataTextField="Name" DataValueField="ID">
                    </asp:DropDownList>
                    <asp:LinqDataSource ID="DisplayLinqDataSource" runat="server" ContextTypeName="ShopNowDataContext" EntityTypeName="" TableName="Monitors">
                    </asp:LinqDataSource>
                    <asp:Label ID="DisplayCost" runat="server"></asp:Label>
                </p>
                <p><strong>SOUND CARD:</strong> 
                    <asp:DropDownList ID="SoundCardDropDownList" runat="server" OnSelectedIndexChanged="SelectedIndexChanged" AutoPostBack="True" DataSourceID="SoundCardLinqDataSource" DataTextField="Name" DataValueField="ID">
                    </asp:DropDownList>
                    <asp:LinqDataSource ID="SoundCardLinqDataSource" runat="server" ContextTypeName="ShopNowDataContext" EntityTypeName="" TableName="SoundCards">
                    </asp:LinqDataSource>
                    <asp:Label ID="SCCost" runat="server"></asp:Label>
                </p>
                <h2>&nbsp;Cost:&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Computer_Cost_Label" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Detail_Add_to_Cart" runat="server" CssClass="auto-style4" Height="30px" Text="Add to Cart" Width="104px" OnClick="Detail_Add_to_Cart_Click" />
                </h2>


        </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

