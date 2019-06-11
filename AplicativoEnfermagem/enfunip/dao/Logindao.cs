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

            cmd.CommandText = @"select * from Pessoas 
                                where Senha = @Senha";
            cmd.Parameters.AddWithValue("@Senha", login.senha);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }
    }
}
