<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TimedCookie.aspx.cs" Inherits="TimedCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TimedCookie</title>
    <script src = "timedcookie.js"></script>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .labelStyle {
            color: #C0C0C0;
            font-size: xx-large;
            background-color: #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 class="auto-style1">IP Address:</h2>
            <p class="auto-style1">
                <asp:Label ID="ip_Label" runat="server" CssClass="labelStyle"></asp:Label>
            </p>
            <h2 style="text-align: center">Times Visited:</h2>
            <p style="text-align: center">
                <asp:Label ID="visit_Label" runat="server" CssClass="labelStyle"></asp:Label>
            </p>
            <h2 style="text-align: center">Time Zone:</h2>
            <p style="text-align: center">
                <asp:Label ID="zone_Label" runat="server" CssClass="labelStyle"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
