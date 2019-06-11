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
    public partial class frmConsultarFuncionario : Form
    {
        public frmConsultarFuncionario()
        {
            InitializeComponent();
        }

        private void btnFecharPesqFunc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncuirFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionario frmCadastrarFuncionario = new frmCadastrarFuncionario();
            frmCadastrarFuncionario.ShowDialog();
        }

        private void txbConsultarFuncionario_Click(object sender, EventArgs e)
        {
            txbConsultarFuncionario.Clear();
            txbConsultarFuncionario.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void Pesquisar(Funcionario funcionario)
        {
            funcionario.nome = txbConsultarFuncionario.Text.Trim();

            modelo.controle.controleFuncionario controleFuncionario = new modelo.controle.controleFuncionario();

            dgv_Funcionarios.DataSource = controleFuncionario.PesquisarFuncionario(funcionario);
        }

        private void GrpConsultaPaciente_Enter(object sender, EventArgs e)
        {
            Estaticos.TipoUsuario = cboTipoFuncionario.Text;
            modelo.controle.controleFuncionario controleFuncionario = new modelo.controle.controleFuncionario();
            dgv_Funcionarios.DataSource = controleFuncionario.ListarFuncionario();
        }

        private void TxbConsultarFuncionario_TextChanged(object sender, EventArgs e)
        {
            
            if (txbConsultarFuncionario.Text.Equals(""))
            {
                modelo.controle.controleFuncionario controleFuncionario = new modelo.controle.controleFuncionario();

                dgv_Funcionarios.DataSource = controleFuncionario.ListarFuncionario();
            }
            else
            {
                Estaticos.TipoUsuario = cboTipoFuncionario.SelectedItem.ToString();

                Funcionario funcionario = new Funcionario();
                Pesquisar(funcionario);
            }
        }

        private void BtnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            String Id_Excluir;
            DialogResult confirm = MessageBox.Show("Deseja Realmente Excluir o Funcionario?", "Fechar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                modelo.controle.controleFuncionario controleFuncionario = new modelo.controle.controleFuncionario();

                Id_Excluir = dgv_Funcionarios.CurrentRow.Cells[0].Value.ToString();
                controleFuncionario.ExcluirFuncionario(Id_Excluir);
                MessageBox.Show(controleFuncionario.mensagem);
            }
        }
    }
}
