using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using enfunip.modelo;
using enfunip.modelo.controle;

namespace enfunip.apresentacao
{
    public partial class frmConsultarPaciente : Form
    {
        public frmConsultarPaciente()
        {
            InitializeComponent();
        }



        private void txbConsultarPaciente_TextChanged(object sender, EventArgs e)
        {
            if (txbConsultarPaciente.Text.Equals(""))
            {
                modelo.controle.controlePaciente controlePaciente = new modelo.controle.controlePaciente();

                dgv_Pacientes.DataSource = controlePaciente.ListarPaciente();              
            }
            else
            {
                modelo.Paciente paciente = new modelo.Paciente();
                Pesquisar(paciente);
            }
        }


        private void btnIncuirPaciente_Click(object sender, EventArgs e)
        {
            frmCadastrarPaciente frmCadastrarPaciente = new frmCadastrarPaciente();
            frmCadastrarPaciente.ShowDialog();
        }

        private void Pesquisar(modelo.Paciente paciente)
        {
            paciente.nome = (txbConsultarPaciente.Text.Trim());

            modelo.controle.controlePaciente controlePaciente = new modelo.controle.controlePaciente();

            dgv_Pacientes.DataSource = controlePaciente.PesquisarPaciente(paciente);
        }

        private void GrpConsultaPaciente_Enter(object sender, EventArgs e)
        {
            modelo.controle.controlePaciente controlePaciente = new modelo.controle.controlePaciente();

            dgv_Pacientes.DataSource = controlePaciente.ListarPaciente();
        }

        private void BtnExcluirPaciente_Click(object sender, EventArgs e)
        {
            String Excluir_Id;

            DialogResult confirm = MessageBox.Show("Deseja Realmente Excluir o Paciente?", "Exclusão de Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                modelo.controle.controlePaciente controlePaciente = new modelo.controle.controlePaciente(); 

                Excluir_Id = dgv_Pacientes.CurrentRow.Cells[0].Value.ToString();
                controlePaciente.ExcluirPaciente(Excluir_Id);

                MessageBox.Show(controlePaciente.mensagem);

                controlePaciente = new modelo.controle.controlePaciente();

                dgv_Pacientes.DataSource = controlePaciente.ListarPaciente();

            }
            
        }

        private void btnIncluirAgenda_Click(object sender, EventArgs e)
        {
            Estaticos.IncluirId = dgv_Pacientes.CurrentRow.Cells[1].Value.ToString();
             
            this.Close();

        }
        
        private void txbConsultarPaciente_Enter(object sender, EventArgs e)
        {
            txbConsultarPaciente.Clear();
            txbConsultarPaciente.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnFecharPesqPac_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
