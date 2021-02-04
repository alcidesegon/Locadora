using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Carregar();
        }
        private void Carregar()
        {
            UsuarioData data = new UsuarioData();
            GridView1.DataSource = data.Consultar();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[4].Text == "1")
                    e.Row.Cells[4].Text = "Sim";
                else
                    e.Row.Cells[4].Text = "Não";
            }

            e.Row.Cells[1].Visible = false;
        }       

        protected void btn_Atualizar_Click(object sender, EventArgs e)
        {
            //chamar método Atualizar            
            List<long> lista = BuscarIdSelecionado();

            if (lista.Count > 1)            
                throw new Exception("Seleciona apenas 1 registro");


            if (lista.Count == 0)
                throw new Exception("Selecione 1 registro");

            Response.Redirect("EditaCadastro.aspx?ID=" + lista[0]);
                     
        }

        protected void btn_Excluir_Click(object sender, EventArgs e)
        {
            UsuarioData data = new UsuarioData();

            List<long> lista = BuscarIdSelecionado();

            //chamar método Excluir
            foreach (long id in lista)
            {
                data.Excluir(id);
            }

            Carregar();
        }

        private List<long> BuscarIdSelecionado()
        {
            var result = new List<long>();

            var selecionado = GridView1.HeaderRow.Cells[0].ToString();
            

            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    var controle = row.Cells[0].FindControl("SelectCheckBox") as CheckBox;
                    if (controle.Checked)
                    {
                        if (row.Cells[1].Text != "")
                            result.Add(Convert.ToInt64(row.Cells[1].Text));
                    }
                }
            }
            return result;
            
        }
    }
}