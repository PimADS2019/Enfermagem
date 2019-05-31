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
    }
}
