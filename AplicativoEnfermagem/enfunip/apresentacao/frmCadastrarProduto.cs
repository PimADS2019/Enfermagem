using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using enfunip.modelo.controle;

namespace enfunip.apresentacao
{
    public partial class frmCadastrarProduto : Form
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void tsmiCancelar_Click(object sender, EventArgs e)
        {
             DialogResult confirm = MessageBox.Show("Deseja Fechar o Cadastro de Produtos?", "Fechar Cadastro de Produtos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
                this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tsmiLimpar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Limpar Todos os Campos?", "Limpar Todos os Campos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                txbProduto.Clear();
                nudQtdProduto.ResetText();
                txbObsProduto.Clear();
            }
        }

        private void tsmiSalvar_Click(object sender, EventArgs e)
        {
            controleEstoque estoque = new controleEstoque();

            List<String> dadosItem= new List<string>();
            dadosItem.Add(idProduto_BD.Text);
            dadosItem.Add(dtpEntradaProduto.Text);
            dadosItem.Add(txbProduto.Text);
            dadosItem.Add(nudQtdProduto.Text);
            dadosItem.Add(txbObsProduto.Text);

            estoque.CadastrarItem(dadosItem);
            MessageBox.Show(estoque.mensagem); ;
        }

        private void grpCadastrarProduto_Enter(object sender, EventArgs e)
        {

        }
    }
}
