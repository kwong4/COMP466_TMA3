<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Slideshow.aspx.cs" Inherits="Slideshow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Slideshow</title>
    <style type="text/css">
        .centreAligned {
            text-align: center;
        }
        .hidden {
            display: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="centreAligned">
            <asp:Image ID="Slideshow_Image" runat="server" BorderStyle="Solid" Height="600px" ImageAlign="Middle" />
            <br />
            <br />
            <div>
                <asp:Label ID="caption_Label" runat="server"></asp:Label>
            </div>
            <br />
            <div>
                <asp:DropDownList ID="Ordering_dropdown" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Ordering_dropdown_SelectedIndexChanged">
                    <asp:ListItem Selected="True">Sequential</asp:ListItem>
                    <asp:ListItem>Random</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="Prev_button" runat="server" Text="Backward" AutoPostBack="True" OnClick="Prev_button_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Slideshow_button" runat="server" Text="Start" AutoPostBack="True" OnClick="Slideshow_button_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Next_button" runat="server" Text="Forward" AutoPostBack="True" OnClick="Next_button_Click" />
                <br />
                <br />
                <asp:Timer ID="Slideshow_Timer" runat="server" Enabled="False" OnTick="Slideshow_transition" Interval="2000">
                </asp:Timer>
                <asp:ScriptManager ID="SlideshowScriptManager" runat="server"></asp:ScriptManager>
            </div>
        </div>
    </form>
</body>
</html>
