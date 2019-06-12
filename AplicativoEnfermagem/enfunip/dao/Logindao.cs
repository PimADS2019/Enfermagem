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
            cmd.CommandText = @"select Usuario from Pessoas 
                                where usuario = @usuario";
            cmd.Parameters.AddWithValue("@Usuario", login.usuario);

            try
            {
                this.mensagem = "";
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }

            try
            {
                dataReader = cmd.ExecuteReader();
                dataReader.Read();
                dataReader.GetString(0);
                dataReader.Close();
            }
            catch (Exception)
            {
                this.mensagem = "Login ou Senha Invalidos";
            }

            
            cmd.CommandText = @"select Senha from Pessoas 
                                where Senha = @Senha";
            cmd.Parameters.AddWithValue("@Senha", login.senha);

            try
            {
                dataReader = cmd.ExecuteReader();
                dataReader.Read();
                dataReader.GetString(0);
                dataReader.Close();
                conexaoBD.Desconectar();
                Estaticos.logado = true;
            }
            catch (Exception)
            {
                this.mensagem = "Login e/ou Senha Invalidos";
            }

        }
    }
}
