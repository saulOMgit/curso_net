<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MiPrimerASP.net.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Select1 {
            width: 82px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="1"></asp:Label>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Resultado" OnClick="Button1_Click" />
        </p>
        <asp:Label ID="Label2" runat="server" Text="Ingrese primer valor"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="Ingrese segundo valor"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
<%--        <select id="Select1" runat="server">
            <option>sumar</option>
            <option>restar</option>
        </select>--%>
<%--        <asp:RadioButton ID="RadioButton1" runat="server" Text="sumar" GroupName="operacion"/><br />
        <asp:RadioButton ID="RadioButton2" runat="server" Text="restar" GroupName="operacion"/><br />--%>
                <br />
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem>sumar</asp:ListItem>            
            <asp:ListItem>restar</asp:ListItem>
            <asp:ListItem>multiplicar</asp:ListItem>           
            <asp:ListItem>dividir</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    </form>
    
</body>
</html>
