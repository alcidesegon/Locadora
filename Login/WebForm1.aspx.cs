using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //
        }

        protected override void OnPreRender(EventArgs e)
        {
            if (hdnAcao.Value == "Entrar")
                Entrar();
        }

        private void Entrar()
        {            
            UsuarioData data = new UsuarioData();
            var modelUsuario = data.BuscarUsuarioPeloLoginESenha(txtLogin.Text, txtSenha.Text);
            if (modelUsuario != null)
            {
                Label1.Text = modelUsuario.Nome + " usuário ativo";
                Response.Redirect("Usuario.aspx", false);
            }
            else
            {
                Label1.Text = "Login ou senha incorretos";
            }
        }

        protected void btn_cadastrar_Click(object sender, EventArgs e)
        {
            UsuarioData data = new UsuarioData();
            var modelUsuario = data.BuscarUsuarioPeloLoginESenha(txtLogin.Text, txtSenha.Text);
            if (modelUsuario != null)
            {
                Label1.Text = "O usuário '"+ modelUsuario.Nome + "' já existe";
            }
            else
            {
                Response.Redirect("NovoCadastro.aspx", false);
            }
        }
    }
}