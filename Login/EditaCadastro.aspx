<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditaCadastro.aspx.cs" Inherits="Login.EditaCadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <tr>
                <td style="width:20%"><asp:Label ID="Label7" runat="server" Text="Nome"></asp:Label></td>
                &nbsp;<td style="width:80%"><asp:TextBox ID="txtNome" runat="server" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblSenha" runat="server" Text="Login"></asp:Label></td>
                <td><asp:TextBox ID="txtLogin" runat="server" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Ativo"></asp:Label>
        <br />
        <asp:CheckBox ID="ck_Ativo" runat="server" />
        <br />
        </td>
                <td></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Data Expira"></asp:Label></td>
                <td><asp:TextBox ID="txtDataExpira" runat="server" Width="100%"></asp:TextBox></td>
            </tr>
    </div>
        <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
        <asp:Button ID="btnVoltar" runat="server" OnClick="btnVoltar_Click" Text="Voltar" />
    </form>
</body>
</html>
