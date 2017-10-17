<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePoliza.aspx.cs" Inherits="CPoliza.HomePoliza" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Polizas</title>
</head>
<body>
    <form id="form1" runat="server">
        Bienvenido a la plagina que te muestra las polizas de seguros asociadas<br />
        <br />
        <asp:GridView ID="GridView1" runat="server" Width="316px"
            EmptyDataText="No hay Polizas para mostrar!!!">
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Actualizar Datos" Width="130px" />
        <br />
    </form>
</body>
</html>
