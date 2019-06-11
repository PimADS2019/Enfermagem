using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enfunip.modelo;
using System.Data;

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

            if (funcionario.tipousuario.Equals("Professor"))
            {
                cmd.CommandText = @" insert into Pessoas(TipoUsuario, Usuario, Senha, ConfSenha, Nome, DataNascimento, Cpf)
                                    Values(@TipoUsuario, @Usuario, @Senha, @ConfSenha, @Nome, @DataNascimento, @Cpf)
                                    declare @id_Pessoa int=@@identity

                                    Insert into Enderecos(Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep, Fk_Pessoas_IdPessoa)
                                    values(@Logradouro, @Numero, @Complemento, @Cidade, @Bairro, @Estado, @Cep, @id_Pessoa)
                                    declare @id_endereco int=@@identity
                                       
                                    insert into Contatos(Email,Celular,Telefone, Fk_Pessoas_IdPessoa)
                                    values (@Email,@Celular,@Telefone,@Id_Pessoa)
                                    select Email,Celular,Telefone,Fk_Pessoas_IdPessoa from Contatos
                                    inner join Pessoas
                                    on Pessoas.IdPessoa = Contatos.Fk_Pessoas_IdPessoa

                                    insert into Professores(NumeroUnipProf,PeriodoProf, Fk_Pessoas_IdPessoa)
                                    values (@NumeroContrato,@Periodo,@Id_Pessoa)
                                    select NumeroUnipProf,PeriodoProf, Fk_Pessoas_IdPessoa from Professores
                                    inner join Pessoas
                                    on Pessoas.IdPessoa = Professores.Fk_Pessoas_IdPessoa";
            }

            if (funcionario.tipousuario.Equals("Coordenador"))
            {
                cmd.CommandText = @"insert into Pessoas(TipoUsuario, Usuario, Senha, ConfSenha, Nome, DataNascimento, Cpf)
                                    Values(@TipoUsuario, @Usuario, @Senha, @ConfSenha, @Nome, @DataNascimento, @Cpf)
                                    declare @id_Pessoa int=@@identity

                                    Insert into Enderecos(Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep, Fk_Pessoas_IdPessoa)
                                    values(@Logradouro, @Numero, @Complemento, @Cidade, @Bairro, @Estado, @Cep, @id_Pessoa)
                                    declare @id_endereco int=@@identity
                                       
                                    insert into Contatos(Email,Celular,Telefone, Fk_Pessoas_IdPessoa)
                                    values (@Email,@Celular,@Telefone,@Id_Pessoa)
                                    select Email,Celular,Telefone,Fk_Pessoas_IdPessoa from Contatos
                                    inner join Pessoas
                                    on Pessoas.IdPessoa = Contatos.Fk_Pessoas_IdPessoa

                                    insert into Coordenadores(NumeroUnipCood,PeriodoCood, Fk_Pessoas_IdPessoa)
                                    values (@NumeroContrato,@Periodo,@Id_Pessoa)
                                    select NumeroUnipCood,PeriodoCood, Fk_Pessoas_IdPessoa from Coordenadores
                                    inner join Pessoas
                                    on Pessoas.IdPessoa = Coordenadores.Fk_Pessoas_IdPessoa";
            }

            if (funcionario.tipousuario.Equals("Aluno"))
            {
                cmd.CommandText = @"insert into Pessoas(TipoUsuario, Usuario, Senha, ConfSenha, Nome, DataNascimento, Cpf)
                                    Values(@TipoUsuario, @Usuario, @Senha, @ConfSenha, @Nome, @DataNascimento, @Cpf)
                                    declare @id_Pessoa int=@@identity

                                    Insert into Enderecos(Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep, Fk_Pessoas_IdPessoa)
                                    values(@Logradouro, @Numero, @Complemento, @Cidade, @Bairro, @Estado, @Cep, @id_Pessoa)
                                    declare @id_endereco int=@@identity
                                       
                                    insert into Contatos(Email,Celular,Telefone, Fk_Pessoas_IdPessoa)
                                    values (@Email,@Celular,@Telefone,@Id_Pessoa)
                                    select Email,Celular,Telefone,Fk_Pessoas_IdPessoa from Contatos
                                    inner join Pessoas
                                    on Pessoas.IdPessoa = Contatos.Fk_Pessoas_IdPessoa

                                    insert into Alunos(Ra,PeriodoAluno,Semestre, Fk_Pessoas_IdPessoa)
                                    values (@Ra,@Periodo,@Semestre,@Id_Pessoa)
                                    select Ra,PeriodoAluno,Semestre,Fk_Pessoas_IdPessoa from Alunos
                                    inner join Pessoas
                                    on Pessoas.IdPessoa = Alunos.Fk_Pessoas_IdPessoa";
            }

            if (funcionario.tipousuario.Equals("Enfermeiro"))
            {
                cmd.CommandText = @"insert into Pessoas(TipoUsuario, Usuario, Senha, ConfSenha, Nome, DataNascimento, Cpf)
                                    Values(@TipoUsuario, @Usuario, @Senha, @ConfSenha, @Nome, @DataNascimento, @Cpf)
                                    declare @id_Pessoa int=@@identity

                                    Insert into Enderecos(Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep, Fk_Pessoas_IdPessoa)
                                    values(@Logradouro, @Numero, @Complemento, @Cidade, @Bairro, @Estado, @Cep, @id_Pessoa)
                                    declare @id_endereco int=@@identity
                                       
                                    insert into Contatos(Email,Celular,Telefone, Fk_Pessoas_IdPessoa)
                                    values (@Email,@Celular,@Telefone,@Id_Pessoa)
                                    select Email,Celular,Telefone,Fk_Pessoas_IdPessoa from Contatos
                                    inner join Pessoas
                                    on Pessoas.IdPessoa = Contatos.Fk_Pessoas_IdPessoa

                                    insert into Enfermeiros(NumeroEnfermeiro,PeriodoEnf, Fk_Pessoas_IdPessoa)
                                    values (@NumeroContrato,@Periodo,@Id_Pessoa)
                                    select NumeroEnfermeiro,PeriodoEnf, Fk_Pessoas_IdPessoa from Enfermeiros
                                    inner join Pessoas
                                    on Pessoas.IdPessoa = Enfermeiros.Fk_Pessoas_IdPessoa";
            }

            cmd.Parameters.AddWithValue("@TipoUsuario", funcionario.tipousuario);
            cmd.Parameters.AddWithValue("@Usuario", funcionario.usuario);
            cmd.Parameters.AddWithValue("@Senha", funcionario.senha);
            cmd.Parameters.AddWithValue("@ConfSenha", funcionario.confsenha);
            cmd.Parameters.AddWithValue("@Nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@DataNascimento", funcionario.datanascimento);
            cmd.Parameters.AddWithValue("@Cpf", funcionario.cpf);
            cmd.Parameters.AddWithValue("@NumeroContrato", funcionario.numeroContrato);
            cmd.Parameters.AddWithValue("@Ra", funcionario.ra);
            cmd.Parameters.AddWithValue("@Semestre", funcionario.semestre);
            cmd.Parameters.AddWithValue("@Periodo", funcionario.periodo);
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

        public void EditarFuncionario(Funcionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Pessoas
                                SET TipoUsuario = @TipoUsuario
                                    Usuario = @Usuario
                                    Senha = @Senha
                                    ConfSenha = @ConfSenha
                                    Nome = @Nome,
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
                                WHERE Fk_Pessoas_IdPessoa = @id";
            cmd.Parameters.AddWithValue("@TipoUsuario", funcionario.tipousuario);
            cmd.Parameters.AddWithValue("@Usuario", funcionario.usuario);
            cmd.Parameters.AddWithValue("@Senha", funcionario.senha);
            cmd.Parameters.AddWithValue("ConfSenha", funcionario.confsenha);
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
                this.mensagem = "Funcionário editado com sucesso !!!!!";
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
            cmd.CommandText = @"delete from Pessoas 
                                where id = @id";
            cmd.Parameters.AddWithValue("@id", funcionario.id);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Funcionário excluído com sucesso !!!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public DataTable ListarFuncionario()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexaoBD.Conectar();

                cmd.CommandText = @"select IdPessoa, Nome, TipoUsuario, Usuario, DataNascimento, Cpf,Semestre,Ra,NumeroUnipCood,NumeroEnfermeiro,PeriodoAluno,PeriodoEnf,PeriodoCood, Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep, Email, Celular, Telefone from
	                                (
		                                select IdPessoa, Nome, TipoUsuario, Usuario, DataNascimento, Cpf,NumeroUnipCood, NumeroEnfermeiro, PeriodoEnf,PeriodoCood, Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep, Email, Celular, Telefone from 
		                                (
			                                select IdPessoa, Nome, TipoUsuario, Usuario, DataNascimento, Cpf, NumeroEnfermeiro, PeriodoEnf, Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep, Email, Celular, Telefone  From
			                                (
				                                select IdPessoa, Nome, TipoUsuario, Usuario, DataNascimento, Cpf, NumeroEnfermeiro, PeriodoEnf, Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep from
				                                (
					                                select IdPessoa, Nome, TipoUsuario, Usuario, DataNascimento, Cpf, NumeroEnfermeiro, PeriodoEnf from Pessoas
					                                inner join Enfermeiros
					                                on Pessoas.IdPessoa = Enfermeiros.Fk_Pessoas_IdPessoa
				                                ) as Pessoas_Enfemeiros
				                                inner join Enderecos
				                                on Enderecos.Fk_Pessoas_IdPessoa  = Pessoas_Enfemeiros.IdPessoa
			                                )as Pessoas_Enderecos
			                                inner join Contatos
			                                on Contatos.Fk_Pessoas_IdPessoa = Pessoas_Enderecos.IdPessoa
		                             ) as Pessoas_Contatos
		                             inner join Coordenadores
		                             on Coordenadores.Fk_Pessoas_IdPessoa = Pessoas_Contatos.IdPessoa
	                            ) as Pessoas_Coordenadores
	                            inner join Alunos
	                            on Alunos.Fk_Pessoas_IdPessoa = Pessoas_Coordenadores.IdPessoa";

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                da.SelectCommand = cmd;
                da.Fill(dt);
                return (dt);
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public DataTable PesquisarFuncionario(modelo.Funcionario funcionario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexaoBD.Conectar();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();

                cmd.CommandText = @"select IdPessoa, Nome, TipoUsuario, Usuario, DataNascimento, Cpf,Semestre,Ra,NumeroUnipCood,NumeroEnfermeiro,PeriodoAluno,PeriodoEnf,PeriodoCood, Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep, Email, Celular, Telefone from
	                                (
		                                select IdPessoa, Nome, TipoUsuario, Usuario, DataNascimento, Cpf,NumeroUnipCood, NumeroEnfermeiro, PeriodoEnf,PeriodoCood, Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep, Email, Celular, Telefone from 
		                                (
			                                select IdPessoa, Nome, TipoUsuario, Usuario, DataNascimento, Cpf, NumeroEnfermeiro, PeriodoEnf, Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep, Email, Celular, Telefone  From
			                                (
				                                select IdPessoa, Nome, TipoUsuario, Usuario, DataNascimento, Cpf, NumeroEnfermeiro, PeriodoEnf, Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep from
				                                (
					                                select IdPessoa, Nome, TipoUsuario, Usuario, DataNascimento, Cpf, NumeroEnfermeiro, PeriodoEnf from Pessoas
					                                inner join Enfermeiros
					                                on Pessoas.IdPessoa = Enfermeiros.Fk_Pessoas_IdPessoa
				                                ) as Pessoas_Enfemeiros
				                                inner join Enderecos
				                                on Enderecos.Fk_Pessoas_IdPessoa  = Pessoas_Enfemeiros.IdPessoa
			                                )as Pessoas_Enderecos
			                                inner join Contatos
			                                on Contatos.Fk_Pessoas_IdPessoa = Pessoas_Enderecos.IdPessoa
		                             ) as Pessoas_Contatos
		                             inner join Coordenadores
		                             on Coordenadores.Fk_Pessoas_IdPessoa = Pessoas_Contatos.IdPessoa
	                            ) as Pessoas_Coordenadores
	                            inner join Alunos
	                            on Alunos.Fk_Pessoas_IdPessoa = Pessoas_Coordenadores.IdPessoa
                                Where Nome like @Nome order by Nome";
                                

                cmd.Parameters.AddWithValue("@nome", "%" + funcionario.nome + "%");

                da.SelectCommand = cmd;
                da.Fill(dt);

                return dt;

            }
            catch (SqlException e)
            {
                throw;
            }

        }

        public Funcionario PesquisarFuncionarioPorID(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> PesquisarFuncionarioPorNome(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }
    }
}


