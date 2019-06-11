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
            this.txbConsultarPaciente = new System.Windows.Forms.TextBox();
            this.grpConsultaPaciente = new System.Windows.Forms.GroupBox();
            this.dgv_Pacientes = new System.Windows.Forms.DataGridView();
            this.btnExcluirPaciente = new System.Windows.Forms.Button();
            this.btnEditarPaciente = new System.Windows.Forms.Button();
            this.btnIncuirPaciente = new System.Windows.Forms.Button();
            this.btnFecharPesqPac = new System.Windows.Forms.Button();
            this.grpConsultaPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txbConsultarPaciente
            // 
            this.txbConsultarPaciente.ForeColor = System.Drawing.Color.Silver;
            this.txbConsultarPaciente.Location = new System.Drawing.Point(6, 39);
            this.txbConsultarPaciente.MaxLength = 50;
            this.txbConsultarPaciente.Name = "txbConsultarPaciente";
            this.txbConsultarPaciente.Size = new System.Drawing.Size(519, 22);
            this.txbConsultarPaciente.TabIndex = 44;
            this.txbConsultarPaciente.Text = "Insira nome do paciente";
            this.txbConsultarPaciente.Click += new System.EventHandler(this.txbConsultarPaciente_Click);
            this.txbConsultarPaciente.TextChanged += new System.EventHandler(this.txbConsultarPaciente_TextChanged);
            // 
            // grpConsultaPaciente
            // 
            this.grpConsultaPaciente.BackColor = System.Drawing.Color.Beige;
            this.grpConsultaPaciente.Controls.Add(this.dgv_Pacientes);
            this.grpConsultaPaciente.Controls.Add(this.btnExcluirPaciente);
            this.grpConsultaPaciente.Controls.Add(this.btnEditarPaciente);
            this.grpConsultaPaciente.Controls.Add(this.btnIncuirPaciente);
            this.grpConsultaPaciente.Controls.Add(this.txbConsultarPaciente);
            this.grpConsultaPaciente.Controls.Add(this.btnFecharPesqPac);
            this.grpConsultaPaciente.Location = new System.Drawing.Point(3, -4);
            this.grpConsultaPaciente.Name = "grpConsultaPaciente";
            this.grpConsultaPaciente.Size = new System.Drawing.Size(695, 598);
            this.grpConsultaPaciente.TabIndex = 46;
            this.grpConsultaPaciente.TabStop = false;
            this.grpConsultaPaciente.Enter += new System.EventHandler(this.GrpConsultaPaciente_Enter);
            // 
            // dgv_Pacientes
            // 
            this.dgv_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pacientes.Location = new System.Drawing.Point(6, 78);
            this.dgv_Pacientes.Name = "dgv_Pacientes";
            this.dgv_Pacientes.Size = new System.Drawing.Size(683, 370);
            this.dgv_Pacientes.TabIndex = 54;
            // 
            // btnExcluirPaciente
            // 
            this.btnExcluirPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirPaciente.Location = new System.Drawing.Point(173, 470);
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
            this.btnEditarPaciente.Location = new System.Drawing.Point(90, 470);
            this.btnEditarPaciente.Name = "btnEditarPaciente";
            this.btnEditarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnEditarPaciente.TabIndex = 52;
            this.btnEditarPaciente.Text = "Editar";
            this.btnEditarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnIncuirPaciente
            // 
            this.btnIncuirPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncuirPaciente.Location = new System.Drawing.Point(6, 470);
            this.btnIncuirPaciente.Name = "btnIncuirPaciente";
            this.btnIncuirPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnIncuirPaciente.TabIndex = 51;
            this.btnIncuirPaciente.Text = "Incluir";
            this.btnIncuirPaciente.UseVisualStyleBackColor = true;
            this.btnIncuirPaciente.Click += new System.EventHandler(this.btnIncuirPaciente_Click);
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
            this.btnFecharPesqPac.Location = new System.Drawing.Point(674, 5);
            this.btnFecharPesqPac.Name = "btnFecharPesqPac";
            this.btnFecharPesqPac.Size = new System.Drawing.Size(22, 23);
            this.btnFecharPesqPac.TabIndex = 21;
            this.btnFecharPesqPac.UseVisualStyleBackColor = false;
            this.btnFecharPesqPac.Click += new System.EventHandler(this.btnFecharPesqPac_Click);
            // 
            // frmConsultarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(700, 600);
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
        private System.Windows.Forms.Button btnFecharPesqPac;
        private System.Windows.Forms.Button btnExcluirPaciente;
        private System.Windows.Forms.Button btnEditarPaciente;
        private System.Windows.Forms.Button btnIncuirPaciente;
        private System.Windows.Forms.DataGridView dgv_Pacientes;
    }
}