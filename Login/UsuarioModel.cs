using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login
{
    public class UsuarioModel
    {        
        public long ID { get; set; }       
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int Ativo { get; set; }
        public DateTime DataExpiraEm { get; set; }
    }
}