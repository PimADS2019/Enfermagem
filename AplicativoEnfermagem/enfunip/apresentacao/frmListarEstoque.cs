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

namespace enfunip.apresentacao
{
    public partial class frmListarEstoque : Form
    {
        public frmListarEstoque()
        {
            InitializeComponent();
        }

        private void btnFecharPesqPac_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncuirProduto_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto frmCadastrarProduto = new frmCadastrarProduto();
            frmCadastrarProduto.ShowDialog();
        }

        private void btnPesqPac_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmListarEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pimEnfermagem2019DataSet1.Estoques'. Você pode movê-la ou removê-la conforme necessário.
            this.estoquesTableAdapter.Fill(this.pimEnfermagem2019DataSet1.Estoques);
           
       

        }

        private void Pesquisar (Estoque estoque)
        {
            estoque.produto = txbConsultarProdutos.Text.Trim();

            modelo.controle.controleEstoque controleEstoque = new modelo.controle.controleEstoque();
            dgv_ListaProdutos.DataSource = controleEstoque.PesquisarPorNome(estoque);
        }
        private void GrpConsultaPaciente_Enter(object sender, EventArgs e)
        {
            modelo.controle.controleEstoque controleEstoque = new modelo.controle.controleEstoque();
            dgv_ListaProdutos.DataSource = controleEstoque.ListarPorNome();
        }

        private void TxbConsultarProdutos_TextChanged(object sender, EventArgs e)
        {
            if (txbConsultarProdutos.Text.Equals(""))
            {
                modelo.controle.controleEstoque controleEstoque = new modelo.controle.controleEstoque();
                dgv_ListaProdutos.DataSource = controleEstoque.ListarPorNome();
            }
            else
            {
                Estoque estoque = new Estoque();
                Pesquisar(estoque);
            }
        }
    }
}
