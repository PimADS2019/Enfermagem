using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enfunip.modelo.validacoes
{
    public class validarEstoque
    {
        public String mensagem;
        public int id;

        public void ValidarDados(List<String> dadosItem)
        {
            this.mensagem = "";
            if (Convert.ToDateTime(dadosItem[2]).Year < 2018)
                this.mensagem += "Data de estrada está no ano errado\n";
            if (dadosItem[1].Length > 50)
                this.mensagem = "Nome do produto com mais de 50 caracteres \n";
            if (dadosItem[3].Length > 50)
                this.mensagem += "Fabricante com mais de 50 caracteres \n";
            if (dadosItem[4].Length > 50)
                this.mensagem += "Categoria com mais de 50 caracteres\n";
            if (dadosItem[6].Length > 30)
                this.mensagem += "Descrição com mais de 30 caracteres \n";
            try
            {
                this.id = Convert.ToInt32(dadosItem[0]);
            }
            catch (FormatException)
            {
                this.mensagem += "ID inválido";
            }
        }
    }
}
