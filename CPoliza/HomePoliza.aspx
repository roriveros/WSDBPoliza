<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePoliza.aspx.cs" Inherits="CPoliza.HomePoliza" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Bienvenido a la plagina que te muestra las polizas de seguros asociadas<br />
        <asp:GridView ID="GridView1" runat="server" Width="316px">
        </asp:GridView>
        <br />
    </form>
</body>
</html>
