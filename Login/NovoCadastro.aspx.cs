using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class NovoCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            //chamar o método CRIAR()
            UsuarioModel model = new UsuarioModel();
            UsuarioData data = new UsuarioData();
            model.Nome = txtNome.Text;
            model.Login = txtLogin.Text;
            model.Senha = txtSenha.Text;
            model.Ativo = 1;
            model.DataExpiraEm = DateTime.Today.AddYears(1);

            data.Criar(model);
            
            Label1.Text = "Usuário " + model.Nome + " cadastrado com sucesso!";
            
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        //chamar método Atualizar()
        //    UsuarioModel model = new UsuarioModel();
        //    UsuarioData data = new UsuarioData();
                       
        //    model.Nome = txtNome.Text;
        //    model.Login = txtLogin.Text;
        //    model.Senha = txtSenha.Text;
        //    model.Ativo = 1;
        //    model.DataExpiraEm = DateTime.Today;

        //    data.Atualizar(model);

        //    Label1.Text = "Usuário " + model.Nome + " atualizado com sucesso!";
            

        //}

        //protected void btnExcluir_Click(object sender, EventArgs e)
        //{
        //    //chamar método Excluir()
        //    UsuarioModel model = new UsuarioModel();
        //    UsuarioData data = new UsuarioData();  
        //    data.Excluir(model);            
           
        //}

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtIdExcluir_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}