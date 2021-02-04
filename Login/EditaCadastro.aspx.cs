using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class EditaCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //criar método que busca pelo ID e retorna um model carregado
                UsuarioModel model = new UsuarioModel();
                UsuarioData data = new UsuarioData();
                var id = Convert.ToInt64(Request.Params["ID"]);

                model = data.BuscarUsuarioPeloId(id);

                txtNome.Text = model.Nome;
                txtLogin.Text = model.Login;
                ck_Ativo.Checked = (model.Ativo == 1);
                txtDataExpira.Text = model.DataExpiraEm.ToString();
            }

        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Usuario.aspx");
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuarioData data = new UsuarioData();
            UsuarioModel model = new UsuarioModel();
            model.ID = Convert.ToInt64(Request.Params["ID"]);
            model.Nome = txtNome.Text;
            model.Login = txtLogin.Text;
            //model.Senha = 
            model.DataExpiraEm = Convert.ToDateTime(txtDataExpira.Text);
            if (ck_Ativo.Checked)
                model.Ativo = 1;
            else
                model.Ativo = 0;

            data.Atualizar(model);
            

        }
    }
}