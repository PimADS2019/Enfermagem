using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using enfunip.modelo;
using System.Data;

namespace enfunip.dao
{
    
    public class pacientedao : intPessoadao
    {
        Conexao conexaoBD = new Conexao();
        public String mensagem;
        public void CadastrarPaciente(Paciente paciente)
        {
            
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Pessoas(Nome, DataNascimento, Cpf, Sexo, EstadoCivil)
                                    Values(@Nome, @DataNascimento, @Cpf, @Sexo, @EstadoCivil)
                                    declare @id_Pessoa int=@@identity

                                    Insert into Enderecos(Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep, Fk_Pessoas_IdPessoa)
                                    values(@Logradouro, @Numero, @Complemento, @Cidade, @Bairro, @Estado, @Cep, @id_Pessoa)
                                    declare @id_endereco int=@@identity
                                       
                                    insert into Contatos(Email,Celular,Telefone, Fk_Pessoas_IdPessoa)
                                    values (@Email,@Celular,@Telefone,@Id_Pessoa)
                                    select Email,Celular,Telefone,Fk_Pessoas_IdPessoa from Contatos
                                    inner join Pessoas
                                    on Pessoas.IdPessoa = Contatos.Fk_Pessoas_IdPessoa

                                    insert into Pacientes(Religiao, NumeroFilhos, Fk_Pessoas_IdPessoa)
                                    values(@Religiao, @Filhos, @Id_Pessoa)
                                    select Religiao, NumeroFilhos, Fk_Pessoas_IdPessoa from Pacientes
                                     inner join Pessoas
 
                                     on Pessoas.IdPessoa = Pacientes.Fk_Pessoas_IdPessoa";

            cmd.Parameters.AddWithValue("@Nome", paciente.nome);
            cmd.Parameters.AddWithValue("@DataNascimento", paciente.datanascimento);
            cmd.Parameters.AddWithValue("@Cpf", paciente.cpf);
            cmd.Parameters.AddWithValue("@Logradouro", paciente.endereco);
            cmd.Parameters.AddWithValue("@Numero", paciente.numero);
            cmd.Parameters.AddWithValue("@Complemento", paciente.complemento);
            cmd.Parameters.AddWithValue("@Cidade", paciente.cidade);
            cmd.Parameters.AddWithValue("@Bairro", paciente.bairro);
            cmd.Parameters.AddWithValue("@Estado", paciente.estado);
            cmd.Parameters.AddWithValue("@Cep", paciente.cep);
            cmd.Parameters.AddWithValue("@Sexo", paciente.sexo);
            cmd.Parameters.AddWithValue("@EstadoCivil", paciente.estadocivil);
            cmd.Parameters.AddWithValue("@Religiao", paciente.religiao);
            cmd.Parameters.AddWithValue("@Filhos", paciente.filhos);
            cmd.Parameters.AddWithValue("@Email", paciente.email);
            cmd.Parameters.AddWithValue("@Celular", paciente.celular);
            cmd.Parameters.AddWithValue("@Telefone", paciente.telefone);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Paciente cadastrado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void EditarPaciente(Paciente paciente)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Pessoas
                                SET Nome = @Nome,
                                    DataNascimento = @DataNascimento
                                    Cpf = @Cpf
                                WHERE IdPessoa = @id

                                UPDATE Enderecos
                                SET Logradouro = @Logradouro,
                                    Numero = @Numero,
                                    Complemento = @Complemento
                                    Cidade = @Cidade,
                                    Bairro = @Bairro,
                                    Estado = @Estado,
                                    Cep = @Cep
                                WHERE Fk_Pessoas_IdPessoa = @id

                                UPDATE Contatos
                                SET Email = @Email,
                                    Celular = @Celular,
                                    Telefone = @Telefone,
                                WHERE Fk_Pessoas_IdPessoa = @id

                                UPDATE Pacientes
                                SET Religiao = @Religiao,
                                    NumeroFilhos = @Filhos,
                                WHERE Fk_Pessoas_IdPessoa = @id";

            cmd.Parameters.AddWithValue("@id", paciente.id);
            cmd.Parameters.AddWithValue("@Nome", paciente.nome);
            cmd.Parameters.AddWithValue("@DataNascimento", paciente.datanascimento);
            cmd.Parameters.AddWithValue("@Cpf", paciente.cpf);
            cmd.Parameters.AddWithValue("@Logradouro", paciente.endereco);
            cmd.Parameters.AddWithValue("@Numero", paciente.numero);
            cmd.Parameters.AddWithValue("@Complemento", paciente.complemento);
            cmd.Parameters.AddWithValue("@Cidade", paciente.cidade);
            cmd.Parameters.AddWithValue("@Bairro", paciente.bairro);
            cmd.Parameters.AddWithValue("@Estado", paciente.estado);
            cmd.Parameters.AddWithValue("@Cep", paciente.cep);
            cmd.Parameters.AddWithValue("@Sexo", paciente.sexo);
            cmd.Parameters.AddWithValue("@EstadoCivil", paciente.estadocivil);
            cmd.Parameters.AddWithValue("@Religiao", paciente.religiao);
            cmd.Parameters.AddWithValue("@Filhos", paciente.filhos);
            cmd.Parameters.AddWithValue("@Email", paciente.email);
            cmd.Parameters.AddWithValue("@Celular", paciente.celular);
            cmd.Parameters.AddWithValue("@Telefone", paciente.telefone);
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

        public void ExcluirPaciente(Paciente paciente)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from Pessoas 
                                where IdPessoa = @id";
            cmd.Parameters.AddWithValue("@id", paciente.id);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Pessoa excluída com sucesso !!!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public DataTable ListarPaciente()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexaoBD.Conectar();

                cmd.CommandText = @"select IdPessoa, Nome, DataNascimento, Cpf, Sexo, EstadoCivil, Religiao, NumeroFilhos, Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep, Email, Celular, Telefone from
	                            (
		                            select IdPessoa, Nome, DataNascimento, Cpf, Sexo, EstadoCivil, Religiao, NumeroFilhos, Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep from
		                            (
			                            SELECT IdPessoa, Nome, DataNascimento, Cpf, Sexo, EstadoCivil, Religiao, NumeroFilhos, Fk_Pessoas_IdPessoa FROM Pessoas
			                            inner join Pacientes
			                            on Pessoas.IdPessoa = Pacientes.Fk_Pessoas_IdPessoa
		                            ) as Pessoas_pacientes
		                            inner join Enderecos
		                            on Enderecos.Fk_Pessoas_IdPessoa = Pessoas_pacientes.IdPessoa
		                            ) as Pessoas_Pacientes_Endereco
		                            inner join Contatos
		                            on Contatos.Fk_Pessoas_IdPessoa = Pessoas_Pacientes_Endereco.IdPessoa";
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                da.SelectCommand = cmd;
                da.Fill(dt);
                return (dt);
            }
            catch (SqlException )
            {
                throw;
            }
            
        }

