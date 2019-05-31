using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enfunip.modelo.validacoes;
using enfunip.dao;

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
                agenda.dataentrada = Convert.ToDateTime(dadosAgenda[1]);
                agenda.local = dadosAgenda[2];
                agenda.observacao = dadosAgenda[3];
                Agendadao agendaDAO = new Agendadao();
                agendaDAO.CadastrarAgenda(agenda);
                this.mensagem = agendaDAO.mensagem;
            }
            else
            {
                this.mensagem = validaragenda.mensagem;
            }
        }
    }
}
