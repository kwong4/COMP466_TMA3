<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Computer.aspx.cs" Inherits="Computer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .computer_image {
            height: 162px;
            width: 181px;
            border: thin #000080 solid;
            display: block;
            position: relative;
            top: 0px;
            left: 0px;
        }
        .auto-style3 {
            width: 1070px;
            margin-left: 280px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Computers</h1>
<p>
    Please take a look at our available options.</p>
<p>
    Please click either &quot;View Details&quot; to see further details and customizations or &quot;Add to Cart&quot; to begin steps of purchase.</p>
    <div>
        <hr />
        <h2>Custom Build</h2>
        <div style ="float:left;">
            <img alt="" class="computer_image" src="computer.png" />
        </div>
        <div class="auto-style3">
            <ul>
                <li>Pick your own parts from scratch!</li>
            </ul>


        </div>
        &nbsp;&nbsp;<br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="View_Details_1" runat="server" Text="View Details" OnClick="View_Details_1_Click"/>
        <br />
        <br />
        <br />
        <br />
    </div>
    <div>
        <hr />
        <h2>
            <asp:Label ID="PreMade1_Label" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; $
            <asp:Label ID="PreMadeCost1_Label" runat="server"></asp:Label>
        </h2>
        <div style ="float:left;">
            <img alt="" class="computer_image" src="computer.png" />
        </div>
        <div class="auto-style3">
            <ul>
                <li><strong>OS:</strong>
                    <asp:Label ID="OS_Label1" runat="server"></asp:Label>
                </li>
                <li><strong>CPU:</strong>
                    <asp:Label ID="CPU_Label1" runat="server"></asp:Label>
                </li>
                <li><strong>RAM:</strong>
                    <asp:Label ID="RAM_Label1" runat="server"></asp:Label>
                </li>
                <li><strong>Hard Drive:</strong>
                    <asp:Label ID="HD_Label1" runat="server"></asp:Label>
                </li>
                <li><strong>Display:</strong>
                    <asp:Label ID="Display_Label1" runat="server"></asp:Label>
                </li>
                <li><strong>Sound Card:</strong>
                    <asp:Label ID="SC_Label1" runat="server"></asp:Label>
                </li>
            </ul>


        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="View_Details_2" runat="server" Text="View Details" OnClick="View_Details_2_Click"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Add_to_Cart_2" runat="server" Text="Add to Cart" OnClick="Add_to_Cart_2_Click" />
        <br />
        <br />
    </div>
    <div>
        <hr />
        <h2>
            <asp:Label ID="PreMade2_Label" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; $
            <asp:Label ID="PreMadeCost2_Label" runat="server"></asp:Label>
        </h2>
        <div style ="float:left;">
            <img alt="" class="computer_image" src="computer.png" />
        </div>
        <div class="auto-style3">
            <ul>
                <li><strong>OS:</strong>
                    <asp:Label ID="OS_Label2" runat="server"></asp:Label>
                </li>
                <li><strong>CPU:</strong>
                    <asp:Label ID="CPU_Label2" runat="server"></asp:Label>
                </li>
                <li><strong>RAM:</strong>
                    <asp:Label ID="RAM_Label2" runat="server"></asp:Label>
                </li>
                <li><strong>Hard Drive:</strong>
                    <asp:Label ID="HD_Label2" runat="server"></asp:Label>
                </li>
                <li><strong>Display:</strong>
                    <asp:Label ID="Display_Label2" runat="server"></asp:Label>
                </li>
                <li><strong>Sound Card:</strong>
                    <asp:Label ID="SC_Label2" runat="server"></asp:Label>
                </li>
            </ul>


        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="View_Details_3" runat="server" Text="View Details" OnClick="View_Details_3_Click"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Add_to_Cart_3" runat="server" Text="Add to Cart" OnClick="Add_to_Cart_3_Click" />
        <br />
        <br />
    </div>
    <div>
        <hr />
        <h2>
            <asp:Label ID="PreMade3_Label" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; $
            <asp:Label ID="PreMadeCost3_Label" runat="server"></asp:Label>
        </h2>
        <div style ="float:left;">
            <img alt="" class="computer_image" src="computer.png" />
        </div>
        <div class="auto-style3">
            <ul>
                <li><strong>OS:</strong>
                    <asp:Label ID="OS_Label3" runat="server"></asp:Label>
                </li>
                <li><strong>CPU:</strong>
                    <asp:Label ID="CPU_Label3" runat="server"></asp:Label>
                </li>
                <li><strong>RAM:</strong>
                    <asp:Label ID="RAM_Label3" runat="server"></asp:Label>
                </li>
                <li><strong>Hard Drive:</strong>
                    <asp:Label ID="HD_Label3" runat="server"></asp:Label>
                </li>
                <li><strong>Display:</strong>
                    <asp:Label ID="Display_Label3" runat="server"></asp:Label>
                </li>
                <li><strong>Sound Card:</strong>
                    <asp:Label ID="SC_Label3" runat="server"></asp:Label>
                </li>
            </ul>


        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="View_Details_4" runat="server" Text="View Details" OnClick="View_Details_4_Click"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Add_to_Cart_4" runat="server" Text="Add to Cart" OnClick="Add_to_Cart_4_Click" />
        <br />
        <br />
    </div>
</asp:Content>

