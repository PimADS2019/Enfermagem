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
    public partial class frmCadastrarPaciente : Form
    {
        public frmCadastrarPaciente()
        {
            InitializeComponent();
        }


        private void timer_CadastroPaciente_Tick(object sender, EventArgs e)
        {

        }

        private void pbr_Cadastro_Click(object sender, EventArgs e)
        {

        }


        private void tab_Paciente_Click(object sender, EventArgs e)
        {

        }



        private void frmCadastroPaciente_Load(object sender, EventArgs e)
        {

        }


        private void ckbxCardiovascular_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkMusculoEsqueletica_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkNeurologica_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkRespiratoria_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkSexual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkOutros_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOutros.Checked)
            {
                txbOutros.Enabled = true;
            }
            else
            {
                txbOutros.Clear();
                txbOutros.Enabled = false;
            }
        }


        private void chkTabagismo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkEtilismo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkHospitalizacao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkRenal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkOutrosFamiliar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOutrosFamiliar.Checked)
            {
                txbOutrosFamiliar.Enabled = true;
            }
            else
            {
                txbOutrosFamiliar.Clear();
                txbOutrosFamiliar.Enabled = false;
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbNome.Text) || string.IsNullOrWhiteSpace(txbCpf.Text) ||
                string.IsNullOrWhiteSpace(txbEndereco.Text) || string.IsNullOrWhiteSpace(txbNumeroEndereco.Text) ||
                string.IsNullOrWhiteSpace(txbCidade.Text) || string.IsNullOrWhiteSpace(txbBairro.Text) ||
                string.IsNullOrWhiteSpace(cboEstado.Text) || string.IsNullOrWhiteSpace(txbCep.Text) ||
                string.IsNullOrWhiteSpace(cboSexo.Text) || string.IsNullOrWhiteSpace(txbEmail.Text) ||
                string.IsNullOrWhiteSpace(txbCelular.Text))
            {
                lblCampoObrig.Visible = true;
                VerificarCampos();
                MessageBox.Show("Campos obrigatórios não preenchidos!");
            }
            else
            {
                ApagarMsgErro();

                lblCampoObrig.Visible = false;

                controlePaciente controlePaciente = new controlePaciente();

                List<String> dadosPaciente = new List<string>();
                //Primera tela cliente
                dadosPaciente.Add(idPaciente_BD.Text);
                dadosPaciente.Add(txbNome.Text);
                dadosPaciente.Add(dtpNascimento.Text);
                dadosPaciente.Add(txbCpf.Text);
                dadosPaciente.Add(txbEndereco.Text);
                dadosPaciente.Add(txbNumeroEndereco.Text);
                dadosPaciente.Add(txbComplemento.Text);
                dadosPaciente.Add(txbCidade.Text);
                dadosPaciente.Add(txbBairro.Text);
                dadosPaciente.Add(cboEstado.Text);
                dadosPaciente.Add(txbCep.Text);
                dadosPaciente.Add(cboSexo.Text);
                dadosPaciente.Add(cboEstadoCivil.Text);
                dadosPaciente.Add(txbReligiao.Text);
                dadosPaciente.Add(nudFilhos.Text);
                dadosPaciente.Add(txbEmail.Text);
                dadosPaciente.Add(txbCelular.Text);
                dadosPaciente.Add(txbTelefone.Text);

                //Tela Historico

                controlePaciente.CadastrarPaciente(dadosPaciente);

                MessageBox.Show(controlePaciente.mensagem);

                DialogResult confirm = MessageBox.Show("Deseja realizar um novo cadastro?", "Novo Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

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



        private void chkDormeMedicação_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tsmiCancelar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Fechar o Cadastro?", "Fechar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
                this.Close();
        }


        private void txbOutrosFamiliar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpDadosPaciente_Enter(object sender, EventArgs e)
        {

        }

        private void txbOutros_TextChanged(object sender, EventArgs e)
        {

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

        private void chkPraticaAtvFisc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPraticaAtvFisc.Checked)
            {
                nudAtivFis.Enabled = true;
            }
            else
                nudAtivFis.Enabled = false;
        }

        // Verificação dos Campos Obrigatórios com ErrorProvider
        private bool VerificarCampos()
        {
            bool ok = true;

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
            if (txbEndereco.Text == "")
            {
                ok = false;
                errorProvider.SetError(txbEndereco, "Insira o endereço");
            }
            if (txbNumeroEndereco.Text == "")
            {
                ok = false;
                errorProvider.SetError(txbNumeroEndereco, "Insira o número");
            }
            if (txbCidade.Text == "")
            {
                ok = false;
                errorProvider.SetError(txbCidade, "Insira a cidade");
            }
            if (txbBairro.Text == "")
            {
                ok = false;
                errorProvider.SetError(txbBairro, "Insira o bairro");
            }
            if (cboEstado.Text == "")
            {
                ok = false;
                errorProvider.SetError(cboEstado, "Insira o estado");
            }
            if (txbCep.Text == "")
            {
                ok = false;
                errorProvider.SetError(txbCep, "Insira o CEP");
            }
            if (cboSexo.Text == "")
            {
                ok = false;
                errorProvider.SetError(cboSexo, "Insira o sexo");
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
            errorProvider.SetError(txbNome, "");
            errorProvider.SetError(txbCpf, "");
            errorProvider.SetError(txbEndereco, "");
            errorProvider.SetError(txbNumeroEndereco, "");
            errorProvider.SetError(txbCidade, "");
            errorProvider.SetError(txbBairro, "");
            errorProvider.SetError(cboEstado, "");
            errorProvider.SetError(txbCep, "");
            errorProvider.SetError(cboSexo, "");
            errorProvider.SetError(txbEmail, "");
            errorProvider.SetError(txbCelular, "");
        }
        private void ApagarTodosCampos()
        {
            // DADOS DO PACIENTE

            txbNome.Clear();
            dtpNascimento.Text = "";
            txbCpf.Clear();
            txbEndereco.Clear();
            txbNumeroEndereco.Clear();
            txbComplemento.Clear();
            txbCidade.Clear();
            txbBairro.Clear();
            cboEstado.Text = "";
            txbCep.Clear();
            cboSexo.Text = "";
            cboEstadoCivil.Text = "";
            txbReligiao.Clear();
            nudFilhos.ResetText();
            txbEmail.Clear();
            txbCelular.Clear();
            txbTelefone.Clear();

            // HISTÓRICO - COMORBIDADES

            chkTabagismo.Checked = false;
            chkEtilismo.Checked = false;
            chkDiabetes.Checked = false;
            chkDislipidemias.Checked = false;
            chkCardiovascular.Checked = false;
            chkMusculoEsqueletica.Checked = false;
            chkNeurologica.Checked = false;
            chkRespiratoria.Checked = false;
            chkRenal.Checked = false;
            chkSexual.Checked = false;
            chkOutros.Checked = false;

            // HISTÓRICO - CONDIÇÕES FREQUENTES

            chkIncontinenciaUrinaria.Checked = false;
            chkIncontinenciaFecal.Checked = false;
            chkDemencia.Checked = false;
            chkQueda.Checked = false;
            chkHospitalizacao.Checked = false;

            // HISTÓRICO - FAMILIAR

            chkDiabetesFamiliar.Checked = false;
            chkRenalFamiliar.Checked = false;
            chkDislipidemiasFamiliar.Checked = false;
            chkNeurologicaFamiliar.Checked = false;
            chkCardiovascularFamiliar.Checked = false;
            chkOutrosFamiliar.Checked = false;

            // HÁBITOS - ALIMENTAÇÃO

            chkFrutas.Checked = false;
            chkLeiteDerivados.Checked = false;
            chkLeguminosasVerduras.Checked = false;
            chkProteinas.Checked = false;
            chkMassas.Checked = false;
            chkLiquidos.Checked = false;

            // HÁBITOS - SONO

            radDormeBem.Checked = false;
            radDormePouco.Checked = false;
            chkDormeMedicação.Checked = false;
            chkPraticaAtvFisc.Checked = false;
            nudAtivFis.ResetText();

            // HÁBITOS - VIDA SEXUAL

            chkSexualAtivo.Checked = false;
            chkMultParceiros.Checked = false;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbNome.Text) || string.IsNullOrWhiteSpace(txbCpf.Text) ||
                string.IsNullOrWhiteSpace(txbEndereco.Text) || string.IsNullOrWhiteSpace(txbNumeroEndereco.Text) ||
                string.IsNullOrWhiteSpace(txbCidade.Text) || string.IsNullOrWhiteSpace(txbBairro.Text) ||
                string.IsNullOrWhiteSpace(cboEstado.Text) || string.IsNullOrWhiteSpace(txbCep.Text) ||
                string.IsNullOrWhiteSpace(cboSexo.Text) || string.IsNullOrWhiteSpace(txbEmail.Text) ||
                string.IsNullOrWhiteSpace(txbCelular.Text))
            {
                lblCampoObrig.Visible = true;
                VerificarCampos();
                MessageBox.Show("Campos obrigatórios não preenchidos!");
            }
            else
            {
                ApagarMsgErro();

                lblCampoObrig.Visible = false;

                controlePaciente controlePaciente = new controlePaciente();

                List<String> dadosPaciente = new List<string>();
                //Primera tela cliente
                dadosPaciente.Add(idPaciente_BD.Text);
                dadosPaciente.Add(txbNome.Text);
                dadosPaciente.Add(dtpNascimento.Text);
                dadosPaciente.Add(txbCpf.Text);
                dadosPaciente.Add(txbEndereco.Text);
                dadosPaciente.Add(txbNumeroEndereco.Text);
                dadosPaciente.Add(txbComplemento.Text);
                dadosPaciente.Add(txbCidade.Text);
                dadosPaciente.Add(txbBairro.Text);
                dadosPaciente.Add(cboEstado.Text);
                dadosPaciente.Add(txbCep.Text);
                dadosPaciente.Add(cboSexo.Text);
                dadosPaciente.Add(cboEstadoCivil.Text);
                dadosPaciente.Add(txbReligiao.Text);
                dadosPaciente.Add(nudFilhos.Text);
                dadosPaciente.Add(txbEmail.Text);
                dadosPaciente.Add(txbCelular.Text);
                dadosPaciente.Add(txbTelefone.Text);

                //Tela Historico

                controlePaciente.CadastrarPaciente(dadosPaciente);

                MessageBox.Show(controlePaciente.mensagem);

                DialogResult confirm = MessageBox.Show("Deseja realizar um novo cadastro?", "Novo Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Fechar o Cadastro?", "Fechar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
                this.Close();
        }
    }
}
