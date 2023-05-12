<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Weather.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Temp</title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <div class="Temp">
        <form runat="server" style="margin: auto; width: 50%;">
            <asp:TextBox ID="txtLocation1" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblTemperature" runat="server" Text="Temp"></asp:Label>
            <br />
            <asp:Button ID="btnGetTemperature" runat="server" Text="Get Temperature" OnClick="btnGetTemperature_Click" CssClass="btnGetTemperature" />
            <br />
            <br />
            <asp:Button ID="btnGetOslo" runat="server" Text="Oslo" OnClick="btnGetOslo_Click" />
            <asp:Button ID="btnGetFredrikstad" runat="server" Text="Fredriksrad" OnClick="btnGetFredrikstad_Click" />
            <asp:Button ID="btnGetTromso" runat="server" Text="Tromsø" OnClick="btnGetTromso_Click" />
        </form>
    </div>

</body>
</html>
