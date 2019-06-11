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
            cmd.CommandText = @"insert into Agendamento (Paciente, DataHoraAgendamento, LocalAgendamento, ObsAgendamento)
                                    values (@Paciente,@DataHoraAgendamento, @LocalAgendamento, @ObsAgendamento)";
            cmd.Parameters.AddWithValue("@Paciente", agenda.nomePaciente);
            cmd.Parameters.AddWithValue("@DataHoraAgendamento", agenda.dataHoraAgendamento);
            cmd.Parameters.AddWithValue("@LocalAgendamento", agenda.localAgendamento);
            cmd.Parameters.AddWithValue("@ObsAgendamento", agenda.obsAgendamento);
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
                cmd = new SqlCommand("select * from Agendamento", cmd.Connection);

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
    }
}
