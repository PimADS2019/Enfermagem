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
using enfunip.apresentacao;

namespace enfunip
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ControleLogin controle = new ControleLogin(txbUsuario.Text,txbSenha.Text);
            
            if (controle.Mensagem.Equals(""))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
            }

        }

        private void txbSenha_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.btnEntrar_Click(this, null);
            }
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            btnEntrar.BackColor = Color.Transparent;
        }

        private void btnEntrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnEntrar.BackColor = Color.White;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txbUsuario_Enter(object sender, EventArgs e)
        {
            txbUsuario.Clear();
            txbUsuario.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void txbSenha_Enter(object sender, EventArgs e)
        {
            txbSenha.Clear();
            txbSenha.ForeColor = Color.FromArgb(0, 0, 0);
            txbSenha.PasswordChar = '•';
        }


    }
}
