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
            this.lbl_TipoFuncionario = new System.Windows.Forms.Label();
            this.cbx_TipoFuncionario = new System.Windows.Forms.ComboBox();
            this.dgv_Funcionarios = new System.Windows.Forms.DataGridView();
            this.btnExcluirFuncionario = new System.Windows.Forms.Button();
            this.btnEditarFuncionario = new System.Windows.Forms.Button();
            this.btnIncuirFuncionario = new System.Windows.Forms.Button();
            this.txbConsultarFuncionario = new System.Windows.Forms.TextBox();
            this.btnFecharPesqFunc = new System.Windows.Forms.Button();
            this.grpConsultaPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConsultaPaciente
            // 
            this.grpConsultaPaciente.BackColor = System.Drawing.Color.Beige;
            this.grpConsultaPaciente.Controls.Add(this.lbl_TipoFuncionario);
            this.grpConsultaPaciente.Controls.Add(this.cbx_TipoFuncionario);
            this.grpConsultaPaciente.Controls.Add(this.dgv_Funcionarios);
            this.grpConsultaPaciente.Controls.Add(this.btnExcluirFuncionario);
            this.grpConsultaPaciente.Controls.Add(this.btnEditarFuncionario);
            this.grpConsultaPaciente.Controls.Add(this.btnIncuirFuncionario);
            this.grpConsultaPaciente.Controls.Add(this.txbConsultarFuncionario);
            this.grpConsultaPaciente.Controls.Add(this.btnFecharPesqFunc);
            this.grpConsultaPaciente.Location = new System.Drawing.Point(4, -3);
            this.grpConsultaPaciente.Name = "grpConsultaPaciente";
            this.grpConsultaPaciente.Size = new System.Drawing.Size(546, 495);
            this.grpConsultaPaciente.TabIndex = 47;
            this.grpConsultaPaciente.TabStop = false;
            this.grpConsultaPaciente.Enter += new System.EventHandler(this.GrpConsultaPaciente_Enter);
            // 
            // lbl_TipoFuncionario
            // 
            this.lbl_TipoFuncionario.AutoSize = true;
            this.lbl_TipoFuncionario.Location = new System.Drawing.Point(3, 18);
            this.lbl_TipoFuncionario.Name = "lbl_TipoFuncionario";
            this.lbl_TipoFuncionario.Size = new System.Drawing.Size(103, 16);
            this.lbl_TipoFuncionario.TabIndex = 53;
            this.lbl_TipoFuncionario.Text = "Tipo Funcionario";
            // 
            // cbx_TipoFuncionario
            // 
            this.cbx_TipoFuncionario.FormattingEnabled = true;
            this.cbx_TipoFuncionario.Items.AddRange(new object[] {
            "Aluno",
            "Coordenador",
            "Professor",
            "Enfermeiro"});
            this.cbx_TipoFuncionario.Location = new System.Drawing.Point(112, 15);
            this.cbx_TipoFuncionario.Name = "cbx_TipoFuncionario";
            this.cbx_TipoFuncionario.Size = new System.Drawing.Size(121, 24);
            this.cbx_TipoFuncionario.TabIndex = 52;
            this.cbx_TipoFuncionario.Text = "Aluno";
            // 
            // dgv_Funcionarios
            // 
            this.dgv_Funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Funcionarios.Location = new System.Drawing.Point(9, 96);
            this.dgv_Funcionarios.Name = "dgv_Funcionarios";
            this.dgv_Funcionarios.Size = new System.Drawing.Size(528, 368);
            this.dgv_Funcionarios.TabIndex = 51;
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
            this.btnExcluirFuncionario.Click += new System.EventHandler(this.BtnExcluirFuncionario_Click);
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
            this.txbConsultarFuncionario.Location = new System.Drawing.Point(6, 58);
            this.txbConsultarFuncionario.MaxLength = 50;
            this.txbConsultarFuncionario.Name = "txbConsultarFuncionario";
            this.txbConsultarFuncionario.Size = new System.Drawing.Size(534, 22);
            this.txbConsultarFuncionario.TabIndex = 47;
            this.txbConsultarFuncionario.Text = "Insira nome do funcionário";
            this.txbConsultarFuncionario.Click += new System.EventHandler(this.txbConsultarFuncionario_Click);
            this.txbConsultarFuncionario.TextChanged += new System.EventHandler(this.TxbConsultarFuncionario_TextChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funcionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConsultaPaciente;
        private System.Windows.Forms.Button btnFecharPesqFunc;
        private System.Windows.Forms.TextBox txbConsultarFuncionario;
        private System.Windows.Forms.Button btnExcluirFuncionario;
        private System.Windows.Forms.Button btnEditarFuncionario;
        private System.Windows.Forms.Button btnIncuirFuncionario;
        private System.Windows.Forms.DataGridView dgv_Funcionarios;
        private System.Windows.Forms.Label lbl_TipoFuncionario;
        private System.Windows.Forms.ComboBox cbx_TipoFuncionario;
    }
}