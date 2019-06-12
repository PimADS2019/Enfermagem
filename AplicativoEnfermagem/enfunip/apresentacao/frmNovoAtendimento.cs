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
    public partial class frmNovoAtendimento : Form
    {
        public frmNovoAtendimento()
        {
            InitializeComponent();
        }

        private void btnPesqPac_Click(object sender, EventArgs e)
        {
            frmConsultarPaciente frmConsultarPaciente = new frmConsultarPaciente();
            frmConsultarPaciente.ShowDialog();
        }

        private void tsmiCancelar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Fechar o Atendimento?", "Fechar Atendimento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
                this.Close();
        }

        private void tsmiLimpar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Limpar Todos os Campos?", "Limpar Todos os Campos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                txbPacienteAtendimento.Clear();
                dtpAtendimento.ResetText();
                txbObsAtendimento.Clear();
            }
        }

        private void tsmiSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atendimento cadastrado com sucesso!");
        }
    }
}
