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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {


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

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txbUsuario_Click(object sender, EventArgs e)
        {
           
        }

        private void txbSenha_Click(object sender, EventArgs e)
        {
          
        }

        private void txbSenha_TextChanged_1(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
