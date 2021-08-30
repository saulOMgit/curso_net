<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioDeValidacionASP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="css/StyleSheet1.css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre de usuario:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="283px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="283px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Repite la clave:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Width="283px"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator" ControlToCompare="TextBox2" ControlToValidate="TextBox3" Text="No coinciden"></asp:CompareValidator>
        </div>
                <div>
            <asp:Label ID="Label4" runat="server" Text="Correo Electrónico:"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Width="283px"></asp:TextBox>
        </div>
                <div>
            <asp:Label ID="Label5" runat="server" Text="Apellido:"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" Width="283px"></asp:TextBox>
        </div>
                <div>
            <asp:Label ID="Label6" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server" Width="283px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label7" runat="server" Text="Pais de origen:"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>España</asp:ListItem>
                <asp:ListItem>Francia</asp:ListItem>
                <asp:ListItem>Portugal</asp:ListItem>
            </asp:DropDownList>
        </div>
                <div>
            <asp:Label ID="Label8" runat="server" Text="Provincia"></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server" Width="283px"></asp:TextBox>
        </div>
                <div>
            <asp:Label ID="Label9" runat="server" Text="Código Postal"></asp:Label>
            <asp:TextBox ID="TextBox8" runat="server" Width="283px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label10" runat="server" Text="Sexo:"></asp:Label>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="genero" Text="Hombre" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="genero" Text="Mujer" />

        </div>
                <div>
            <asp:Label ID="Label11" runat="server" Text="Feha de nacimiento (dd(mm/aaaa):"></asp:Label>
            <asp:TextBox ID="TextBox9" runat="server" Width="283px"></asp:TextBox>
        </div>
                <div>
            <asp:Label ID="Label12" runat="server" Text="Comentarios"></asp:Label>
            <asp:TextBox ID="TextBox10" runat="server" Width="278px" Height="185px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label13" runat="server" Text="Acepto los términos y condiciones:"></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Acepto" />
        </div>
        <div>
            <asp:Button />
        </div>
    </form>
</body>
</html>
