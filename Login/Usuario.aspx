<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Login.Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 314px">
   
        <asp:GridView ID="GridView1" runat="server" EnableModelValidation="True" OnRowDataBound="GridView1_RowDataBound"  
            AutoGenerateColumns="false" Height="234px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="782px">
            <Columns>

                <asp:TemplateField>
                    <HeaderTemplate>
                        <input id="chkSelecionarTudo" type="checkbox" runat="server" onclick="checkAll(this)" />
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="SelectCheckBox" runat="server"/>
                    </ItemTemplate>
                </asp:TemplateField>  
                 
                <asp:BoundField DataField="ID" HeaderText="ID" />            
                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                <asp:BoundField DataField="Login" HeaderText="Login" />
                <asp:BoundField DataField="Ativo" HeaderText="Ativo" />
                <asp:BoundField DataField="DataExpiraEm" HeaderText="Data Expira" DataFormatString="{0:dd/MM/yyyy}" />
                              
            </Columns>
        </asp:GridView>
          
    
        <asp:Button ID="btn_Atualizar" runat="server" OnClick="btn_Atualizar_Click" Text="Atualizar" />
        <asp:Button ID="btn_Excluir" runat="server" Text="Excluir" OnClick="btn_Excluir_Click" />
          
    
    </div>
    </form>
    <script type="text/javascript">
        function checkAll(obj) {
            var grid = obj.parentNode.parentNode.parentNode;
            var inputList = grid.getElementsByTagName("input");

            for (var i = 0; i < inputList.length; i++)
            {
                var linha = inputList[i].parentNode.parentNode;
                if (inputList[i].type == "checkbox" && obj != inputList[i])
                {
                    if (obj.checked) {
                        linha.style.backgroundColor = "aqua";
                        inputList[i].checked = true;
                    }
                    else
                    {
                        if (linha.rowIndex % 2 == 0) {
                            linha.style.backgroundColor = "#C2D69B";

                        }
                        else
                        {
                            linha.style.backgroundColor = "white";
                        }
                        inputList[i].checked = false;
                    }
                }
            }

            //alert(inputList.length);
        }
    </script>


</body>
</html>
