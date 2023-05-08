<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Weather.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

<form runat="server">
    <asp:TextBox ID="txtLocation1" runat="server"></asp:TextBox>
    <br />
   <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
    <br />
   <asp:Label ID="lblTemperature" runat="server" Text="Label"></asp:Label>
    <br />
   <asp:Button ID="btnGetTemperature" runat="server" Text="Get Temperature" OnClick="btnGetTemperature_Click" />
</form>

</body>
</html>
