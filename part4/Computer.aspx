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
        <h2>Pre-Built #1&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; $ 1109.94</h2>
        <div style ="float:left;">
            <img alt="" class="computer_image" src="computer.png" />
        </div>
        <div class="auto-style3">
            <ul>
                <li><strong>OS:</strong> Windows 10 Home (64 bit)</li>
                <li><strong>CPU:</strong> Core i5-8600K Processor, 3.5GHz w/ 9MB Cache</li>
                <li><strong>RAM:</strong> HyperX Fury Series 16GB PC4-19200 DDR4 Kit (2x 8GB), Black</li>
                <li><strong>Hard Drive:</strong> 850 EVO Series Solid State Drive, 250GB</li>
                <li><strong>Display:</strong> GC2870H 28in FHD Widescreen VA LED LCD</li>
                <li><strong>Sound Card:</strong> Xonar DGX PCI-E 5.1 Gaming Audio Card w/ Headphone Amp</li>
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
        <h2>Pre-Built #2&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; $ 1529.94</h2>
        <div style ="float:left;">
            <img alt="" class="computer_image" src="computer.png" />
        </div>
        <div class="auto-style3">
            <ul>
                <li><strong>OS:</strong> Windows 10 Pro (64 bit)</li>
                <li><strong>CPU:</strong> Core i7-7700K Processor, 4.20GHz w/ 8MB Cache</li>
                <li><strong>RAM:</strong> Vengeance LPX 16GB DDR4 2400MHz CL14 Dual Channel Kit (2 x 8GB), Black</li>
                <li><strong>Hard Drive:</strong> 850 EVO Series Solid State Drive, 500GB</li>
                <li><strong>Display:</strong> Optix G24C 23.6in FHD Widescreen Curved VA LED LCD w/ AMD FreeSync, 144Hz</li>
                <li><strong>Sound Card:</strong> Sound Blaster Z PCI-E 5.1 Sound Card w/ Beamforming Microphone</li>
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
        <h2>Pre-Built #3&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; $ 849.94</h2>
        <div style ="float:left;">
            <img alt="" class="computer_image" src="computer.png" />
        </div>
        <div class="auto-style3">
            <ul>
                <li><strong>OS:</strong> Windows 7 Professional (64 bit)</li>
                <li><strong>CPU:</strong> Core i5-7600K Processor, 3.80GHz w/ 6MB Cache</li>
                <li><strong>RAM:</strong> Vengeance LPX 8GB DDR4 2400MHz CL14 DIMM (1 x 8GB), Black</li>
                <li><strong>Hard Drive:</strong> 4TB BarraCuda HDD, SATA III w/ 256MB Cache</li>
                <li><strong>Display:</strong> GW2270 21.5in Widescreen VA LED LCD</li>
                <li><strong>Sound Card:</strong> USB Stereo Audio Adaptor</li>
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

