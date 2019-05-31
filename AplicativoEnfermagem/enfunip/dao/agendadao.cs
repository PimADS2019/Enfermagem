using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enfunip.modelo;
using System.Data.SqlClient;

namespace enfunip.dao
{
    public class Agendadao : intAgendadao
    {
        Conexao conexaoBD = new Conexao();
        public String mensagem;
        public void CadastrarAgenda(Agenda agenda)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Enderecos
                                    values ('@txbtipousuario', '340', 'casa', 'Sorocaba', 'VH', 'SP', '18888888')
                                    declare @id_endereco int=@@identity
                                insert into Pessoas
                                    values ('Isac Chuab', '19940802', '99999999999', 'Masculino', 'Casado', 1)
                                    declare @id_Pessoa int=@@identity
                                insert into Alunos
                                    values ( 'd999999', 'Manhã', '3', 1)
                                    declare @id_aluno int=@@identity
                                insert into Contatos
                                    values ('isac@issoai.com', '99999999999', '9999999999', 1))";
            cmd.Parameters.AddWithValue("@DataNascimento", agenda.dataentrada);
            cmd.Parameters.AddWithValue("@Cpf", agenda.local);
            cmd.Parameters.AddWithValue("@Logradouro", agenda.observacao);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Agendamento realizado com sucesso !!!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }
    }
}
