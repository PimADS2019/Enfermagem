using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enfunip.modelo.validacoes
{
    public class validarFuncionario
    {
        public String mensagem;
        public int id;

        public void ValidarDados(List<String> dadosFuncionario)
        {
            this.mensagem = "";

           
             if (dadosFuncionario[2].Length > 50)
                this.mensagem = "Usuario com mais de 50 caracteres \n";
             if (dadosFuncionario[3].Length > 50)
                this.mensagem = "Senha com mais de 8 caracteres \n";
            if (dadosFuncionario[3] != dadosFuncionario[4])
                this.mensagem = "Confirmação de senha não confere com senha \n";
            if (dadosFuncionario[5].Length > 50)
                this.mensagem = "Nome com mais de 50 caracteres \n";
            if (Convert.ToDateTime(dadosFuncionario[6]).Year < 1900)
                this.mensagem += "Data de nascimento inválida, paciente com mais de 110 ano\n";
            if (dadosFuncionario[7].Length > 15)
                this.mensagem += "CPF com mais de 15 caracteres \n";
            if (dadosFuncionario[8].Length > 10)
                this.mensagem += "Numero Contrato com mais de 10 caracteres\n";
            if (dadosFuncionario[9].Length > 10)
                this.mensagem += "RA com mais de 10 caracteres\n";
            if (dadosFuncionario[10].Length > 11)
                this.mensagem += "Periodo com mais de 11 caracteres\n";
            if (dadosFuncionario[11].Length > 50)
                this.mensagem += "endereço com mais de 50 caracteres\n";
            if (dadosFuncionario[12].Length > 8)
                this.mensagem += "número com mais de 8 caracteres \n";
            if (dadosFuncionario[13].Length > 30)
                this.mensagem += "Complemento com mais de 30 caracteres \n";
            if (dadosFuncionario[14].Length > 40)
                this.mensagem += "Cidade com mais de 40 caracteres\n";
            if (dadosFuncionario[15].Length > 40)
                this.mensagem += "bairro com mais de 40 de caracteres\n";
            if (dadosFuncionario[16].Length > 2)
                this.mensagem += "Sigla do estado com mais de 2 caracteres\n";
            if (dadosFuncionario[17].Length > 10)
                this.mensagem += "cep com mais de 10 caracteres\n";
            if (dadosFuncionario[18].Length > 70)
                this.mensagem += "email com mais de 70 caracteres\n";
            if (dadosFuncionario[19].Length > 15)
                this.mensagem += "Celular com mais de 15 caracteres\n";
            if (dadosFuncionario[20].Length > 15)
                this.mensagem += "telefone com mais de 15 caracteres \n";
           /* try
            {
                this.id = Convert.ToInt32(dadosFuncionario[0]);
            }
            catch (FormatException)
            {
                this.mensagem += "ID inválido";
            }*/
        }
    }
}
