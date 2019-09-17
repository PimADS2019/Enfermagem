using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enfunip.modelo;
using System.Data.SqlClient;
using System.Data;

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
            cmd.CommandText = @"
                                Insert into Atendimentos (DescricaoAtendimento, Fk_Pacientes_IdPaciente)
                                Values (@DescricaoAtendimento, @IdPaciente)
                                Declare @id_Atendimento int=@@identity
                                
                                Insert into LogConsultas (LocalAtendimento, DataHrMarcada, Fk_Atendimentos_IdAtendimento)
                                Values (@LocalAtendimento, @DataHrMarcada, @id_Atendimento )";
                                


            cmd.Parameters.AddWithValue("@LocalAtendimento", agenda.localAgendamento);
            cmd.Parameters.AddWithValue("@DataHrMarcada", agenda.dataHoraAgendamento);
            cmd.Parameters.AddWithValue("@DescricaoAtendimento", agenda.obsAgendamento);
            cmd.Parameters.AddWithValue("@IdPaciente", agenda.Id);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Agendamento realizado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }
        
        public DataTable ListarItemPorNome()
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexaoBD.Conectar();
                cmd = new SqlCommand(@"select IdAtendimento, Nome, Cpf, LocalAtendimento, DataHrMarcada, DescricaoAtendimento from
                                    (
                                        Select IdAtendimento, LocalAtendimento, DataHrMarcada, DescricaoAtendimento, Fk_Pacientes_IdPaciente, Fk_Pessoas_IdPessoa from
                                        (
                                            Select IdAtendimento, LocalAtendimento, DataHrMarcada, DescricaoAtendimento, Fk_Pacientes_IdPaciente, Fk_Atendimentos_IdAtendimento from Atendimentos
                                            inner join LogConsultas

                                            on Atendimentos.IdAtendimento = LogConsultas.Fk_Atendimentos_IdAtendimento

                                        ) as Atendimentos_LogConsulta

                                        inner join Pacientes

                                        on Pacientes.IdPaciente = Atendimentos_LogConsulta.Fk_Pacientes_IdPaciente
                                    ) as Atendimento_Paciente

                                    inner join Pessoas
                                    on Pessoas.IdPessoa = Atendimento_Paciente.Fk_Pessoas_IdPessoa", cmd.Connection);

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public DataTable PesquisarAgenda(Agenda agenda)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexaoBD.Conectar();

                cmd = new SqlCommand("SELECT * FROM Agendamento WHERE DataHoraAgendamento Like @DataHora ORDER BY DataHoraAgendamento", cmd.Connection);
                cmd.Parameters.AddWithValue("@DataHora", "%" + agenda.dataHoraAgendamento + "%");


                da.SelectCommand = cmd;
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ExcluirAgenda(Agenda agenda)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from Atendimentos
                                where IdAtendimento =
                                (
	                                 select IdAtendimento from LogConsultas
	                                 inner join Atendimentos
	                                 on LogConsultas.Fk_Atendimentos_IdAtendimento = Atendimentos.IdAtendimento
	                                where IdLogConsultas = @id
                                )";

            cmd.Parameters.AddWithValue("@id", agenda.Id);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Pessoa excluída com sucesso !!!!!";
            }
            catch (SqlException)
            {
                this.mensagem = "Paciente com Consulta marcada, Por Favor Cancelar a Consulta Primeiro!!!";
            }
        }
    }
}
