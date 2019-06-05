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
            
            if (dadosItem[1].Length > 50)
                this.mensagem = "Nome do produto com mais de 50 caracteres \n";
            if (Convert.ToDateTime(dadosItem[1]) < DateTime.Today)
                this.mensagem += "Data de estrada está no ano errado\n";

           /* try
            {
                this.id = Convert.ToInt32(dadosItem[0]);
            }
            catch (FormatException)
            {
                this.mensagem += "ID inválido";
            }*/
        }
    }
}
