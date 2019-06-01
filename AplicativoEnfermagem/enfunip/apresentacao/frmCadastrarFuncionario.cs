using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enfunip.apresentacao
{
    public partial class frmCadastrarFuncionario : Form
    {
        public frmCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void tsmiCancelar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Fechar o Cadastro?", "Fechar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
                this.Close();
        }

        private void tsmiLimpar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Limpar Todos os Campos?", "Limpar Todos os Campos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);


            if (confirm.ToString().ToUpper() == "YES")
            {
                cboTipoUsuario.Text = "";
                txbUsuario.Clear();
                txbSenha.Clear();
                txbConfirmaSenha.Clear();
                txbNome.Clear();
                txbCpf.Clear();
                dtpNascimento.Text = "";
                txbEndereco.Clear();
                txbNumeroEndereco.Clear();
                txbComplemento.Clear();
                txbCidade.Clear();
                cboEstado.Text = "";
                txbBairro.Clear();
                txbCep.Clear();
                txbEmail.Clear();
                txbCelular.Clear();
                txbTelefone.Clear();
            }
        }

        private void txbConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tsmiSalvar_Click(object sender, EventArgs e)
        {
            if (txbSenha.Text != txbConfirmaSenha.Text)
            {
                MessageBox.Show("Senhas não coincidem. Tente Novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                txbConfirmaSenha.Focus();
            }
            else
            {
                MessageBox.Show("Funcionário Cadastrado com Sucesso!");
           }

                
        }
    }
}
