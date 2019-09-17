namespace enfunip.apresentacao
{
    partial class frmConsultarAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarAgendamento));
            this.grpAgendamentos = new System.Windows.Forms.GroupBox();
            this.btnFecharPesqPac = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txbConsultarAgendamento = new System.Windows.Forms.TextBox();
            this.dgvAgendamentos = new System.Windows.Forms.DataGridView();
            this.grpAgendamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAgendamentos
            // 
            this.grpAgendamentos.BackColor = System.Drawing.Color.Beige;
            this.grpAgendamentos.Controls.Add(this.btnFecharPesqPac);
            this.grpAgendamentos.Controls.Add(this.btnExcluirProduto);
            this.grpAgendamentos.Controls.Add(this.btnEditarProduto);
            this.grpAgendamentos.Controls.Add(this.btnCadProduto);
            this.grpAgendamentos.Controls.Add(this.label2);
            this.grpAgendamentos.Controls.Add(this.groupBox1);
            this.grpAgendamentos.Controls.Add(this.btnAtualizar);
            this.grpAgendamentos.Controls.Add(this.txbConsultarAgendamento);
            this.grpAgendamentos.Controls.Add(this.dgvAgendamentos);
            this.grpAgendamentos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAgendamentos.Location = new System.Drawing.Point(7, 4);
            this.grpAgendamentos.Name = "grpAgendamentos";
            this.grpAgendamentos.Size = new System.Drawing.Size(1285, 590);
            this.grpAgendamentos.TabIndex = 54;
            this.grpAgendamentos.TabStop = false;
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
            this.btnFecharPesqPac.Location = new System.Drawing.Point(1259, 0);
            this.btnFecharPesqPac.Name = "btnFecharPesqPac";
            this.btnFecharPesqPac.Size = new System.Drawing.Size(26, 29);
            this.btnFecharPesqPac.TabIndex = 132;
            this.btnFecharPesqPac.UseVisualStyleBackColor = false;
            this.btnFecharPesqPac.Click += new System.EventHandler(this.BtnFecharPesqPac_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirProduto.Location = new System.Drawing.Point(179, 558);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirProduto.TabIndex = 131;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.BtnExcluirProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProduto.Location = new System.Drawing.Point(98, 558);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnEditarProduto.TabIndex = 130;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadProduto.Location = new System.Drawing.Point(17, 557);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(75, 23);
            this.btnCadProduto.TabIndex = 129;
            this.btnCadProduto.Text = "Cadastrar";
            this.btnCadProduto.UseVisualStyleBackColor = true;
            this.btnCadProduto.Click += new System.EventHandler(this.BtnCadProduto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 27);
            this.label2.TabIndex = 128;
            this.label2.Text = "Consulta de Agenda";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(11, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1260, 10);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(462, 72);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(24, 24);
            this.btnAtualizar.TabIndex = 59;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // txbConsultarAgendamento
            // 
            this.txbConsultarAgendamento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConsultarAgendamento.ForeColor = System.Drawing.Color.Silver;
            this.txbConsultarAgendamento.Location = new System.Drawing.Point(14, 73);
            this.txbConsultarAgendamento.Name = "txbConsultarAgendamento";
            this.txbConsultarAgendamento.Size = new System.Drawing.Size(448, 22);
            this.txbConsultarAgendamento.TabIndex = 53;
            this.txbConsultarAgendamento.Text = "insira data do agendamento";
            // 
            // dgvAgendamentos
            // 
            this.dgvAgendamentos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamentos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAgendamentos.Location = new System.Drawing.Point(17, 110);
            this.dgvAgendamentos.Name = "dgvAgendamentos";
            this.dgvAgendamentos.Size = new System.Drawing.Size(1251, 428);
            this.dgvAgendamentos.TabIndex = 52;
            // 
            // frmConsultarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.Controls.Add(this.grpAgendamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmConsultarAgendamento";
            this.Load += new System.EventHandler(this.FrmConsultarAgendamento_Load);
            this.grpAgendamentos.ResumeLayout(false);
            this.grpAgendamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAgendamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txbConsultarAgendamento;
        private System.Windows.Forms.DataGridView dgvAgendamentos;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnCadProduto;
        private System.Windows.Forms.Button btnFecharPesqPac;
    }
}