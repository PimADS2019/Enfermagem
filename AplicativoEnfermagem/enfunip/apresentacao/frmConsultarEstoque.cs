using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using enfunip.modelo;
using enfunip.modelo.controle;

namespace enfunip.apresentacao
{
    public partial class frmConsultarEstoque : Form
    {
        public frmConsultarEstoque()
        {
            InitializeComponent();
            controleEstoque controleEstoque = new controleEstoque();
            dgv_ListaProdutos.DataSource = controleEstoque.ListarPorNome();
        }

        private void btnFecharPesqPac_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pesquisar (Estoque estoque)
        {
            estoque.produto = txbConsultarProdutos.Text.Trim();

            controleEstoque controleEstoque = new controleEstoque();
            dgv_ListaProdutos.DataSource = controleEstoque.PesquisarPorNome(estoque);
        }
        private void GrpConsultaPaciente_Enter(object sender, EventArgs e)
        {
            controleEstoque controleEstoque = new controleEstoque();
            dgv_ListaProdutos.DataSource = controleEstoque.ListarPorNome();
        }

        private void TxbConsultarProdutos_TextChanged(object sender, EventArgs e)
        {
            if (txbConsultarProdutos.Text.Equals(""))
            {
                controleEstoque controleEstoque = new controleEstoque();
                dgv_ListaProdutos.DataSource = controleEstoque.ListarPorNome();
            }
            else
            {
                Estoque estoque = new Estoque();
                Pesquisar(estoque);
            }
        }

        private void BtnExcluirProduto_Click(object sender, EventArgs e)
        {
            String Id_Excluir;

            DialogResult confirm = MessageBox.Show("Deseja Realmente Excluir o Produto?", "Fechar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                controleEstoque controleEstoque = new controleEstoque();

                Id_Excluir = dgv_ListaProdutos.CurrentRow.Cells[0].Value.ToString();
                controleEstoque.ExcluirItem(Id_Excluir);

                MessageBox.Show(controleEstoque.mensagem);

                dgv_ListaProdutos.DataSource = controleEstoque.ListarPorNome();
            }
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto frmCadastrarProduto = new frmCadastrarProduto();
            frmCadastrarProduto.ShowDialog();
        }

        private void frmListarEstoque_Load(object sender, EventArgs e)
        {
            controleEstoque controleEstoque = new controleEstoque();

            dgv_ListaProdutos.DataSource = controleEstoque.ListarPorNome();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            controleEstoque controleEstoque = new controleEstoque();
            dgv_ListaProdutos.DataSource = controleEstoque.ListarPorNome();
        }

        private void BtnFecharPesqPac_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
