<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Computer_Details.aspx.cs" Inherits="Computer_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .computer_image {
            height: 254px;
            width: 345px;
        }
        .auto-style3 {
            width: 853px;
        }
        .auto-style4 {}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Computer Details</h1>
    <h2 id="Computer_Detail_Title">&nbsp;</h2>
        <div style ="float:left;">
            <img alt="" class="computer_image" src="http://localhost:62056/computer.png" />
        </div>
        <div class="auto-style3">
                <p><strong>OS:</strong>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="219.99">Windows 10 Pro (64 bit) - 219.99</asp:ListItem>
                        <asp:ListItem Value="209.99">Windows 7 Professional (64 bit) - 209.99</asp:ListItem>
                        <asp:ListItem Value="139.99">Windows 10 Home (64 bit) - 139.99</asp:ListItem>
                    </asp:DropDownList>
                </p>
                <p><strong>CPU:</strong> 
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem Value="499.99">Core i7-7700K Processor, 4.20GHz w/ 8MB Cache - 499.99</asp:ListItem>
                        <asp:ListItem Value="489.99">Core i7-8700K Processor, 3.7GHz w/ 12MB Cache - 489.99</asp:ListItem>
                        <asp:ListItem Value="334.99">Core i5-8600K Processor, 3.5GHz w/ 9MB Cache - 334.99</asp:ListItem>
                        <asp:ListItem Value="259.99">Core i5-7600K Processor, 3.80GHz w/ 6MB Cache - 259.99</asp:ListItem>
                        <asp:ListItem Value="229.99">Ryzen 5 1600 Processor, 3.2GHz w/ 16MB Cache - 229.99</asp:ListItem>
                    </asp:DropDownList>
                </p>
                <p><strong>RAM:</strong>
                    <asp:DropDownList ID="DropDownList3" runat="server">
                        <asp:ListItem Value="249.99">Vengeance LPX 16GB DDR4 2400MHz CL14 Dual Channel Kit (2 x 8GB), Black - 249.99</asp:ListItem>
                        <asp:ListItem Value="219.99">XPG Z1 Gaming Series 16GB DDR4-2400 Dual Channel DDR4 Kit, CL16 (2x 8GB) - 219.99</asp:ListItem>
                        <asp:ListItem Value="219.99">HyperX Fury Series 16GB PC4-19200 DDR4 Kit (2x 8GB), Black - 219.99</asp:ListItem>
                        <asp:ListItem Value="139.99">Vengeance LPX 8GB DDR4 2400MHz CL14 Dual Channel Kit (2 x 4GB), Black - 139.99</asp:ListItem>
                        <asp:ListItem Value="124.99">Vengeance LPX 8GB DDR4 2400MHz CL14 DIMM (1 x 8GB), Black - 124.99</asp:ListItem>
                    </asp:DropDownList>
                </p>
                <p><strong>HARD DRIVE:</strong> 
                    <asp:DropDownList ID="DropDownList4" runat="server">
                        <asp:ListItem Value="179.99">850 EVO Series Solid State Drive, 500GB - 179.99</asp:ListItem>
                        <asp:ListItem Value="139.99">4TB BarraCuda HDD, SATA III w/ 256MB Cache - 139.99</asp:ListItem>
                        <asp:ListItem Value="109.99">850 EVO Series Solid State Drive, 250GB - 109.99</asp:ListItem>
                        <asp:ListItem Value="59.99">1TB BarraCuda HDD, SATA III w/ 64MB Cache - 59.99</asp:ListItem>
                        <asp:ListItem Value="54.99">Blue 1TB Desktop Hard Drive, SATA III w/ 64MB Cache - 54.99</asp:ListItem>
                    </asp:DropDownList>
                </p>
                <p><strong>DISPLAY:</strong> 
                    <asp:DropDownList ID="DropDownList5" runat="server">
                        <asp:ListItem Value="329.99">Optix G24C 23.6in FHD Widescreen Curved VA LED LCD w/ AMD FreeSync, 144Hz - 329.99</asp:ListItem>
                        <asp:ListItem Value="239.99">GC2870H 28in FHD Widescreen VA LED LCD - 239.99</asp:ListItem>
                        <asp:ListItem Value="129.99">VP239H-P 23in Widescreen LED LCD IPS w/ Speakers - 129.99</asp:ListItem>
                        <asp:ListItem Value="129.99">GW2470ML 23.8in Widescreen VA LED LCD w/ HDMI, Speakers - 129.99</asp:ListItem>
                        <asp:ListItem Value="99.99">GW2270 21.5in Widescreen VA LED LCD - 99.99</asp:ListItem>
                    </asp:DropDownList>
                </p>
                <p><strong>SOUND CARD:</strong> 
                    <asp:DropDownList ID="DropDownList6" runat="server">
                        <asp:ListItem Value="129.99">Sound Blaster Z PCI-E 5.1 Sound Card w/ Beamforming Microphone - 129.99</asp:ListItem>
                        <asp:ListItem Value="64.99">Xonar DGX PCI-E 5.1 Gaming Audio Card w/ Headphone Amp - 64.99</asp:ListItem>
                        <asp:ListItem Value="49.99">Sound Blaster Audigy Fx 5.1 Sound Card, PCIe - 49.99</asp:ListItem>
                        <asp:ListItem Value="49.99">Xonar DG 5.1 Low Profile PCI Sound Card w/ Headphone AMP - 49.99</asp:ListItem>
                        <asp:ListItem Value="14.99">USB Stereo Audio Adaptor - 14.99</asp:ListItem>
                    </asp:DropDownList>
                </p>
                <asp:Button ID="Detail_Add_to_Cart" runat="server" CssClass="auto-style4" Height="30px" Text="Add to Cart" Width="70px" />
            </ul>


        </div>
</asp:Content>

