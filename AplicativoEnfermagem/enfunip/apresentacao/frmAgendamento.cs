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
    public partial class frmAgendamento : Form
    {
        public frmAgendamento()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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
            this.Close();
        }
    }
}
