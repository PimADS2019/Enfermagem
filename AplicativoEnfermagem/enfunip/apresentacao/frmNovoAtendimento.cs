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
            this.Close();
        }
    }
}
