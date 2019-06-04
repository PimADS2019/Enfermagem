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

            if (funcionario.tipousuario.Equals("Professor"))
            {
                cmd.CommandText = @"insert into Enderecos (Logradouro,Numero,Complemento,Cidade,Bairro,Estado,Cep)
                                    values (@Logradouro,@Numero,@Complemento,@Cidade,@Bairro,@Estado,@Cep)
                                    declare @id_endereco int=@@identity

                                insert into Pessoas (TipoUsuario,Usuario,Senha,ConfSenha,Nome,DataNascimento,Cpf, Fk_Enderecos_IdEndereco)
                                Values (@tipousuario,@usuario,@senha,@confsenha,@Nome,@DataNascimento,@Cpf, @id_endereco)
                                select * from
                                (
	                                select TipoUsuario,Usuario,Senha,ConfSenha,Nome,DataNascimento,Cpf,IdEndereco from Enderecos
	                                inner join Pessoas
	                                on Pessoas.Fk_Enderecos_IdEndereco = Enderecos.IdEndereco
                                ) as Endereco_Pessoas;
                                declare @id_Pessoa int=@@identity

                                insert into Professores (NumeroUnipProf, PeriodoProf, Fk_Pessoas_IdPessoa)
                                    values (@NumeroContrato, @Periodo, @id_Pessoa)";
            }

            if (funcionario.tipousuario.Equals("Coordenador"))
            {
                cmd.CommandText = @"insert into Coordenadores (NumeroUnipCood, PeriodoCood, Fk_Pessoas_IdPessoa)
                                    values (@NumeroContrato, @Periodo, @id_Pessoa)";
            }

            if (funcionario.tipousuario.Equals("Aluno"))
            {
                cmd.CommandText = @"Insert into Enderecos(Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep)
                                    values(@Logradouro, @Numero, @Complemento, @Cidade, @Bairro, @Estado, @Cep)
                                    declare @id_endereco int=@@identity

                                    insert into Pessoas(TipoUsuario, Usuario, Senha, ConfSenha, Nome, DataNascimento, Cpf, Fk_Enderecos_IdEndereco)
                                    Values(@TipoUsuario, @Usuario, @Senha, @ConfSenha, @Nome, @DataNascimento, @Cpf, @id_endereco)
                                    select* from
                                    (
                                        select TipoUsuario, Usuario, Senha, ConfSenha, Nome, DataNascimento, Cpf, IdEndereco from Enderecos
                                        inner join Pessoas

                                        on Pessoas.Fk_Enderecos_IdEndereco = Enderecos.IdEndereco
                                    ) as Endereco_Pessoas;
                                    declare @id_Pessoa int=@@identity
                                       
                                    insert into Contatos(Email,Celular,Telefone, Fk_Pessoas_IdPessoa)
                                    values (@Email,@Celular,@Telefone,@Id_Pessoa)
                                    select Email,Celular,Telefone,Fk_Pessoas_IdPessoa from Contatos
                                    inner join Pessoas
                                    on Pessoas.IdPessoa = Contatos.Fk_Pessoas_IdPessoa

                                    insert into Alunos(Ra,Semestre, Fk_Pessoas_IdPessoa)
                                    values (@Ra,@Semestre,@Id_Pessoa)
                                    select Ra,Semestre,Fk_Pessoas_IdPessoa from Alunos
                                    inner join Pessoas
                                    on Pessoas.IdPessoa = Alunos.Fk_Pessoas_IdPessoa";


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
            cmd.Parameters.AddWithValue("@Semestre", funcionario.Semestre);
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
            cmd.CommandText =
                @"select TipoUsuario, Nome, DataNascimento, Email, Celular, Telefone from Contatos
                join Pessoas
                on IdContato = IdPessoa
                where IdPessoa = @IdPessoa";
            cmd.Parameters.AddWithValue("@id", funcionario.id);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    cmd.Parameters.AddWithValue("@TipoUsuario", funcionario.tipousuario);
                    cmd.Parameters.AddWithValue("@Usuario", funcionario.usuario);
                    cmd.Parameters.AddWithValue("@Senha", funcionario.senha);
                    cmd.Parameters.AddWithValue("@ConfSenha", funcionario.confsenha);
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
                            set Nome = @Nome, @DataNascimento, @Cpf, @Logradouro, @Numero, @Complemento,
                 @Cidade, @Bairro, @Estado, @Cep, @Sexo, @EstadoCivil, @Religiao,
                 @Filhos, @Email, @Celular, @Telefone";
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
            cmd.CommandText = @"delete from funcionario where id = @id";
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

        public  List<Funcionario> PesquisarFuncionarioPorNome(Funcionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            List<Funcionario> listaFuncionario = new List<Funcionario>();

            cmd.CommandText = 
                @"select TipoUsuario, Nome, DataNascimento, Email, Celular, Telefone 
                from Contatos
                join Pessoas
                on IdContato = IdPessoa";
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