        public DataTable PesquisarPaciente(modelo.Paciente paciente)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexaoBD.Conectar();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();

                cmd.CommandText = @"select IdPessoa, Nome, DataNascimento, Cpf, Sexo, EstadoCivil, Religiao, NumeroFilhos, Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep, Email, Celular, Telefone from
	                            (
		                            select IdPessoa, Nome, DataNascimento, Cpf, Sexo, EstadoCivil, Religiao, NumeroFilhos, Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep from
		                            (
			                            SELECT IdPessoa, Nome, DataNascimento, Cpf, Sexo, EstadoCivil, Religiao, NumeroFilhos, Fk_Pessoas_IdPessoa FROM Pessoas
			                            inner join Pacientes
			                            on Pessoas.IdPessoa = Pacientes.Fk_Pessoas_IdPessoa
		                            ) as Pessoas_pacientes
		                            inner join Enderecos
		                            on Enderecos.Fk_Pessoas_IdPessoa = Pessoas_pacientes.IdPessoa
		                            ) as Pessoas_Pacientes_Endereco
		                            inner join Contatos
		                            on Contatos.Fk_Pessoas_IdPessoa = Pessoas_Pacientes_Endereco.IdPessoa
                                    Where Nome like @Nome order by Nome";

                cmd.Parameters.AddWithValue("@nome", "%"+paciente.nome+"%");

                da.SelectCommand = cmd;
                da.Fill(dt);

                return dt;
                
            }
            catch (SqlException)
            {
                throw;
            }

        }

        public Paciente PesquisarPacientePorID(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public List<Paciente> PesquisarPacientePorNome(Paciente paciente)
        {
            throw new NotImplementedException();
        }
    }
}
