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
    public partial class frmConsultarPaciente : Form
    {
        public frmConsultarPaciente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
        }

        private void txbConsultarPaciente_Click(object sender, EventArgs e)
        {
            txbConsultarPaciente.Clear();
            txbConsultarPaciente.ForeColor = Color.FromArgb(0, 0, 0);

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFecharPesqPac_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
