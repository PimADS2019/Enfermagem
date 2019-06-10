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
            List<String> dadosItem = new List<string>();

            dadosItem.Add(txbConsultarProdutos.Text);

            modelo.controle.controleEstoque controleestoque = new modelo.controle.controleEstoque();
            controleestoque.PesquisarItemPorNome(dadosItem);
            int cont = 0;
            Boolean loop = true;

            try
            {
                while (loop.Equals(true))
                {
                    lstProdutos.Items.Add(Estaticos.listaEstoqueEstatico[cont].produto);
                    cont++;
                }
                
            }
            catch (Exception)
            {
                cont = 0;
            }
            




        }
    }
}
