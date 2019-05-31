using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enfunip.modelo.validacoes
{
    public class validarAgenda
    {
        public String mensagem;
        public int id;

        public void ValidarDados(List<String> dadosAgenda)
        {
            this.mensagem = "";
            if (Convert.ToDateTime(dadosAgenda[1]).Date < DateTime.Now)
                this.mensagem += "Data de agendamento não pode ser menor do que hoje\n";
            if (dadosAgenda[1].Length > 20)
                this.mensagem = "Local com mais de 20 caracteres \n";
            if (dadosAgenda[3].Length > 300)
                this.mensagem += "observação não poder ter mais do que 200 caracteres \n";
            try
            {
                this.id = Convert.ToInt32(dadosAgenda[0]);
            }
            catch (FormatException)
            {
                this.mensagem += "ID inválido";
            }
        }
    }
}

