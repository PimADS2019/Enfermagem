namespace enfunip.apresentacao
{
    partial class frmAgendamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mclDiasAgendados = new System.Windows.Forms.MonthCalendar();
            this.grpAgendamento = new System.Windows.Forms.GroupBox();
            this.txbLocalAgendamento = new System.Windows.Forms.TextBox();
            this.lblObsAgenda = new System.Windows.Forms.Label();
            this.txbObsAgenda = new System.Windows.Forms.TextBox();
            this.lblLocalAgenda = new System.Windows.Forms.Label();
            this.txbPacienteAgenda = new System.Windows.Forms.TextBox();
            this.lblDataAgenda = new System.Windows.Forms.Label();
            this.lblHoraAgenda = new System.Windows.Forms.Label();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.txtHoraAgenda = new System.Windows.Forms.MaskedTextBox();
            this.dtpAgendamento = new System.Windows.Forms.DateTimePicker();
            this.lblPacienteAgenda = new System.Windows.Forms.Label();
            this.lstAgendamentos = new System.Windows.Forms.ListBox();
            this.mnsFunçõesAgendar = new System.Windows.Forms.MenuStrip();
            this.tsmiSalvarAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLimparAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancelarAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAgendamento.SuspendLayout();
            this.mnsFunçõesAgendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mclDiasAgendados
            // 
            this.mclDiasAgendados.Location = new System.Drawing.Point(578, 50);
            this.mclDiasAgendados.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.mclDiasAgendados.Name = "mclDiasAgendados";
            this.mclDiasAgendados.TabIndex = 28;
            // 
            // grpAgendamento
            // 
            this.grpAgendamento.BackColor = System.Drawing.Color.Beige;
            this.grpAgendamento.Controls.Add(this.txbLocalAgendamento);
            this.grpAgendamento.Controls.Add(this.mclDiasAgendados);
            this.grpAgendamento.Controls.Add(this.lblObsAgenda);
            this.grpAgendamento.Controls.Add(this.txbObsAgenda);
            this.grpAgendamento.Controls.Add(this.lblLocalAgenda);
            this.grpAgendamento.Controls.Add(this.txbPacienteAgenda);
            this.grpAgendamento.Controls.Add(this.lblDataAgenda);
            this.grpAgendamento.Controls.Add(this.lblHoraAgenda);
            this.grpAgendamento.Controls.Add(this.btnPaciente);
            this.grpAgendamento.Controls.Add(this.txtHoraAgenda);
            this.grpAgendamento.Controls.Add(this.dtpAgendamento);
            this.grpAgendamento.Controls.Add(this.lblPacienteAgenda);
            this.grpAgendamento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAgendamento.Location = new System.Drawing.Point(4, 21);
            this.grpAgendamento.Name = "grpAgendamento";
            this.grpAgendamento.Size = new System.Drawing.Size(820, 275);
            this.grpAgendamento.TabIndex = 43;
            this.grpAgendamento.TabStop = false;
            // 
            // txbLocalAgendamento
            // 
            this.txbLocalAgendamento.Location = new System.Drawing.Point(318, 93);
            this.txbLocalAgendamento.MaxLength = 30;
            this.txbLocalAgendamento.Name = "txbLocalAgendamento";
            this.txbLocalAgendamento.Size = new System.Drawing.Size(230, 22);
            this.txbLocalAgendamento.TabIndex = 46;
            // 
            // lblObsAgenda
            // 
            this.lblObsAgenda.AutoSize = true;
            this.lblObsAgenda.Location = new System.Drawing.Point(14, 129);
            this.lblObsAgenda.Name = "lblObsAgenda";
            this.lblObsAgenda.Size = new System.Drawing.Size(76, 16);
            this.lblObsAgenda.TabIndex = 45;
            this.lblObsAgenda.Text = "Observação";
            // 
            // txbObsAgenda
            // 
            this.txbObsAgenda.Location = new System.Drawing.Point(17, 150);
            this.txbObsAgenda.MaxLength = 300;
            this.txbObsAgenda.Multiline = true;
            this.txbObsAgenda.Name = "txbObsAgenda";
            this.txbObsAgenda.Size = new System.Drawing.Size(531, 106);
            this.txbObsAgenda.TabIndex = 44;
            // 
            // lblLocalAgenda
            // 
            this.lblLocalAgenda.AutoSize = true;
            this.lblLocalAgenda.Location = new System.Drawing.Point(315, 73);
            this.lblLocalAgenda.Name = "lblLocalAgenda";
            this.lblLocalAgenda.Size = new System.Drawing.Size(39, 16);
            this.lblLocalAgenda.TabIndex = 43;
            this.lblLocalAgenda.Text = "Local";
            // 
            // txbPacienteAgenda
            // 
            this.txbPacienteAgenda.Location = new System.Drawing.Point(17, 39);
            this.txbPacienteAgenda.MaxLength = 50;
            this.txbPacienteAgenda.Name = "txbPacienteAgenda";
            this.txbPacienteAgenda.Size = new System.Drawing.Size(433, 22);
            this.txbPacienteAgenda.TabIndex = 42;
            // 
            // lblDataAgenda
            // 
            this.lblDataAgenda.AutoSize = true;
            this.lblDataAgenda.Location = new System.Drawing.Point(14, 73);
            this.lblDataAgenda.Name = "lblDataAgenda";
            this.lblDataAgenda.Size = new System.Drawing.Size(35, 16);
            this.lblDataAgenda.TabIndex = 40;
            this.lblDataAgenda.Text = "Data";
            // 
            // lblHoraAgenda
            // 
            this.lblHoraAgenda.AutoSize = true;
            this.lblHoraAgenda.Location = new System.Drawing.Point(260, 73);
            this.lblHoraAgenda.Name = "lblHoraAgenda";
            this.lblHoraAgenda.Size = new System.Drawing.Size(35, 16);
            this.lblHoraAgenda.TabIndex = 39;
            this.lblHoraAgenda.Text = "Hora";
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackgroundImage = global::enfunip.Properties.Resources.icons8_pesquisar_26;
            this.btnPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaciente.Location = new System.Drawing.Point(449, 39);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(21, 22);
            this.btnPaciente.TabIndex = 38;
            this.btnPaciente.Text = "...";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // txtHoraAgenda
            // 
            this.txtHoraAgenda.Location = new System.Drawing.Point(263, 92);
            this.txtHoraAgenda.Mask = "90:00";
            this.txtHoraAgenda.Name = "txtHoraAgenda";
            this.txtHoraAgenda.Size = new System.Drawing.Size(35, 22);
            this.txtHoraAgenda.TabIndex = 37;
            this.txtHoraAgenda.ValidatingType = typeof(System.DateTime);
            // 
            // dtpAgendamento
            // 
            this.dtpAgendamento.Location = new System.Drawing.Point(17, 92);
            this.dtpAgendamento.Name = "dtpAgendamento";
            this.dtpAgendamento.Size = new System.Drawing.Size(227, 22);
            this.dtpAgendamento.TabIndex = 36;
            // 
            // lblPacienteAgenda
            // 
            this.lblPacienteAgenda.AutoSize = true;
            this.lblPacienteAgenda.Location = new System.Drawing.Point(14, 19);
            this.lblPacienteAgenda.Name = "lblPacienteAgenda";
            this.lblPacienteAgenda.Size = new System.Drawing.Size(59, 16);
            this.lblPacienteAgenda.TabIndex = 35;
            this.lblPacienteAgenda.Text = "Paciente";
            // 
            // lstAgendamentos
            // 
            this.lstAgendamentos.FormattingEnabled = true;
            this.lstAgendamentos.ItemHeight = 14;
            this.lstAgendamentos.Location = new System.Drawing.Point(4, 301);
            this.lstAgendamentos.Name = "lstAgendamentos";
            this.lstAgendamentos.Size = new System.Drawing.Size(820, 256);
            this.lstAgendamentos.TabIndex = 44;
            // 
            // mnsFunçõesAgendar
            // 
            this.mnsFunçõesAgendar.BackColor = System.Drawing.Color.LightGray;
            this.mnsFunçõesAgendar.Font = new System.Drawing.Font("Arial", 9F);
            this.mnsFunçõesAgendar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSalvarAgenda,
            this.tsmiLimparAgenda,
            this.tsmiCancelarAgenda});
            this.mnsFunçõesAgendar.Location = new System.Drawing.Point(0, 0);
            this.mnsFunçõesAgendar.Name = "mnsFunçõesAgendar";
            this.mnsFunçõesAgendar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnsFunçõesAgendar.Size = new System.Drawing.Size(831, 24);
            this.mnsFunçõesAgendar.TabIndex = 51;
            this.mnsFunçõesAgendar.Text = "menuStrip1";
            // 
            // tsmiSalvarAgenda
            // 
            this.tsmiSalvarAgenda.Image = global::enfunip.Properties.Resources.savedisk_floppydisk_guardar_1543;
            this.tsmiSalvarAgenda.Name = "tsmiSalvarAgenda";
            this.tsmiSalvarAgenda.Size = new System.Drawing.Size(69, 20);
            this.tsmiSalvarAgenda.Text = "Salvar";
            // 
            // tsmiLimparAgenda
            // 
            this.tsmiLimparAgenda.Image = global::enfunip.Properties.Resources.reply_all_button_icon_icons_com_72603;
            this.tsmiLimparAgenda.Name = "tsmiLimparAgenda";
            this.tsmiLimparAgenda.Size = new System.Drawing.Size(74, 20);
            this.tsmiLimparAgenda.Text = "Limpar";
            // 
            // tsmiCancelarAgenda
            // 
            this.tsmiCancelarAgenda.Image = global::enfunip.Properties.Resources.excluir;
            this.tsmiCancelarAgenda.Name = "tsmiCancelarAgenda";
            this.tsmiCancelarAgenda.Size = new System.Drawing.Size(85, 20);
            this.tsmiCancelarAgenda.Text = "Cancelar";
            this.tsmiCancelarAgenda.Click += new System.EventHandler(this.tsmiCancelarAgenda_Click);
            // 
            // frmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(831, 559);
            this.Controls.Add(this.mnsFunçõesAgendar);
            this.Controls.Add(this.lstAgendamentos);
            this.Controls.Add(this.grpAgendamento);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.frmAgendamento_Load);
            this.grpAgendamento.ResumeLayout(false);
            this.grpAgendamento.PerformLayout();
            this.mnsFunçõesAgendar.ResumeLayout(false);
            this.mnsFunçõesAgendar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar mclDiasAgendados;
        private System.Windows.Forms.GroupBox grpAgendamento;
        private System.Windows.Forms.Label lblObsAgenda;
        private System.Windows.Forms.TextBox txbObsAgenda;
        private System.Windows.Forms.Label lblLocalAgenda;
        private System.Windows.Forms.TextBox txbPacienteAgenda;
        private System.Windows.Forms.Label lblDataAgenda;
        private System.Windows.Forms.Label lblHoraAgenda;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.DateTimePicker dtpAgendamento;
        private System.Windows.Forms.Label lblPacienteAgenda;
        private System.Windows.Forms.ListBox lstAgendamentos;
        private System.Windows.Forms.MenuStrip mnsFunçõesAgendar;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalvarAgenda;
        private System.Windows.Forms.ToolStripMenuItem tsmiLimparAgenda;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelarAgenda;
        private System.Windows.Forms.TextBox txbLocalAgendamento;
        private System.Windows.Forms.MaskedTextBox txtHoraAgenda;
    }
}