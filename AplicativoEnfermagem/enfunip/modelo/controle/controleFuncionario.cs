using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enfunip.modelo.validacoes;
using enfunip.dao;

namespace enfunip.modelo.controle
{
    public class controleFuncionario
    {
        public String mensagem;
        public void CadastrarFuncionario(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            validarFuncionario validarfuncionario = new validarFuncionario();
            validarfuncionario.ValidarDados(dadosFuncionario);
            if (validarfuncionario.mensagem.Equals(""))
            {
                Funcionario funcionario = new Funcionario();
                funcionario.tipousuario = dadosFuncionario[1];
                funcionario.usuario = dadosFuncionario[2];
                funcionario.senha = dadosFuncionario[3];
                funcionario.confsenha = dadosFuncionario[4];
                funcionario.nome = dadosFuncionario[5];
                funcionario.datanascimento = Convert.ToDateTime(dadosFuncionario[6]);
                funcionario.cpf = dadosFuncionario[7];
                funcionario.numeroContrato= dadosFuncionario[8];
                funcionario.ra = dadosFuncionario[9];
                funcionario.periodo = dadosFuncionario[10];
                funcionario.semestre = dadosFuncionario[11];
                funcionario.endereco = dadosFuncionario[12];
                funcionario.numero = dadosFuncionario[13];
                funcionario.complemento = dadosFuncionario[14];
                funcionario.cidade = dadosFuncionario[15];
                funcionario.bairro = dadosFuncionario[16];
                funcionario.estado = dadosFuncionario[17];
                funcionario.cep = dadosFuncionario[18];
                funcionario.email = dadosFuncionario[19];
                funcionario.celular = dadosFuncionario[20];
                funcionario.telefone = dadosFuncionario[21];

                Funcionariodao funcionarioDAO = new Funcionariodao();
                funcionarioDAO.CadastrarFuncionario(funcionario);
                this.mensagem = funcionarioDAO.mensagem;
            }
            else
            {
                this.mensagem = validarfuncionario.mensagem;
            }
        }

        public Funcionario PesquisarFuncionarioPorID(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            Funcionario funcionario = new Funcionario();
            validarFuncionario validarfuncionario = new validarFuncionario();
            validarfuncionario.ValidarDados(dadosFuncionario);
            if (validarfuncionario.mensagem.Equals(""))
            {
                funcionario.id = validarfuncionario.id;
                Funcionariodao funcionarioDAO = new Funcionariodao();
                funcionario = funcionarioDAO.PesquisarFuncionarioPorID(funcionario);
                this.mensagem = funcionarioDAO.mensagem;
            }
            else
            {
                this.mensagem = validarfuncionario.mensagem;
            }
            return funcionario;
        }

        public void EditarFuncionario(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            Funcionario funcionario = new Funcionario();
            validarFuncionario validarfuncionario = new validarFuncionario();
            if (validarfuncionario.mensagem.Equals(""))
            {
                Funcionario funcionario1 = new Funcionario();
                funcionario1.tipousuario = dadosFuncionario[1];
                funcionario1.usuario = dadosFuncionario[2];
                funcionario1.senha = dadosFuncionario[3];
                funcionario1.confsenha = dadosFuncionario[4];
                funcionario1.nome = dadosFuncionario[5];
                funcionario1.datanascimento = Convert.ToDateTime(dadosFuncionario[6]);
                funcionario1.cpf = dadosFuncionario[7];
                funcionario1.endereco = dadosFuncionario[8];
                funcionario1.numero = dadosFuncionario[9];
                funcionario1.complemento = dadosFuncionario[10];
                funcionario1.cidade = dadosFuncionario[11];
                funcionario1.bairro = dadosFuncionario[12];
                funcionario1.estado = dadosFuncionario[13];
                funcionario1.cep = dadosFuncionario[14];
                funcionario1.email = dadosFuncionario[15];
                funcionario1.celular = dadosFuncionario[16];
                funcionario1.telefone = dadosFuncionario[17];
                Funcionariodao funcionarioDAO = new Funcionariodao();
                funcionarioDAO.EditarFuncionario(funcionario1);
                this.mensagem = funcionarioDAO.mensagem;
            }
            else
            {
                this.mensagem = validarfuncionario.mensagem;
            }
        }
        

        public void ExcluirFuncionario(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            validarFuncionario validarfuncionario = new validarFuncionario();
            validarfuncionario.ValidarDados(dadosFuncionario);
            if (validarfuncionario.mensagem.Equals(""))
            {
                Funcionario funcionario = new Funcionario();
                funcionario.id = validarfuncionario.id;
                Funcionariodao funcionarioDAO = new Funcionariodao();
                if (funcionarioDAO.PesquisarFuncionarioPorID(funcionario).nome != null)
                {
                    funcionarioDAO.ExcluirFuncionario(funcionario);
                    this.mensagem = funcionarioDAO.mensagem;
                }
                else
                {
                    this.mensagem = "Não existe este ID";
                }
            }
            else
            {
                this.mensagem = validarfuncionario.mensagem;
            }
        }

        public void PesquisarFuncionarioPorNome(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            validarFuncionario validarfuncionario = new validarFuncionario();
            validarfuncionario.ValidarDados(dadosFuncionario);
            if (validarfuncionario.mensagem.Equals(""))
            {
                Funcionariodao funcionarioDAO = new Funcionariodao();
                Funcionario funcionario = new Funcionario();
                funcionario.nome = dadosFuncionario[1];
                Estaticos.listaFuncionarioEstatico =
                    funcionarioDAO.PesquisarFuncionarioPorNome(funcionario);
            }
            else
            {
                this.mensagem = validarfuncionario.mensagem;
            }
        }
    }
}
