namespace enfunip.apresentacao
{
    partial class frmConsultarFuncionario
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
            this.grpConsultaPaciente = new System.Windows.Forms.GroupBox();
            this.btnExcluirFuncionario = new System.Windows.Forms.Button();
            this.btnEditarFuncionario = new System.Windows.Forms.Button();
            this.btnIncuirFuncionario = new System.Windows.Forms.Button();
            this.txbConsultarFuncionario = new System.Windows.Forms.TextBox();
            this.lstFuncionarios = new System.Windows.Forms.ListBox();
            this.btnFecharPesqFunc = new System.Windows.Forms.Button();
            this.grpConsultaPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConsultaPaciente
            // 
            this.grpConsultaPaciente.BackColor = System.Drawing.Color.Beige;
            this.grpConsultaPaciente.Controls.Add(this.btnExcluirFuncionario);
            this.grpConsultaPaciente.Controls.Add(this.btnEditarFuncionario);
            this.grpConsultaPaciente.Controls.Add(this.btnIncuirFuncionario);
            this.grpConsultaPaciente.Controls.Add(this.txbConsultarFuncionario);
            this.grpConsultaPaciente.Controls.Add(this.lstFuncionarios);
            this.grpConsultaPaciente.Controls.Add(this.btnFecharPesqFunc);
            this.grpConsultaPaciente.Location = new System.Drawing.Point(4, -3);
            this.grpConsultaPaciente.Name = "grpConsultaPaciente";
            this.grpConsultaPaciente.Size = new System.Drawing.Size(546, 495);
            this.grpConsultaPaciente.TabIndex = 47;
            this.grpConsultaPaciente.TabStop = false;
            // 
            // btnExcluirFuncionario
            // 
            this.btnExcluirFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirFuncionario.Location = new System.Drawing.Point(174, 470);
            this.btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            this.btnExcluirFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirFuncionario.TabIndex = 50;
            this.btnExcluirFuncionario.Text = "Excluir";
            this.btnExcluirFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnEditarFuncionario
            // 
            this.btnEditarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarFuncionario.Location = new System.Drawing.Point(90, 470);
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnEditarFuncionario.TabIndex = 49;
            this.btnEditarFuncionario.Text = "Editar";
            this.btnEditarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnIncuirFuncionario
            // 
            this.btnIncuirFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncuirFuncionario.Location = new System.Drawing.Point(6, 470);
            this.btnIncuirFuncionario.Name = "btnIncuirFuncionario";
            this.btnIncuirFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnIncuirFuncionario.TabIndex = 48;
            this.btnIncuirFuncionario.Text = "Incluir";
            this.btnIncuirFuncionario.UseVisualStyleBackColor = true;
            this.btnIncuirFuncionario.Click += new System.EventHandler(this.btnIncuirFuncionario_Click);
            // 
            // txbConsultarFuncionario
            // 
            this.txbConsultarFuncionario.ForeColor = System.Drawing.Color.Silver;
            this.txbConsultarFuncionario.Location = new System.Drawing.Point(6, 39);
            this.txbConsultarFuncionario.MaxLength = 50;
            this.txbConsultarFuncionario.Name = "txbConsultarFuncionario";
            this.txbConsultarFuncionario.Size = new System.Drawing.Size(534, 22);
            this.txbConsultarFuncionario.TabIndex = 47;
            this.txbConsultarFuncionario.Text = "Insira nome do funcionário";
            this.txbConsultarFuncionario.Click += new System.EventHandler(this.txbConsultarFuncionario_Click);
            // 
            // lstFuncionarios
            // 
            this.lstFuncionarios.FormattingEnabled = true;
            this.lstFuncionarios.ItemHeight = 16;
            this.lstFuncionarios.Location = new System.Drawing.Point(6, 74);
            this.lstFuncionarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstFuncionarios.Name = "lstFuncionarios";
            this.lstFuncionarios.Size = new System.Drawing.Size(534, 388);
            this.lstFuncionarios.TabIndex = 45;
            // 
            // btnFecharPesqFunc
            // 
            this.btnFecharPesqFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFecharPesqFunc.BackColor = System.Drawing.Color.Transparent;
            this.btnFecharPesqFunc.BackgroundImage = global::enfunip.Properties.Resources.excluir;
            this.btnFecharPesqFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFecharPesqFunc.FlatAppearance.BorderSize = 0;
            this.btnFecharPesqFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharPesqFunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFecharPesqFunc.Location = new System.Drawing.Point(524, 4);
            this.btnFecharPesqFunc.Name = "btnFecharPesqFunc";
            this.btnFecharPesqFunc.Size = new System.Drawing.Size(22, 23);
            this.btnFecharPesqFunc.TabIndex = 21;
            this.btnFecharPesqFunc.UseVisualStyleBackColor = false;
            this.btnFecharPesqFunc.Click += new System.EventHandler(this.btnFecharPesqFunc_Click);
            // 
            // frmConsultarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(553, 493);
            this.Controls.Add(this.grpConsultaPaciente);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmConsultarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmConsultarFuncionario";
            this.grpConsultaPaciente.ResumeLayout(false);
            this.grpConsultaPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConsultaPaciente;
        private System.Windows.Forms.Button btnFecharPesqFunc;
        private System.Windows.Forms.TextBox txbConsultarFuncionario;
        private System.Windows.Forms.ListBox lstFuncionarios;
        private System.Windows.Forms.Button btnExcluirFuncionario;
        private System.Windows.Forms.Button btnEditarFuncionario;
        private System.Windows.Forms.Button btnIncuirFuncionario;
    }
}