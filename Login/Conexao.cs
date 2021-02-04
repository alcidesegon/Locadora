using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Login
{
    public class Conexao
    {

        public Conexao()
        {

        }

        public static SqlConnection GetConexao()
        {
            string dbConnection = ConfigurationSettings.AppSettings["DBConnection"];

            SqlConnection conexao = new SqlConnection(dbConnection);

            return conexao;
        }

    }
}