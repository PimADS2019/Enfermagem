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
    public class controlePaciente
    {
        public String mensagem;
        public void CadastrarPaciente(List<String> dadosPaciente)
        {
            this.mensagem = "";
            validarPaciente validarpaciente = new validarPaciente();
            validarpaciente.ValidarDados(dadosPaciente);
            if (validarpaciente.mensagem.Equals(""))
            {
                Paciente paciente = new Paciente();
                paciente.nome = dadosPaciente[1];
                paciente.datanascimento = Convert.ToDateTime(dadosPaciente[2]);
                paciente.cpf = dadosPaciente[3];
                paciente.endereco = dadosPaciente[4];
                paciente.numero = dadosPaciente[5];
                paciente.complemento = dadosPaciente[6];
                paciente.cidade = dadosPaciente[7];
                paciente.bairro = dadosPaciente[8];
                paciente.estado = dadosPaciente[9];
                paciente.cep = dadosPaciente[10];
                paciente.sexo = dadosPaciente[11];
                paciente.estadocivil = dadosPaciente[12];
                paciente.religiao = dadosPaciente[13];
                paciente.filhos = dadosPaciente[14];
                paciente.email = dadosPaciente[15];
                paciente.celular = dadosPaciente[16];
                paciente.telefone = dadosPaciente[17];
                pacientedao pacienteDAO = new pacientedao();
                pacienteDAO.CadastrarPaciente(paciente);
                this.mensagem = pacienteDAO.mensagem;
            }
            else
            {
                this.mensagem = validarpaciente.mensagem;
            }
        }
        public void EditarPaciente(List<String> dadosPaciente)
        {
            this.mensagem = "";
            validarPaciente validarpaciente = new validarPaciente();
            validarpaciente.ValidarDados(dadosPaciente);
            if (validarpaciente.mensagem.Equals(""))
            {
                Paciente paciente = new Paciente();
                paciente.id = validarpaciente.id;
                paciente.nome = dadosPaciente[1];
                paciente.datanascimento = Convert.ToDateTime(dadosPaciente[2]);
                paciente.cpf = dadosPaciente[3];
                paciente.endereco = dadosPaciente[4];
                paciente.numero = dadosPaciente[5];
                paciente.complemento = dadosPaciente[6];
                paciente.cidade = dadosPaciente[7];
                paciente.bairro = dadosPaciente[8];
                paciente.estado = dadosPaciente[9];
                paciente.cep = dadosPaciente[10];
                paciente.sexo = dadosPaciente[11];
                paciente.estadocivil = dadosPaciente[12];
                paciente.religiao = dadosPaciente[13];
                paciente.filhos = dadosPaciente[14];
                paciente.email = dadosPaciente[15];
                paciente.celular = dadosPaciente[16];
                paciente.telefone = dadosPaciente[17];
                pacientedao pacienteDAO = new pacientedao();
                pacienteDAO.EditarPaciente(paciente);
                this.mensagem = pacienteDAO.mensagem;
            }
            else
            {
                this.mensagem = validarpaciente.mensagem;
            }
        }

        public void ExcluirPaciente(List<String> dadosPaciente)
        {
            this.mensagem = "";
            validarPaciente validarpaciente = new validarPaciente();
            validarpaciente.ValidarDados(dadosPaciente);
            if (validarpaciente.mensagem.Equals(""))
            {
                Paciente paciente = new Paciente();
                paciente.id = validarpaciente.id;
                pacientedao pacienteDAO = new pacientedao();
                if (pacienteDAO.PesquisarPacientePorID(paciente).nome != null)
                {
                    pacienteDAO.ExcluirPaciente(paciente);
                    this.mensagem = pacienteDAO.mensagem;
                }
                else
                {
                    this.mensagem = "Não existe este ID";
                }
            }
            else
            {
                this.mensagem = validarpaciente.mensagem;
            }
        }

        public DataTable ListarPaciente()
        {
            try
            {
                pacientedao pacienteDAO = new pacientedao();

                DataTable dt = new DataTable();

                dt = pacienteDAO.ListarPaciente();

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable PesquisarPaciente(modelo.Paciente paciente)
        {   
                try
                {
                    pacientedao pacienteDAO = new pacientedao();

                    DataTable dt = new DataTable();

                    dt = pacienteDAO.PesquisarPaciente(paciente);

                    return dt;
                }
                catch (Exception)
                {

                    throw;
                }
        }
    }
}
