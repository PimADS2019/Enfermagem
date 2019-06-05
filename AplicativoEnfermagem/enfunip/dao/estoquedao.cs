using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enfunip.modelo;
using System.Data.SqlClient;


namespace enfunip.dao
{
    class Estoquedao : intEstoquedao
    {
        Conexao conexaoBD = new Conexao();
        SqlDataReader dataReader;
        public String mensagem;

        public void CadastrarItem(Estoque estoque)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Estoques (NomeProduto, QuantidadeProduto,DescricaoProduto,DataHrCadastroProduto)
                                    values (@Produto,@Quantidade,@Descricao,@DataEntrada)";
     
            cmd.Parameters.AddWithValue("@DataEntrada", estoque.dataentrada);
            cmd.Parameters.AddWithValue("@Produto", estoque.produto);
            cmd.Parameters.AddWithValue("@Quantidade", estoque.quantidade);
            cmd.Parameters.AddWithValue("@Descricao", estoque.descricao);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Estoque cadastrado com sucesso !!!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void EditarItem(Estoque estoque)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update estoque
                            set nome = @Nome, @DataNascimento, @Cpf, @Logradouro, @Numero, @Complemento,
                 @Cidade, @Bairro, @Estado, @Cep, @Sexo, @EstadoCivil, @Religiao,
                 @Filhos, @Email, @Celular, @Telefone";
            cmd.Parameters.AddWithValue("@DataEntrada", estoque.dataentrada);
            cmd.Parameters.AddWithValue("@Produto", estoque.produto);
            cmd.Parameters.AddWithValue("@Quantidade", estoque.quantidade);
            cmd.Parameters.AddWithValue("@fabricante", estoque.fabricante);
            cmd.Parameters.AddWithValue("@Categoria", estoque.categoria);
            cmd.Parameters.AddWithValue("@Descricao", estoque.descricao);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Estoque editado com sucesso !!!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void ExcluirItem(Estoque estoque)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from estoque where id = @id";
            cmd.Parameters.AddWithValue("@id", estoque.id);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "estoque excluída com sucesso !!!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public List<Estoque> PesquisarItemPorNome (Estoque estoque)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            List<Estoque> listaEstoque = new List<Estoque>();

            cmd.CommandText = @"select * from pessoas 
                where nome like @nome";
            cmd.Parameters.AddWithValue("@Nome", estoque.produto + "%");

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Estoque estoqueLista = new Estoque();
                    estoqueLista.id = Convert.ToInt32(dataReader["Id"]);
                    estoqueLista.dataentrada = Convert.ToDateTime(dataReader["DataEntrada"].ToString());
                    estoqueLista.produto = dataReader["Produto"].ToString();
                    estoqueLista.quantidade = Convert.ToInt32(dataReader["Quantidade"]);
                    estoqueLista.fabricante = dataReader["Fabricante"].ToString();
                    estoqueLista.categoria = dataReader["Categoria"].ToString();
                    estoqueLista.descricao = dataReader["Descricao"].ToString();
                    listaEstoque.Add(estoqueLista);

                }

                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return listaEstoque;
        }
        
        public Estoque PesquisarItemPorID(Estoque estoque)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Pacientes 
                where id = @id";
            cmd.Parameters.AddWithValue("@id", estoque.id);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    cmd.Parameters.AddWithValue("@DataEntrada", estoque.dataentrada);
                    cmd.Parameters.AddWithValue("@Produto", estoque.produto);
                    cmd.Parameters.AddWithValue("@Quantidade", estoque.quantidade);
                    cmd.Parameters.AddWithValue("@fabricante", estoque.fabricante);
                    cmd.Parameters.AddWithValue("@Categoria", estoque.categoria);
                    cmd.Parameters.AddWithValue("@Descricao", estoque.descricao);
                    dataReader.Read();
                }
                else
                {
                    estoque.id = 0;
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return estoque;
        }
    }
}
