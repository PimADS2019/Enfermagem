﻿using System;
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
    public partial class frmConsultarAgendamento : Form
    {
        public frmConsultarAgendamento()
        {
            InitializeComponent();

        }
        private void Pesquisar(Agenda agenda)
        {
           agenda.nomePaciente = txbConsultarAgendamento.Text.Trim();

            controleAgenda controleAgenda = new controleAgenda();

            dgvAgendamentos.DataSource = controleAgenda.PesquisarPorNome(agenda);
        }

        private void grpAgendamentos_Enter(object sender, EventArgs e)
        {
            controleAgenda controleAgenda = new controleAgenda();
            dgvAgendamentos.DataSource = controleAgenda.ListarPorNome();
        }

        private void txbConsultarAgendamento_TextChanged(object sender, EventArgs e)
        {
            if (txbConsultarAgendamento.Text.Equals(""))
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


        private void FrmConsultarAgendamento_Load(object sender, EventArgs e)
        {
            controleAgenda controleAgenda = new controleAgenda();

            dgvAgendamentos.DataSource = controleAgenda.ListarPorNome();
        }

        private void BtnFecharPesqPac_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCadProduto_Click(object sender, EventArgs e)
        {
            frmAgendamento frmAgendamento = new frmAgendamento();
            frmAgendamento.Show();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            controleAgenda controleAgenda = new controleAgenda();

            dgvAgendamentos.DataSource = controleAgenda.ListarPorNome();
        }

        private void BtnExcluirProduto_Click(object sender, EventArgs e)
        {
            String Excluir_Id;

            DialogResult confirm = MessageBox.Show("Deseja Realmente Excluir a Consulta ?", "Exclusão da Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                controleAgenda controleAgenda = new controleAgenda();

                Excluir_Id = dgvAgendamentos.SelectedCells[0].Value.ToString();
                controleAgenda.ExcluirAgenda(Excluir_Id);

                MessageBox.Show(controleAgenda.mensagem);

                dgvAgendamentos.DataSource = controleAgenda.ListarPorNome();
            }
        }

        private void TxbConsultarAgendamento_Click(object sender, EventArgs e)
        {
            txbConsultarAgendamento.Clear();
            txbConsultarAgendamento.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void TxbConsultarAgendamento_TextChanged_1(object sender, EventArgs e)
        {
            if (txbConsultarAgendamento.Text.Equals(""))
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
    }
}
