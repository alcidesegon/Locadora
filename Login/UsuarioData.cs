using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Login
{
    public class UsuarioData
    {
        public UsuarioData()
        {

        }

        /// <summary>
        /// Metodo Cria novo usuário
        /// </summary>
        /// <param name="model">Informações do Usuário</param>
        public void Criar(UsuarioModel model)
        {            
            var conexao = Conexao.GetConexao();
            try
            {
                model.ID = UteisData.BuscarId("Usuário");  
                              
                conexao.Open();
                                
                SqlCommand comando = new SqlCommand(string.Format(@"INSERT INTO USUÁRIO (ID,NOME,LOGIN,SENHA,ATIVO,DATAEXPIRAEM)
                                                                    VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                                                                    model.ID,
                                                                    model.Nome, 
                                                                    model.Login, 
                                                                    model.Senha, 
                                                                    model.Ativo, 
                                                                    model.DataExpiraEm),
                                                                    conexao);
                 comando.ExecuteNonQuery();                             
            }
            catch (Exception erro)
            {

            }
            finally
            {
                conexao.Close();
            }           
        }

        //metodo excluir
        public void Excluir(long id)
        {
            var conexao = Conexao.GetConexao();
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand(string.Format(@"DELETE FROM USUÁRIO WHERE ID = '{0}'", id), conexao);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

            }
            finally
            {
                conexao.Close();
            }          
        }

        //MÉTODO ATUALIZAR CADASTRO DE USUÁRIO
        public void Atualizar(UsuarioModel model)
        {
            var conexao = Conexao.GetConexao();
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand(string.Format(@"UPDATE USUÁRIO set NOME = '{0}',   
	                                                                                   LOGIN = '{1}',
	                                                                                   ATIVO = {2},
	                                                                                   DATAEXPIRAEM = '{3}'
                                                                                       WHERE ID = {4}",
                                                                                       model.Nome,
                                                                                       model.Login,
                                                                                       model.Ativo,
                                                                                       model.DataExpiraEm,
                                                                                       model.ID), conexao);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

            }
            finally
            {
                conexao.Close();
            }
        }

        //metodo consulta usuario
        public List<UsuarioModel> Consultar()
        {
            List<UsuarioModel> result = new List<UsuarioModel>();

            var conexao = Conexao.GetConexao();
            try
            {
                conexao.Open();

                SqlCommand comando = new SqlCommand(@"SELECT A.ID,
                                                             A.NOME,
                                                             A.LOGIN,
                                                             A.SENHA,
                                                             A.ATIVO,
                                                             A.DATAEXPIRAEM 
                                                             FROM USUÁRIO A ORDER BY A.NOME", conexao);
                
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Login.UsuarioModel
                    {
                        ID = Convert.ToInt64(reader["ID"]),
                        Nome = reader["NOME"].ToString(),
                        Login = reader["LOGIN"].ToString(),
                        Senha = reader["SENHA"].ToString(),
                        Ativo = Convert.ToInt32(reader["ATIVO"]),
                        DataExpiraEm = Convert.ToDateTime(reader["DATAEXPIRAEM"])
                    });
                }

            }
            catch (Exception erro)
            {

            }
            finally
            {
                conexao.Close();
            }
            
            return result;
        }

        public UsuarioModel BuscarUsuarioPeloLoginESenha(string login, string senha)
        {
            UsuarioModel result = null;
            var conexao = Conexao.GetConexao();
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand(string.Format(@"SELECT  A.LOGIN, 
                                                                            A.SENHA,
                                                                            A.DATAEXPIRAEM,
                                                                            A.NOME,
                                                                            A.ATIVO FROM USUÁRIO A
                                                        WHERE A.LOGIN = '{0}' AND A.SENHA = '{1}'",login, senha), conexao);
                var reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    result = new UsuarioModel();
                    result.Nome = reader["NOME"].ToString();                    
                    result.Login = reader["LOGIN"].ToString();
                    result.Senha = reader["SENHA"].ToString();
                    result.Ativo = Convert.ToInt32(reader["ATIVO"]);
                    result.DataExpiraEm = Convert.ToDateTime(reader["DATAEXPIRAEM"]);
                }
               
            }
            catch (Exception erro)
            {

            }
            finally
            {
                conexao.Close();
            }      

            return result;


        }

        public UsuarioModel BuscarUsuarioPeloId(long id)
        {
            UsuarioModel result = null;
            var conexao = Conexao.GetConexao();
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand(string.Format(@"SELECT  A.NOME,
                                                                            A.LOGIN, 
                                                                            A.SENHA,
                                                                            A.ATIVO,
                                                                            A.DATAEXPIRAEM
                                                                            FROM USUÁRIO A
                                                                            WHERE A.ID = {0}", id), conexao);
                var reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    result = new UsuarioModel();
                    result.Nome = reader["NOME"].ToString();
                    result.Senha = reader["SENHA"].ToString();
                    result.Login = reader["LOGIN"].ToString();
                    result.Ativo = Convert.ToInt32(reader["ATIVO"]);
                    result.DataExpiraEm = Convert.ToDateTime(reader["DATAEXPIRAEM"]);
                }

            }
            catch (Exception erro)
            {

            }
            finally
            {
                conexao.Close();
            }
            return result;
        }
    }
}