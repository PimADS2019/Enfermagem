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
            this.Close();
        }



        private void radSimAtivFis_CheckedChanged(object sender, EventArgs e)
        {
            if (radSimAtivFis.Checked)
                nudAtivFis.Enabled = true;
            else
                nudAtivFis.Enabled = false;

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
    }
}
