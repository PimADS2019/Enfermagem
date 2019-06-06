using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enfunip.modelo;
using System.Data.SqlClient;

namespace enfunip.dao
{
    public class Logindao : intLogindao
    {
        Conexao conexaoBD = new Conexao();
        SqlDataReader dataReader;
        public String mensagem;
        public void ValidarLogin(Login login)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Pessoas 
                where usuario = @usuario";
            cmd.Parameters.AddWithValue("@Usuario", login.usuario);
        }
    }
}
