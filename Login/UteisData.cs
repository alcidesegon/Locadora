using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Login
{
    public class UteisData
    {
        public static long BuscarId(string nomeTabela)
        {
            long id = 1;
            var conexao = Conexao.GetConexao();
            try
            {
                conexao.Open();
                SqlCommand buscaId = new SqlCommand(@"SELECT MAX(ID) + 1 FROM " + nomeTabela, conexao);
                var reader = buscaId.ExecuteScalar();
                if (reader != null)
                    id = Convert.ToInt64(reader);
            }
            catch (Exception erro)
            {

            }
            finally
            {
                conexao.Close();
            }
            return id;
        }

    }
}