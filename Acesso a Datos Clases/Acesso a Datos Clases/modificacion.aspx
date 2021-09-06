<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modificacion.aspx.cs" Inherits="Acesso_a_Datos_Clases.modificacion" %>

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
                <asp:Label ID="Label1" runat="server" Text="Nombre de Usuario:"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button2" runat="server" Text="Buscar" OnClick="Button2_Click"/>
                <asp:Label ID="LabelBuscar" runat="server" Text="Label"></asp:Label>
            </div>
            <div>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label3" runat="server" Text="Mail:"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="Button1" runat="server" Text="Modificar" OnClick="Button1_Click"/>
                <asp:Label ID="LabelModificar" runat="server" Text="Label"></asp:Label>
            </div>
            <div>
                <br />
                <a href="Default.aspx">Retornar</a>
            </div>
        </div>
    </form>
</body>
</html>
