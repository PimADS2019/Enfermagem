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
                txbNumContrato.Clear();
                txbNumContrato.Enabled = false;
                cboPeriodo.Text = "";
                cboPeriodo.Enabled = false;
                txbRA.Clear();
                txbRA.Enabled = false;
                cboSemestre.Text = "";
                cboSemestre.Enabled = false;
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
            controleFuncionario controleFuncionario = new controleFuncionario();

            List<String> dadosFuncionario = new List<string>();
            dadosFuncionario.Add(idFuncionario_BD.Text);
            dadosFuncionario.Add(cboTipoUsuario.Text);
            dadosFuncionario.Add(txbUsuario.Text);
            dadosFuncionario.Add(txbSenha.Text);
            dadosFuncionario.Add(txbConfirmaSenha.Text);
            dadosFuncionario.Add(txbNome.Text);
            dadosFuncionario.Add(dtpNascimento.Text);
            dadosFuncionario.Add(txbCpf.Text);
            dadosFuncionario.Add(txbNumContrato.Text);
            dadosFuncionario.Add(txbRA.Text);
            dadosFuncionario.Add(cboPeriodo.Text);
            dadosFuncionario.Add(cboSemestre.Text);
            dadosFuncionario.Add(txbEndereco.Text);
            dadosFuncionario.Add(txbNumeroEndereco.Text);
            dadosFuncionario.Add(txbComplemento.Text);
            dadosFuncionario.Add(txbCidade.Text);
            dadosFuncionario.Add(txbBairro.Text);
            dadosFuncionario.Add(cboEstado.Text);
            dadosFuncionario.Add(txbCep.Text);
            dadosFuncionario.Add(txbEmail.Text);
            dadosFuncionario.Add(txbCelular.Text);
            dadosFuncionario.Add(txbTelefone.Text);

            controleFuncionario.CadastrarFuncionario(dadosFuncionario);

            MessageBox.Show(controleFuncionario.mensagem);



        }

        private void txbNumContrato_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoUsuario.Text == "Aluno")
            {
                txbRA.Enabled = true;
                cboPeriodo.Enabled = true;
                cboSemestre.Enabled = true;
                txbNumContrato.Enabled = false; txbNumContrato.Clear();
            }
            else
            {
                txbRA.Enabled = false; txbRA.Clear();
                cboPeriodo.Enabled = true; 
                cboSemestre.Enabled = false; cboSemestre.Text = "";
                txbNumContrato.Enabled = true;
            }
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
