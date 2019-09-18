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

namespace enfunip.apresentacao
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();

            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {
            if (!Estaticos.logado)
            {
                this.Close();
            }

            
        }

        private void lbl_userfix_Click(object sender, EventArgs e)
        {

        }

        private void menu_pac_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void relToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cadastroDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tsbFuncionarios_ButtonClick(object sender, EventArgs e)
        {

        }

        private void tmiCadastrodePacientes_Click(object sender, EventArgs e)
        {
            frmCadastrarPaciente frmCadastrarpacientes = new frmCadastrarPaciente();
            frmCadastrarpacientes.ShowDialog();
        }

        private void tmiAgendar_Click(object sender, EventArgs e)
        {
            frmAgendamento frmAgendamento = new frmAgendamento();
            frmAgendamento.ShowDialog();
        }

        private void tsbLogout_Click(object sender, EventArgs e)
        {
            Estaticos.logado = false;
            frmLogin login = new frmLogin();
            login.ShowDialog();
            if (!Estaticos.logado)
            {
                this.Close();
            }
            
            
        }

        private void tmiConsultaDePacientes_Click(object sender, EventArgs e)
        {
            frmConsultarPaciente frmConsultarPaciente = new frmConsultarPaciente();
            frmConsultarPaciente.ShowDialog();
        }

        private void tmiCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto frmCadastrarProduto = new frmCadastrarProduto();
            frmCadastrarProduto.ShowDialog();
        }

        private void tmiListagemEstoque_Click(object sender, EventArgs e)
        {
            frmConsultarEstoque frmListarEstoque = new frmConsultarEstoque();
            frmListarEstoque.ShowDialog();
        }

        private void tspMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void btnTrocarUsuario_Click(object sender, EventArgs e)
        {
            Estaticos.logado = false;
            frmLogin login = new frmLogin();
            login.ShowDialog();
            if (!Estaticos.logado)
            {
                this.Close();
            }
        }

        private void tmiConsultaDeFuncionarios_Click(object sender, EventArgs e)
        {
            frmConsultarFuncionario frmConsultarFuncionario = new frmConsultarFuncionario();
            frmConsultarFuncionario.ShowDialog();
        }

        private void tmiCadastroDeFuncionarios_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionario frmCadastrarFuncionario = new frmCadastrarFuncionario();
            frmCadastrarFuncionario.ShowDialog();
        }

        private void tmiManual_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Enfermagem\Manual\manual.pdf");
        }

        private void tmiSobre_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new frmSobre();
            frmSobre.ShowDialog();
        }

        private void tsmiPacientes_Click(object sender, EventArgs e)
        {
            frmConsultarPaciente frmConsultarPaciente = new frmConsultarPaciente();
            frmConsultarPaciente.ShowDialog();
        }

        private void tsmiFuncionarios_Click(object sender, EventArgs e)
        {
            frmConsultarFuncionario frmConsultarFuncionario = new frmConsultarFuncionario();
            frmConsultarFuncionario.ShowDialog();
        }

        private void tsmiAgenda_Click(object sender, EventArgs e)
        {
            frmConsultarAgendamento frmConsultarAgendamento = new frmConsultarAgendamento();
            frmConsultarAgendamento.ShowDialog();
        }

        private void tsmiEstoque_Click(object sender, EventArgs e)
        {
            frmConsultarEstoque frmConsultarEstoque = new frmConsultarEstoque();
            frmConsultarEstoque.ShowDialog();
        }
    }
}
