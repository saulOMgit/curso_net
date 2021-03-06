<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CuestionarioASP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="css/Hoja de estilos.css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server">Cuestionario</asp:Label>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label">Pregunta 1: ¿Cuantas veces murió Krillin?</asp:Label>
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="pregunta1" Text="1" />
            <br />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="pregunta1" Text="3"/>
            <br />
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="pregunta1" Text="7"/>
            
        </div>
        
        <div>
            <asp:Label ID="Label2" runat="server" Text="Label">Pregunta 2: ¿Kiere dieh euroh sih o noooooh?</asp:Label>
            <br />
            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="pregunta2" Text="Si" />
            <br />
            <asp:RadioButton ID="RadioButton5" runat="server" GroupName="pregunta2" Text="No"/>
            <br />
            <asp:RadioButton ID="RadioButton10" runat="server" Text="" />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator">Ingresa si quieres leuros</asp:RequiredFieldValidator>

        </div>
           <div>
            <asp:Label ID="Label3" runat="server" Text="Label">Pregunta 3: ¿Cuantas cuerdas tiene un bajo?</asp:Label>
            <br />
            <asp:RadioButton ID="RadioButton6" runat="server" GroupName="pregunta3" Text="5" />
            <br />
            <asp:RadioButton ID="RadioButton7" runat="server" GroupName="pregunta3" Text="4"/>
            <br />
            <asp:RadioButton ID="RadioButton8" runat="server" GroupName="pregunta3" Text="6"/>
            <br />
            <asp:RadioButton ID="RadioButton9" runat="server" GroupName="pregunta3" Text="Si a todo"/>

        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Comprueba las respuestas" OnClick="Button1_Click" />
            <asp:Label ID="Label4" runat="server" Text="Tu resultado"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Introduce el rango adecuado entre 10 y 20"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" ControlToValidate="TextBox2" MaximumValue="19" MinimumValue="11" Text="Cagaste"></asp:RangeValidator>
        </div>
        <div class="polaroid">
                        <asp:Image ID="Image1" runat="server" src="img\077.jpg" Alt="Feliz Jueves" />
             <div class="container">
                <p>Asuka Blyat</p>
              </div>
                        
        </div>
        <div>
            <asp:Label ID="Label6" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Vuelva a introducir la Contraseña"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="No son iguales, crack" ControlToCompare="TextBox3" ControlToValidate="TextBox4"></asp:CompareValidator>
        </div>
    </form>
</body>
</html>
