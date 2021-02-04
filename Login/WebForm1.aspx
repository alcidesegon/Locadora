<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Login.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 100%; height:100%">
    
        <table style="width: 100%; height:100%;">
            <tr>
                <td style="width:20%"><asp:Label ID="lblLogin" runat="server" Text="Login" ></asp:Label></td>
                <td style="width:80%"><asp:TextBox ID="txtLogin" runat="server" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label></td>
                <td><asp:TextBox ID="txtSenha" runat="server" TextMode="Password" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    
                    <input type="button" id="btnEntrar" runat="server" onclick="entrar();" value="Entrar" />
                    <asp:Button ID="btn_cadastrar" runat="server" Text="Cadastrar" OnClick="btn_cadastrar_Click"/>
                    
                    <br />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <input type="hidden" id="hdnAcao" runat="server" />
    </div>
    </form>
    <script type="text/javascript">

        function entrar() {
            if (validarCamposObrigatorios()) {
                document.getElementById('hdnAcao').value = "Entrar";
                form1.submit();
            }
        }

        function validarCamposObrigatorios() {

            var campoLogin = document.getElementById('txtLogin');

            if (campoLogin.value == "") {
                alert("Favor informar o campo Login");
                return false;

            }

            var campoSenha = document.getElementById('txtSenha');

            if (campoSenha.value == "") {
                alert("Favor informar o campo Senha");

                return false;

            }

            return true;
            
        }
        
    </script>
</body>
    
</html>
