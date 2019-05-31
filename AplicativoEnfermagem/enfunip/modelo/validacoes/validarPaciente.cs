using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enfunip.modelo.validacoes
{
    public class validarPaciente
    {
        public String mensagem;
        public int id;

        public void ValidarDados(List<String>dadosPaciente)
        {
            this.mensagem = "";
            if (dadosPaciente[1].Length > 50)
                this.mensagem = "Nome com mais de 50 caracteres \n";
            if(Convert.ToDateTime(dadosPaciente[2]).Year < 1900)
                this.mensagem += "Data de nascimento inválida, paciente com mais de 110 ano\n";
            if (dadosPaciente[3].Length > 15)
                this.mensagem += "CPF com mais de 15 caracteres \n";
            if (dadosPaciente[4].Length > 50)
                this.mensagem += "endereço com mais de 50 caracteres\n";
            if (dadosPaciente[5].Length > 8)
                this.mensagem += "número com mais de 8 caracteres \n";
            if (dadosPaciente[6].Length > 30)
                this.mensagem += "Complemento com mais de 30 caracteres \n";
            if (dadosPaciente[7].Length > 40)
                this.mensagem += "Cidade com mais de 40 caracteres\n";
            if (dadosPaciente[8].Length > 40)
                this.mensagem += "bairro com mais de 40 de caracteres\n";
            if (dadosPaciente[9].Length > 2)
                this.mensagem += "Sigla do estado com mais de 2 caracteres\n";
            if (dadosPaciente[10].Length > 10)
                this.mensagem += "cep com mais de 10 caracteres\n";
            if (dadosPaciente[11].Length > 10)
                this.mensagem += "sexo com mais de 10 caracteres\n";
            if (dadosPaciente[12].Length > 15)
                this.mensagem += "estado civil com mais de 15 caracteres\n";
            if (dadosPaciente[13].Length > 40)
                this.mensagem += "religiao com mais de 40 caracteres\n";
            if (dadosPaciente[14].Length > 2)
                this.mensagem += "valor inválido para número de filhos \n";
            if (dadosPaciente[15].Length > 70)
                this.mensagem += "email com mais de 70 caracteres\n";
            if (dadosPaciente[16].Length > 15)
                this.mensagem += "Celular com mais de 15 caracteres\n";
            if (dadosPaciente[17].Length > 15)
                this.mensagem += "telefone com mais de 15 caracteres \n";
            try
            {
                this.id = Convert.ToInt32(dadosPaciente[0]);
            }
            catch (FormatException)
            {
                this.mensagem += "ID inválido";
            }
        }
    }
}
