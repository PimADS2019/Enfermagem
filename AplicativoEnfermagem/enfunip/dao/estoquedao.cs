using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enfunip.modelo;
using System.Data.SqlClient;
using System.Data;


namespace enfunip.dao
{
    class Estoquedao : intEstoquedao
    {
        Conexao conexaoBD = new Conexao(); 
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
        
        //Metodo Utilizado para listar os dados estoques
        public DataTable ListarItemPorNome()
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexaoBD.Conectar();
                cmd = new SqlCommand("select * from Estoques", cmd.Connection);

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;              
            }
            catch (SqlException e)
            {
                throw;
            }
            
        }

        //metodo de pesquisa ao digitar
        public DataTable PesquisarProduto(Estoque estoque)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexaoBD.Conectar();

                cmd = new SqlCommand("SELECT * FROM Estoques WHERE NomeProduto Like @Nome ORDER BY NomeProduto", cmd.Connection);
                cmd.Parameters.AddWithValue("@Nome", "%"+estoque.produto+"%");

                da.SelectCommand = cmd;
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Estoque PesquisarItemPorID(Estoque estoque)
        {
            throw new NotImplementedException();
        }

        public List<Estoque> PesquisarItemPorNome(Estoque estoque)
        {
            throw new NotImplementedException();
        }
    }
}
