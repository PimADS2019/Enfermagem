namespace enfunip.apresentacao
{
    partial class frmConsultarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarPaciente));
            this.txbConsultarPaciente = new System.Windows.Forms.TextBox();
            this.grpConsultaPaciente = new System.Windows.Forms.GroupBox();
            this.btnFecharPesqPac = new System.Windows.Forms.Button();
            this.lblConsPac = new System.Windows.Forms.Label();
            this.grpBar = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnIncluirAgenda = new System.Windows.Forms.Button();
            this.dgv_Pacientes = new System.Windows.Forms.DataGridView();
            this.btnExcluirPaciente = new System.Windows.Forms.Button();
            this.btnEditarPaciente = new System.Windows.Forms.Button();
            this.btnIncuirPaciente = new System.Windows.Forms.Button();
            this.grpConsultaPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txbConsultarPaciente
            // 
            this.txbConsultarPaciente.ForeColor = System.Drawing.Color.Silver;
            this.txbConsultarPaciente.Location = new System.Drawing.Point(16, 71);
            this.txbConsultarPaciente.MaxLength = 50;
            this.txbConsultarPaciente.Name = "txbConsultarPaciente";
            this.txbConsultarPaciente.Size = new System.Drawing.Size(519, 22);
            this.txbConsultarPaciente.TabIndex = 44;
            this.txbConsultarPaciente.Text = "Insira nome do paciente";
            this.txbConsultarPaciente.Click += new System.EventHandler(this.TxbConsultarPaciente_Click);
            this.txbConsultarPaciente.TextChanged += new System.EventHandler(this.txbConsultarPaciente_TextChanged);
            this.txbConsultarPaciente.Enter += new System.EventHandler(this.txbConsultarPaciente_Enter);
            // 
            // grpConsultaPaciente
            // 
            this.grpConsultaPaciente.BackColor = System.Drawing.Color.Beige;
            this.grpConsultaPaciente.Controls.Add(this.btnFecharPesqPac);
            this.grpConsultaPaciente.Controls.Add(this.lblConsPac);
            this.grpConsultaPaciente.Controls.Add(this.grpBar);
            this.grpConsultaPaciente.Controls.Add(this.btnAtualizar);
            this.grpConsultaPaciente.Controls.Add(this.btnIncluirAgenda);
            this.grpConsultaPaciente.Controls.Add(this.dgv_Pacientes);
            this.grpConsultaPaciente.Controls.Add(this.btnExcluirPaciente);
            this.grpConsultaPaciente.Controls.Add(this.btnEditarPaciente);
            this.grpConsultaPaciente.Controls.Add(this.btnIncuirPaciente);
            this.grpConsultaPaciente.Controls.Add(this.txbConsultarPaciente);
            this.grpConsultaPaciente.Location = new System.Drawing.Point(6, 2);
            this.grpConsultaPaciente.Name = "grpConsultaPaciente";
            this.grpConsultaPaciente.Size = new System.Drawing.Size(1285, 590);
            this.grpConsultaPaciente.TabIndex = 46;
            this.grpConsultaPaciente.TabStop = false;
            this.grpConsultaPaciente.Enter += new System.EventHandler(this.GrpConsultaPaciente_Enter);
            // 
            // btnFecharPesqPac
            // 
            this.btnFecharPesqPac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFecharPesqPac.BackColor = System.Drawing.Color.Transparent;
            this.btnFecharPesqPac.BackgroundImage = global::enfunip.Properties.Resources.excluir;
            this.btnFecharPesqPac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFecharPesqPac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharPesqPac.FlatAppearance.BorderSize = 0;
            this.btnFecharPesqPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharPesqPac.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFecharPesqPac.Location = new System.Drawing.Point(1260, 1);
            this.btnFecharPesqPac.Name = "btnFecharPesqPac";
            this.btnFecharPesqPac.Size = new System.Drawing.Size(26, 29);
            this.btnFecharPesqPac.TabIndex = 137;
            this.btnFecharPesqPac.UseVisualStyleBackColor = false;
            this.btnFecharPesqPac.Click += new System.EventHandler(this.BtnFecharPesqPac_Click_1);
            // 
            // lblConsPac
            // 
            this.lblConsPac.AutoSize = true;
            this.lblConsPac.Font = new System.Drawing.Font("Arial", 18F);
            this.lblConsPac.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConsPac.Location = new System.Drawing.Point(523, 18);
            this.lblConsPac.Name = "lblConsPac";
            this.lblConsPac.Size = new System.Drawing.Size(242, 27);
            this.lblConsPac.TabIndex = 137;
            this.lblConsPac.Text = "Consulta de Paciente";
            // 
            // grpBar
            // 
            this.grpBar.Location = new System.Drawing.Point(9, 48);
            this.grpBar.Name = "grpBar";
            this.grpBar.Size = new System.Drawing.Size(1263, 10);
            this.grpBar.TabIndex = 136;
            this.grpBar.TabStop = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(535, 70);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(24, 24);
            this.btnAtualizar.TabIndex = 56;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnIncluirAgenda
            // 
            this.btnIncluirAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluirAgenda.Location = new System.Drawing.Point(1136, 555);
            this.btnIncluirAgenda.Name = "btnIncluirAgenda";
            this.btnIncluirAgenda.Size = new System.Drawing.Size(131, 26);
            this.btnIncluirAgenda.TabIndex = 55;
            this.btnIncluirAgenda.Text = "Incluir na Agenda";
            this.btnIncluirAgenda.UseVisualStyleBackColor = true;
            this.btnIncluirAgenda.Click += new System.EventHandler(this.btnIncluirAgenda_Click);
            // 
            // dgv_Pacientes
            // 
            this.dgv_Pacientes.AllowUserToAddRows = false;
            this.dgv_Pacientes.AllowUserToDeleteRows = false;
            this.dgv_Pacientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pacientes.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Pacientes.Location = new System.Drawing.Point(16, 111);
            this.dgv_Pacientes.Name = "dgv_Pacientes";
            this.dgv_Pacientes.ReadOnly = true;
            this.dgv_Pacientes.Size = new System.Drawing.Size(1251, 428);
            this.dgv_Pacientes.TabIndex = 54;
            // 
            // btnExcluirPaciente
            // 
            this.btnExcluirPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirPaciente.Location = new System.Drawing.Point(178, 561);
            this.btnExcluirPaciente.Name = "btnExcluirPaciente";
            this.btnExcluirPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirPaciente.TabIndex = 53;
            this.btnExcluirPaciente.Text = "Excluir";
            this.btnExcluirPaciente.UseVisualStyleBackColor = true;
            this.btnExcluirPaciente.Click += new System.EventHandler(this.BtnExcluirPaciente_Click);
            // 
            // btnEditarPaciente
            // 
            this.btnEditarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPaciente.Location = new System.Drawing.Point(97, 561);
            this.btnEditarPaciente.Name = "btnEditarPaciente";
            this.btnEditarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnEditarPaciente.TabIndex = 52;
            this.btnEditarPaciente.Text = "Editar";
            this.btnEditarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnIncuirPaciente
            // 
            this.btnIncuirPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncuirPaciente.Location = new System.Drawing.Point(16, 561);
            this.btnIncuirPaciente.Name = "btnIncuirPaciente";
            this.btnIncuirPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnIncuirPaciente.TabIndex = 51;
            this.btnIncuirPaciente.Text = "Cadastrar";
            this.btnIncuirPaciente.UseVisualStyleBackColor = true;
            this.btnIncuirPaciente.Click += new System.EventHandler(this.btnIncuirPaciente_Click);
            // 
            // frmConsultarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.Controls.Add(this.grpConsultaPaciente);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar Paciente";
            this.grpConsultaPaciente.ResumeLayout(false);
            this.grpConsultaPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbConsultarPaciente;
        private System.Windows.Forms.GroupBox grpConsultaPaciente;
        private System.Windows.Forms.Button btnExcluirPaciente;
        private System.Windows.Forms.Button btnEditarPaciente;
        private System.Windows.Forms.Button btnIncuirPaciente;
        private System.Windows.Forms.DataGridView dgv_Pacientes;
        private System.Windows.Forms.Button btnIncluirAgenda;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblConsPac;
        private System.Windows.Forms.GroupBox grpBar;
        private System.Windows.Forms.Button btnFecharPesqPac;
    }
}