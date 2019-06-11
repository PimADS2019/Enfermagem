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
    public partial class frmAgendamento : Form
    {
        public frmAgendamento()
        {
            InitializeComponent();
        }



        private void btnPaciente_Click(object sender, EventArgs e)
        {
            frmConsultarPaciente consultarPaciente = new frmConsultarPaciente();
            consultarPaciente.ShowDialog();
        }

        private void frmAgendamento_Load(object sender, EventArgs e)
        {

        }

        private void tsmiCancelarAgenda_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Fechar o Agendamento?", "Fechar Agendamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
                this.Close();
        }

        private void tsmiLimparAgenda_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Limpar Todos os Campos?", "Limpar Todos os Campos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                txbPacienteAgenda.Clear();
                dtpAgendamento.ResetText();
                txbHoraAgenda.Clear();
                txbLocalAgendamento.Clear();
                txbObsAgenda.Clear();
            }
        }

        private void tsmiSalvarAgenda_Click(object sender, EventArgs e)
        {
            controleAgenda controle = new controleAgenda();
            
            List<String> dadosAgenda = new List<string>();

            dadosAgenda.Add(txbPacienteAgenda.Text);
            dadosAgenda.Add(dtpAgendamento.Text);
            dadosAgenda.Add(txbHoraAgenda.Text);
            dadosAgenda.Add(txbLocalAgendamento.Text);
            dadosAgenda.Add(txbObsAgenda.Text);

            //controleAgenda.CadastrarAgenda(dadosAgenda); < --ERRO


        }
    }
}
