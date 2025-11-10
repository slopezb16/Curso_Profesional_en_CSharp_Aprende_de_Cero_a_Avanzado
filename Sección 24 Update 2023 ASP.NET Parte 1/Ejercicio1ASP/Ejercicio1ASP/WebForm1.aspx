<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ejercicio1ASP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Exportar</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="color:red">Boton exporta excel</h2>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Cargar archivo" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
