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
using enfunip.modelo;

namespace enfunip.apresentacao
{
    public partial class frmAgendamento : Form
    {
        public frmAgendamento()
        {
            InitializeComponent();
        }
        private void Pesquisar(Agenda agenda)
        {
            agenda.dataHoraAgendamento = Convert.ToDateTime(txbConsultarAgendamento.Text.Trim());

            controleAgenda controleAgenda = new controleAgenda();

            dgvAgendamentos.DataSource = controleAgenda.PesquisarPorNome(agenda);
        }
        private void grpAgendamentos_Enter(object sender, EventArgs e)
        {
            controleAgenda controleAgenda = new controleAgenda();
            dgvAgendamentos.DataSource = controleAgenda.ListarPorNome();
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
                ApagarTodosCampos();
            }
        }

        private void tsmiSalvarAgenda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbPacienteAgenda.Text) || string.IsNullOrWhiteSpace(mtxDataHoraAgenda.Text)||
                string.IsNullOrWhiteSpace(txbLocalAgendamento.Text))
            {
                lblCampoObrig.Visible = true;
                VerificarCampos();
                MessageBox.Show("Campos obrigatórios não preenchidos!");
            }
            else
            {
                ApagarMsgErro();
                lblCampoObrig.Visible = false;

                controleAgenda controleAgenda = new controleAgenda();

                List<String> dadosAgenda = new List<string>();

                dadosAgenda.Add(txbPacienteAgenda.Text);
                dadosAgenda.Add(mtxDataHoraAgenda.Text);
                dadosAgenda.Add(txbLocalAgendamento.Text);
                dadosAgenda.Add(txbObsAgenda.Text);

                controleAgenda.CadastrarAgenda(dadosAgenda);

                MessageBox.Show(controleAgenda.mensagem);

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
        private bool VerificarCampos()
        {
            bool ok = true;

            if (txbPacienteAgenda.Text == "")
            {
                ok = false;
                errorProvider.SetError(txbPacienteAgenda, "Insira o paciente");
            }
            if (mtxDataHoraAgenda.Text == "")
            {
                ok = false;
                errorProvider.SetError(mtxDataHoraAgenda, "Insira a data e hora do agendamento");
            }
            if (txbLocalAgendamento.Text == "")
            {
                ok = false;
                errorProvider.SetError(txbLocalAgendamento, "Insira o local do agendamento");
            }
            return ok;
        }
        private void ApagarMsgErro()
        {
            errorProvider.SetError(txbPacienteAgenda, "");
            errorProvider.SetError(mtxDataHoraAgenda, "");
            errorProvider.SetError(txbLocalAgendamento, "");
        }

        private void txbConsultarAgendamento_TextChanged(object sender, EventArgs e)
        {
            if(txbConsultarAgendamento.Text.Equals(""))
            {
                controleAgenda controleAgenda = new controleAgenda();

                dgvAgendamentos.DataSource = controleAgenda.ListarPorNome();
            }
            else
            {
                Agenda agenda = new Agenda();
                Pesquisar(agenda);
            }
            
        }

        private void MnsFunçõesAgendar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txbPacienteAgenda_TextChanged(object sender, EventArgs e)
        {
           

            
        }
        private void ApagarTodosCampos()
        {
            txbPacienteAgenda.Clear();
            mtxDataHoraAgenda.Clear();
            txbLocalAgendamento.Clear();
            txbObsAgenda.Clear();
        }
    }
}
