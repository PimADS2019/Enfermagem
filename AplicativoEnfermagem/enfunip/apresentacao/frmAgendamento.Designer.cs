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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendamento));
            this.mclDiasAgendados = new System.Windows.Forms.MonthCalendar();
            this.grpAgendamento = new System.Windows.Forms.GroupBox();
            this.mtxDataHoraAgenda = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCampoObrigatorio = new System.Windows.Forms.Label();
            this.lblCampoObrig = new System.Windows.Forms.Label();
            this.txbLocalAgendamento = new System.Windows.Forms.TextBox();
            this.lblObsAgenda = new System.Windows.Forms.Label();
            this.txbObsAgenda = new System.Windows.Forms.TextBox();
            this.lblLocalAgenda = new System.Windows.Forms.Label();
            this.txbPacienteAgenda = new System.Windows.Forms.TextBox();
            this.lblDataHoraAgenda = new System.Windows.Forms.Label();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.lblPacienteAgenda = new System.Windows.Forms.Label();
            this.mnsFunçõesAgendar = new System.Windows.Forms.MenuStrip();
            this.tsmiSalvarAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLimparAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancelarAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAgendamentos = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAgendamentos = new System.Windows.Forms.GroupBox();
            this.txbConsultarAgendamento = new System.Windows.Forms.TextBox();
            this.grpAgendamento.SuspendLayout();
            this.mnsFunçõesAgendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.grpAgendamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mclDiasAgendados
            // 
            this.mclDiasAgendados.Location = new System.Drawing.Point(562, 58);
            this.mclDiasAgendados.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.mclDiasAgendados.Name = "mclDiasAgendados";
            this.mclDiasAgendados.TabIndex = 28;
            // 
            // grpAgendamento
            // 
            this.grpAgendamento.BackColor = System.Drawing.Color.Beige;
            this.grpAgendamento.Controls.Add(this.mtxDataHoraAgenda);
            this.grpAgendamento.Controls.Add(this.label3);
            this.grpAgendamento.Controls.Add(this.label1);
            this.grpAgendamento.Controls.Add(this.lblCampoObrigatorio);
            this.grpAgendamento.Controls.Add(this.lblCampoObrig);
            this.grpAgendamento.Controls.Add(this.txbLocalAgendamento);
            this.grpAgendamento.Controls.Add(this.mclDiasAgendados);
            this.grpAgendamento.Controls.Add(this.lblObsAgenda);
            this.grpAgendamento.Controls.Add(this.txbObsAgenda);
            this.grpAgendamento.Controls.Add(this.lblLocalAgenda);
            this.grpAgendamento.Controls.Add(this.txbPacienteAgenda);
            this.grpAgendamento.Controls.Add(this.lblDataHoraAgenda);
            this.grpAgendamento.Controls.Add(this.btnPaciente);
            this.grpAgendamento.Controls.Add(this.lblPacienteAgenda);
            this.grpAgendamento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAgendamento.Location = new System.Drawing.Point(4, 21);
            this.grpAgendamento.Name = "grpAgendamento";
            this.grpAgendamento.Size = new System.Drawing.Size(820, 275);
            this.grpAgendamento.TabIndex = 43;
            this.grpAgendamento.TabStop = false;
            // 
            // mtxDataHoraAgenda
            // 
            this.errorProvider.SetIconPadding(this.mtxDataHoraAgenda, -17);
            this.mtxDataHoraAgenda.Location = new System.Drawing.Point(17, 92);
            this.mtxDataHoraAgenda.Mask = "00/00/0000 90:00";
            this.mtxDataHoraAgenda.Name = "mtxDataHoraAgenda";
            this.mtxDataHoraAgenda.Size = new System.Drawing.Size(115, 22);
            this.mtxDataHoraAgenda.TabIndex = 3;
            this.mtxDataHoraAgenda.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxDataHoraAgenda.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(173, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 124;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(90, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 122;
            this.label1.Text = "*";
            // 
            // lblCampoObrigatorio
            // 
            this.lblCampoObrigatorio.AutoSize = true;
            this.lblCampoObrigatorio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lblCampoObrigatorio.Location = new System.Drawing.Point(71, 19);
            this.lblCampoObrigatorio.Name = "lblCampoObrigatorio";
            this.lblCampoObrigatorio.Size = new System.Drawing.Size(13, 16);
            this.lblCampoObrigatorio.TabIndex = 121;
            this.lblCampoObrigatorio.Text = "*";
            // 
            // lblCampoObrig
            // 
            this.lblCampoObrig.AutoSize = true;
            this.lblCampoObrig.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoObrig.ForeColor = System.Drawing.Color.Red;
            this.lblCampoObrig.Location = new System.Drawing.Point(703, 9);
            this.lblCampoObrig.Name = "lblCampoObrig";
            this.lblCampoObrig.Size = new System.Drawing.Size(115, 14);
            this.lblCampoObrig.TabIndex = 120;
            this.lblCampoObrig.Text = "* Campos Obrigatórios";
            this.lblCampoObrig.Visible = false;
            // 
            // txbLocalAgendamento
            // 
            this.errorProvider.SetIconPadding(this.txbLocalAgendamento, -17);
            this.txbLocalAgendamento.Location = new System.Drawing.Point(138, 92);
            this.txbLocalAgendamento.MaxLength = 30;
            this.txbLocalAgendamento.Name = "txbLocalAgendamento";
            this.txbLocalAgendamento.Size = new System.Drawing.Size(357, 22);
            this.txbLocalAgendamento.TabIndex = 4;
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
            this.txbObsAgenda.Size = new System.Drawing.Size(478, 106);
            this.txbObsAgenda.TabIndex = 5;
            // 
            // lblLocalAgenda
            // 
            this.lblLocalAgenda.AutoSize = true;
            this.lblLocalAgenda.Location = new System.Drawing.Point(138, 73);
            this.lblLocalAgenda.Name = "lblLocalAgenda";
            this.lblLocalAgenda.Size = new System.Drawing.Size(39, 16);
            this.lblLocalAgenda.TabIndex = 43;
            this.lblLocalAgenda.Text = "Local";
            // 
            // txbPacienteAgenda
            // 
            this.errorProvider.SetIconPadding(this.txbPacienteAgenda, -17);
            this.txbPacienteAgenda.Location = new System.Drawing.Point(17, 39);
            this.txbPacienteAgenda.MaxLength = 50;
            this.txbPacienteAgenda.Name = "txbPacienteAgenda";
            this.txbPacienteAgenda.Size = new System.Drawing.Size(451, 22);
            this.txbPacienteAgenda.TabIndex = 1;
            this.txbPacienteAgenda.Enter += new System.EventHandler(this.txbPacienteAgenda_Enter);
            // 
            // lblDataHoraAgenda
            // 
            this.lblDataHoraAgenda.AutoSize = true;
            this.lblDataHoraAgenda.Location = new System.Drawing.Point(14, 73);
            this.lblDataHoraAgenda.Name = "lblDataHoraAgenda";
            this.lblDataHoraAgenda.Size = new System.Drawing.Size(77, 16);
            this.lblDataHoraAgenda.TabIndex = 40;
            this.lblDataHoraAgenda.Text = "Data e Hora";
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaciente.BackgroundImage")));
            this.btnPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaciente.Location = new System.Drawing.Point(474, 39);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(21, 22);
            this.btnPaciente.TabIndex = 2;
            this.btnPaciente.Text = "...";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
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
            this.mnsFunçõesAgendar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MnsFunçõesAgendar_ItemClicked);
            // 
            // tsmiSalvarAgenda
            // 
            this.tsmiSalvarAgenda.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSalvarAgenda.Image")));
            this.tsmiSalvarAgenda.Name = "tsmiSalvarAgenda";
            this.tsmiSalvarAgenda.Size = new System.Drawing.Size(69, 20);
            this.tsmiSalvarAgenda.Text = "Salvar";
            this.tsmiSalvarAgenda.Click += new System.EventHandler(this.tsmiSalvarAgenda_Click);
            // 
            // tsmiLimparAgenda
            // 
            this.tsmiLimparAgenda.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLimparAgenda.Image")));
            this.tsmiLimparAgenda.Name = "tsmiLimparAgenda";
            this.tsmiLimparAgenda.Size = new System.Drawing.Size(74, 20);
            this.tsmiLimparAgenda.Text = "Limpar";
            this.tsmiLimparAgenda.Click += new System.EventHandler(this.tsmiLimparAgenda_Click);
            // 
            // tsmiCancelarAgenda
            // 
            this.tsmiCancelarAgenda.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCancelarAgenda.Image")));
            this.tsmiCancelarAgenda.Name = "tsmiCancelarAgenda";
            this.tsmiCancelarAgenda.Size = new System.Drawing.Size(85, 20);
            this.tsmiCancelarAgenda.Text = "Cancelar";
            this.tsmiCancelarAgenda.Click += new System.EventHandler(this.tsmiCancelarAgenda_Click);
            // 
            // dgvAgendamentos
            // 
            this.dgvAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamentos.Location = new System.Drawing.Point(17, 56);
            this.dgvAgendamentos.Name = "dgvAgendamentos";
            this.dgvAgendamentos.Size = new System.Drawing.Size(785, 277);
            this.dgvAgendamentos.TabIndex = 52;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // grpAgendamentos
            // 
            this.grpAgendamentos.Controls.Add(this.txbConsultarAgendamento);
            this.grpAgendamentos.Controls.Add(this.dgvAgendamentos);
            this.grpAgendamentos.Location = new System.Drawing.Point(4, 303);
            this.grpAgendamentos.Name = "grpAgendamentos";
            this.grpAgendamentos.Size = new System.Drawing.Size(820, 340);
            this.grpAgendamentos.TabIndex = 53;
            this.grpAgendamentos.TabStop = false;
            this.grpAgendamentos.Enter += new System.EventHandler(this.grpAgendamentos_Enter);
            // 
            // txbConsultarAgendamento
            // 
            this.txbConsultarAgendamento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConsultarAgendamento.ForeColor = System.Drawing.Color.Silver;
            this.txbConsultarAgendamento.Location = new System.Drawing.Point(17, 22);
            this.txbConsultarAgendamento.Name = "txbConsultarAgendamento";
            this.txbConsultarAgendamento.Size = new System.Drawing.Size(489, 22);
            this.txbConsultarAgendamento.TabIndex = 53;
            this.txbConsultarAgendamento.Text = "insira data do agendamento";
            this.txbConsultarAgendamento.TextChanged += new System.EventHandler(this.txbConsultarAgendamento_TextChanged);
            // 
            // frmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(831, 648);
            this.Controls.Add(this.grpAgendamentos);
            this.Controls.Add(this.mnsFunçõesAgendar);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.grpAgendamentos.ResumeLayout(false);
            this.grpAgendamentos.PerformLayout();
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
        private System.Windows.Forms.Label lblDataHoraAgenda;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Label lblPacienteAgenda;
        private System.Windows.Forms.MenuStrip mnsFunçõesAgendar;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalvarAgenda;
        private System.Windows.Forms.ToolStripMenuItem tsmiLimparAgenda;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelarAgenda;
        private System.Windows.Forms.TextBox txbLocalAgendamento;
        private System.Windows.Forms.Label lblCampoObrig;
        private System.Windows.Forms.DataGridView dgvAgendamentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCampoObrigatorio;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox mtxDataHoraAgenda;
        private System.Windows.Forms.GroupBox grpAgendamentos;
        private System.Windows.Forms.TextBox txbConsultarAgendamento;
    }
}