using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using enfunip.modelo;

namespace enfunip.dao
{
    
    public class pacientedao : intPessoadao
    {
        Conexao conexaoBD = new Conexao();
        SqlDataReader dataReader;
        public String mensagem;
        public void CadastrarPaciente(Paciente paciente)
        {
            
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Insert into Enderecos(Logradouro, Numero, Complemento, Cidade, Bairro, Estado, Cep)
                                    values(@Logradouro, @Numero, @Complemento, @Cidade, @Bairro, @Estado, @Cep)
                                    declare @id_endereco int=@@identity

                                    insert into Pessoas(TipoUsuario,Nome, DataNascimento, Cpf,Sexo,EstadoCivil, Fk_Enderecos_IdEndereco)
                                    Values('Paciente', @Nome, @DataNascimento, @Cpf,@Sexo,@EstadoCivil, @id_endereco)
                                    select* from
                                    (
                                        select Nome, DataNascimento, Cpf, Sexo,EstadoCivil, IdEndereco from Enderecos
                                        inner join Pessoas
                                        on Pessoas.Fk_Enderecos_IdEndereco = Enderecos.IdEndereco
                                    ) as Endereco_Pessoas;
                                    declare @id_Pessoa int=@@identity
                                       
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
                this.mensagem = "Paciente cadastrado com sucesso !!!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public Paciente PesquisarPacientePorID(Paciente paciente)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Pacientes 
                where id = @id";
            cmd.Parameters.AddWithValue("@id", paciente.id);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
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
                    dataReader.Read();
                }
                else
                {
                    paciente.id = 0;
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return paciente;
        }

        public void EditarPaciente(Paciente paciente)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update pessoas
                            set nome = @Nome, @DataNascimento, @Cpf, @Logradouro, @Numero, @Complemento,
                 @Cidade, @Bairro, @Estado, @Cep, @Sexo, @EstadoCivil, @Religiao,
                 @Filhos, @Email, @Celular, @Telefone";
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
            cmd.CommandText = @"delete from pessoas where id = @id";
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

        public List<Paciente> PesquisarPacientePorNome(Paciente paciente)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            List<Paciente> listaPaciente = new List<Paciente>();

            cmd.CommandText = @"select * from pessoas 
                where nome like @nome";
            cmd.Parameters.AddWithValue("@Nome", paciente.nome + "%");

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Paciente pacienteLista = new Paciente();
                    pacienteLista.id = Convert.ToInt32(dataReader["Id"]);
                    pacienteLista.nome = dataReader["Nome"].ToString();
                    pacienteLista.datanascimento = Convert.ToDateTime(dataReader["DataNascimento"].ToString());
                    pacienteLista.cpf = dataReader["Cpf"].ToString();
                    pacienteLista.endereco = dataReader["Endereco"].ToString();
                    pacienteLista.numero = dataReader["Numero"].ToString();
                    pacienteLista.complemento = dataReader["Complemento"].ToString();
                    pacienteLista.cidade = dataReader["Cidade"].ToString();
                    pacienteLista.bairro = dataReader["Bairro"].ToString();
                    pacienteLista.estado = dataReader["Estado"].ToString();
                    pacienteLista.cep = dataReader["Cep"].ToString();
                    pacienteLista.sexo = dataReader["Sexo"].ToString();
                    pacienteLista.estadocivil = dataReader["EstadoCivil"].ToString();
                    pacienteLista.religiao = dataReader["Religiao"].ToString();
                    pacienteLista.filhos = dataReader["Filhos"].ToString();
                    pacienteLista.email = dataReader["Email"].ToString();
                    pacienteLista.celular = dataReader["Celular"].ToString();
                    pacienteLista.telefone = dataReader["Telefone"].ToString();
                    listaPaciente.Add(pacienteLista);
               
                }

                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return listaPaciente;
        }
    }
}
