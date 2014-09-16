<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmIndex" runat="server">
    <div>
   <asp:TextBox ID="txtUsuario" Width="200" runat="server" placeholder="Usuario"></asp:TextBox>
    <asp:TextBox ID="txtContrasena" Width="200" runat="server" placeholder="Contraseña"></asp:TextBox>
    </div>
        <p>
        <asp:Button ID="btnLogin" runat="server" Text="Ingresar"></asp:Button>
        <asp:Button ID="btnCrearCuenta" runat="server" Text="Crear Cuenta" OnClientClick="BtnRegistrar"></asp:Button>
        </p>
    </form>
</body>
</html>
