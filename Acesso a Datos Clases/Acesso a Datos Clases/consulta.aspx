<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consulta.aspx.cs" Inherits="Acesso_a_Datos_Clases.consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Ingrese el nombre de usuario:"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
            </div>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </div>
            <div>
                <br />
                <a href="Default.aspx">Retornar</a>
            </div>
        </div>
    </form>
</body>
</html>
