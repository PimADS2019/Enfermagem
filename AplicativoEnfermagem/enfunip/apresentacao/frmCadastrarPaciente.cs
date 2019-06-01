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
            MessageBox.Show("Paciente cadastrado com sucesso");
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


        }

        private void chkPraticaAtvFisc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPraticaAtvFisc.Checked)
            {
                nudAtivFis.Enabled = true;
            }
        }
    }
}
