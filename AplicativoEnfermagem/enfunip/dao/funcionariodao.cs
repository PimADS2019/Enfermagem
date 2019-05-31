using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enfunip.modelo;

namespace enfunip.dao
{
    public class Funcionariodao : intFuncionariodao
    {
        Conexao conexaoBD = new Conexao();
        SqlDataReader dataReader;
        public String mensagem;

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Enderecos
                                    values ('r. nelson c', '340', 'casa', 'Sorocaba', 'VH', 'SP', '18888888')
                                    declare @id_endereco int=@@identity
                                insert into Pessoas
                                    values ('Isac Chuab', '19940802', '99999999999', 'Masculino', 'Casado', 1)
                                    declare @id_Pessoa int=@@identity
                                insert into Alunos
                                    values ( 'd999999', 'Manhã', '3', 1)
                                    declare @id_aluno int=@@identity
                                insert into Contatos
                                    values ('isac@issoai.com', '99999999999', '9999999999', 1))";
            cmd.Parameters.AddWithValue("@tipousuario", funcionario.nome);
            cmd.Parameters.AddWithValue("@usuario", funcionario.nome);
            cmd.Parameters.AddWithValue("@senha", funcionario.nome);
            cmd.Parameters.AddWithValue("@confsenha", funcionario.nome);
            cmd.Parameters.AddWithValue("@Nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@DataNascimento", funcionario.datanascimento);
            cmd.Parameters.AddWithValue("@Cpf", funcionario.cpf);
            cmd.Parameters.AddWithValue("@Logradouro", funcionario.endereco);
            cmd.Parameters.AddWithValue("@Numero", funcionario.numero);
            cmd.Parameters.AddWithValue("@Complemento", funcionario.complemento);
            cmd.Parameters.AddWithValue("@Cidade", funcionario.cidade);
            cmd.Parameters.AddWithValue("@Bairro", funcionario.bairro);
            cmd.Parameters.AddWithValue("@Estado", funcionario.estado);
            cmd.Parameters.AddWithValue("@Cep", funcionario.cep);
            cmd.Parameters.AddWithValue("@Email", funcionario.email);
            cmd.Parameters.AddWithValue("@Celular", funcionario.celular);
            cmd.Parameters.AddWithValue("@Telefone", funcionario.telefone);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Funcionário cadastrado com sucesso !!!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public Funcionario PesquisarFuncionarioPorID(Funcionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Pacientes 
                where id = @id";
            cmd.Parameters.AddWithValue("@id", funcionario.id);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    cmd.Parameters.AddWithValue("@tipousuario", funcionario.nome);
                    cmd.Parameters.AddWithValue("@usuario", funcionario.nome);
                    cmd.Parameters.AddWithValue("@senha", funcionario.nome);
                    cmd.Parameters.AddWithValue("@confsenha", funcionario.nome);
                    cmd.Parameters.AddWithValue("@Nome", funcionario.nome);
                    cmd.Parameters.AddWithValue("@DataNascimento", funcionario.datanascimento);
                    cmd.Parameters.AddWithValue("@Cpf", funcionario.cpf);
                    cmd.Parameters.AddWithValue("@Logradouro", funcionario.endereco);
                    cmd.Parameters.AddWithValue("@Numero", funcionario.numero);
                    cmd.Parameters.AddWithValue("@Complemento", funcionario.complemento);
                    cmd.Parameters.AddWithValue("@Cidade", funcionario.cidade);
                    cmd.Parameters.AddWithValue("@Bairro", funcionario.bairro);
                    cmd.Parameters.AddWithValue("@Estado", funcionario.estado);
                    cmd.Parameters.AddWithValue("@Cep", funcionario.cep);
                    cmd.Parameters.AddWithValue("@Email", funcionario.email);
                    cmd.Parameters.AddWithValue("@Celular", funcionario.celular);
                    cmd.Parameters.AddWithValue("@Telefone", funcionario.telefone);
                    dataReader.Read();
                }
                else
                {
                    funcionario.id = 0;
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return funcionario;
        }

        public void EditarFuncionario(Funcionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update funcionario
                            set nome = @Nome, @DataNascimento, @Cpf, @Logradouro, @Numero, @Complemento,
                 @Cidade, @Bairro, @Estado, @Cep, @Sexo, @EstadoCivil, @Religiao,
                 @Filhos, @Email, @Celular, @Telefone";
            cmd.Parameters.AddWithValue("@tipousuario", funcionario.nome);
            cmd.Parameters.AddWithValue("@usuario", funcionario.nome);
            cmd.Parameters.AddWithValue("@senha", funcionario.nome);
            cmd.Parameters.AddWithValue("@confsenha", funcionario.nome);
            cmd.Parameters.AddWithValue("@id", funcionario.id);
            cmd.Parameters.AddWithValue("@Nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@DataNascimento", funcionario.datanascimento);
            cmd.Parameters.AddWithValue("@Cpf", funcionario.cpf);
            cmd.Parameters.AddWithValue("@Logradouro", funcionario.endereco);
            cmd.Parameters.AddWithValue("@Numero", funcionario.numero);
            cmd.Parameters.AddWithValue("@Complemento", funcionario.complemento);
            cmd.Parameters.AddWithValue("@Cidade", funcionario.cidade);
            cmd.Parameters.AddWithValue("@Bairro", funcionario.bairro);
            cmd.Parameters.AddWithValue("@Estado", funcionario.estado);
            cmd.Parameters.AddWithValue("@Cep", funcionario.cep);
            cmd.Parameters.AddWithValue("@Email", funcionario.email);
            cmd.Parameters.AddWithValue("@Celular", funcionario.celular);
            cmd.Parameters.AddWithValue("@Telefone", funcionario.telefone);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Paciente editado com sucesso !!!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void ExcluirFuncionario(Funcionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from funcionario where id = @id";
            cmd.Parameters.AddWithValue("@id", funcionario.id);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Funcionario excluída com sucesso !!!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public  List<Funcionario> PesquisarFuncionarioPorNome(Funcionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            List<Funcionario> listaFuncionario = new List<Funcionario>();

            cmd.CommandText = @"select * from pessoas 
                where nome like @nome";
            cmd.Parameters.AddWithValue("@Nome", funcionario.nome + "%");

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Funcionario funcionarioLista = new Funcionario();
                    funcionarioLista.id = Convert.ToInt32(dataReader["Id"]);
                    funcionarioLista.nome = dataReader["Nome"].ToString();
                    funcionarioLista.datanascimento = Convert.ToDateTime(dataReader["DataNascimento"].ToString());
                    funcionarioLista.cpf = dataReader["Cpf"].ToString();
                    funcionarioLista.endereco = dataReader["Endereco"].ToString();
                    funcionarioLista.numero = dataReader["Numero"].ToString();
                    funcionarioLista.complemento = dataReader["Complemento"].ToString();
                    funcionarioLista.cidade = dataReader["Cidade"].ToString();
                    funcionarioLista.bairro = dataReader["Bairro"].ToString();
                    funcionarioLista.estado = dataReader["Estado"].ToString();
                    funcionarioLista.cep = dataReader["Cep"].ToString();
                    funcionarioLista.email = dataReader["Email"].ToString();
                    funcionarioLista.celular = dataReader["Celular"].ToString();
                    funcionarioLista.telefone = dataReader["Telefone"].ToString();
                    listaFuncionario.Add(funcionarioLista);

                }

                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return listaFuncionario;
        }
    }
}


