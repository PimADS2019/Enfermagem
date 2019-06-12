using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enfunip.modelo.validacoes;
using enfunip.dao;
using System.Data;

namespace enfunip.modelo.controle
{
    public class controleAgenda
    {
        public String mensagem;
        public void CadastrarAgenda(List<String> dadosAgenda)
        {
            this.mensagem = "";
            validarAgenda validaragenda = new validarAgenda();
            validaragenda.ValidarDados(dadosAgenda);
            if (validaragenda.mensagem.Equals(""))
            {
                Agenda agenda = new Agenda();

                agenda.Id = validaragenda.id;
                agenda.nomePaciente = dadosAgenda[1];
                agenda.dataHoraAgendamento = Convert.ToDateTime(dadosAgenda[2]);
                agenda.localAgendamento = dadosAgenda[3];
                agenda.obsAgendamento = dadosAgenda[4];
                Agendadao agendaDAO = new Agendadao();
                agendaDAO.CadastrarAgenda(agenda);
                this.mensagem = agendaDAO.mensagem;
            }
            else
            {
                this.mensagem = validaragenda.mensagem;
            }
        }
        public DataTable ListarPorNome()
        {
            try
            {
                Agendadao agendadao = new Agendadao();
                DataTable dt = new DataTable();

                dt = agendadao.ListarItemPorNome();

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable PesquisarPorNome(Agenda agenda)
        {
            try
            {
                Agendadao agendadao = new Agendadao();
                DataTable dt = new DataTable();

                dt = agendadao.PesquisarAgenda(agenda);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
