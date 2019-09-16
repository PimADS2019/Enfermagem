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
                ApagarMsgErro();
                lblCampoObrig.Visible = false;

                ApagarTodosCampos();
            }
        }

        private void tsmiSalvar_Click(object sender, EventArgs e)
        {
            if (txbSenha.Text != txbConfirmaSenha.Text)
            {
                MessageBox.Show("Senhas não coincidem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(cboTipoUsuario.Text) || string.IsNullOrWhiteSpace(txbUsuario.Text) ||
                    string.IsNullOrWhiteSpace(txbSenha.Text) || string.IsNullOrWhiteSpace(txbConfirmaSenha.Text) ||
                    string.IsNullOrWhiteSpace(txbNome.Text) || string.IsNullOrWhiteSpace(txbCpf.Text) ||
                    string.IsNullOrWhiteSpace(txbEmail.Text) || string.IsNullOrWhiteSpace(txbCelular.Text))
                {
                    lblCampoObrig.Visible = true;
                    VerificarCampos();
                    MessageBox.Show("Campos obrigatórios não preenchidos!");
                }
                else
                {
                    ApagarMsgErro();
                    lblCampoObrig.Visible = false;

                    controleFuncionario controleFuncionario = new controleFuncionario();

                    List<String> dadosFuncionario = new List<string>();
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

                    DialogResult confirm = MessageBox.Show("Deseja realizar um novo cadastro?", "Novo Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (confirm.ToString().ToUpper() == "YES")
                    {
                        ApagarTodosCampos();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                    
            }
            
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

        // Verificação dos Campos Obrigatórios com ErrorProvider
        private bool VerificarCampos()
        {
            bool ok = true;

            if (cboTipoUsuario.Text=="")
            {
                ok = false;
                errorProvider.SetError(cboTipoUsuario, "Insira o tipo de usuário");
            }
            if (txbUsuario.Text == "")
            {
                ok = false;
                errorProvider.SetError(txbUsuario, "Insira o usuário");
            }
            if (txbSenha.Text == "")
            {
                ok = false;
                errorProvider.SetError(txbSenha, "Insira a senha");
            }
            if (txbConfirmaSenha.Text == "")
            {
                ok = false;
                errorProvider.SetError(txbConfirmaSenha, "Confirme a senha");
            }
            if (txbNome.Text == "")
            {
                ok = false;
                errorProvider.SetError(txbNome, "Insira o nome");
            }
            if (txbCpf.Text == "")
            {
                ok = false;
                errorProvider.SetError(txbCpf, "Insira o CPF");
            }
            if (txbEmail.Text == "")
            {
                ok = false;
                errorProvider.SetError(txbEmail, "Insira o e-mail");
            }
            if (txbCelular.Text == "")
            {
                ok = false;
                errorProvider.SetError(txbCelular, "Insira o celular");
            }
            return ok;
        }

        // Apagar mensagem de erro no formulário
        private void ApagarMsgErro()
        {
            errorProvider.SetError(cboTipoUsuario, "");
            errorProvider.SetError(txbUsuario, "");
            errorProvider.SetError(txbSenha, "");
            errorProvider.SetError(txbConfirmaSenha, "");
            errorProvider.SetError(txbNome, "");
            errorProvider.SetError(txbCpf, "");
            errorProvider.SetError(txbEmail, "");
            errorProvider.SetError(txbCelular, "");
        }

        private void ApagarTodosCampos()
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

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbSenha.Text != txbConfirmaSenha.Text)
            {
                MessageBox.Show("Senhas não coincidem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(cboTipoUsuario.Text) || string.IsNullOrWhiteSpace(txbUsuario.Text) ||
                    string.IsNullOrWhiteSpace(txbSenha.Text) || string.IsNullOrWhiteSpace(txbConfirmaSenha.Text) ||
                    string.IsNullOrWhiteSpace(txbNome.Text) || string.IsNullOrWhiteSpace(txbCpf.Text) ||
                    string.IsNullOrWhiteSpace(txbEmail.Text) || string.IsNullOrWhiteSpace(txbCelular.Text))
                {
                    lblCampoObrig.Visible = true;
                    VerificarCampos();
                    MessageBox.Show("Campos obrigatórios não preenchidos!");
                }
                else
                {
                    ApagarMsgErro();
                    lblCampoObrig.Visible = false;

                    controleFuncionario controleFuncionario = new controleFuncionario();

                    List<String> dadosFuncionario = new List<string>();
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

                    DialogResult confirm = MessageBox.Show("Deseja realizar um novo cadastro?", "Novo Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (confirm.ToString().ToUpper() == "YES")
                    {
                        ApagarTodosCampos();
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Fechar o Cadastro?", "Fechar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
                this.Close();
        }
    }
}
