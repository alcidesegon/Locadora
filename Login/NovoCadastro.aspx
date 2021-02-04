<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NovoCadastro.aspx.cs" Inherits="Login.NovoCadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 100%; height:100%">
    
        <table style="width: 100%; height:274px;">
            <tr>
                <td style="width:20%"><asp:Label ID="lblLogin" runat="server" Text="Nome" ></asp:Label></td>
                <td style="width:80%"><asp:TextBox ID="txtNome" runat="server" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblSenha" runat="server" Text="Login"></asp:Label></td>
                <td><asp:TextBox ID="txtLogin" runat="server" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label></td>
                <td><asp:TextBox ID="txtSenha" runat="server" TextMode="Password" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="btnCadastrar" runat="server" Text="Salvar" OnClick="btnCadastrar_Click"/>
                    <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click"/>
                    <br />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
    
    <p>
&nbsp;&nbsp;&nbsp;
    </p>
    
</body>
</html>
