﻿namespace enfunip.apresentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarFuncionario));
            this.grpConsultaPaciente = new System.Windows.Forms.GroupBox();
            this.btnFecharPesqPac = new System.Windows.Forms.Button();
            this.lblConsFunc = new System.Windows.Forms.Label();
            this.grpBar = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lbl_TipoFuncionario = new System.Windows.Forms.Label();
            this.cboTipoFuncionario = new System.Windows.Forms.ComboBox();
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
            this.grpConsultaPaciente.Controls.Add(this.btnFecharPesqPac);
            this.grpConsultaPaciente.Controls.Add(this.lblConsFunc);
            this.grpConsultaPaciente.Controls.Add(this.grpBar);
            this.grpConsultaPaciente.Controls.Add(this.btnAtualizar);
            this.grpConsultaPaciente.Controls.Add(this.lbl_TipoFuncionario);
            this.grpConsultaPaciente.Controls.Add(this.cboTipoFuncionario);
            this.grpConsultaPaciente.Controls.Add(this.dgv_Funcionarios);
            this.grpConsultaPaciente.Controls.Add(this.btnExcluirFuncionario);
            this.grpConsultaPaciente.Controls.Add(this.btnEditarFuncionario);
            this.grpConsultaPaciente.Controls.Add(this.btnIncuirFuncionario);
            this.grpConsultaPaciente.Controls.Add(this.txbConsultarFuncionario);
            this.grpConsultaPaciente.Controls.Add(this.btnFecharPesqFunc);
            this.grpConsultaPaciente.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpConsultaPaciente.Location = new System.Drawing.Point(4, 5);
            this.grpConsultaPaciente.Name = "grpConsultaPaciente";
            this.grpConsultaPaciente.Size = new System.Drawing.Size(1285, 590);
            this.grpConsultaPaciente.TabIndex = 47;
            this.grpConsultaPaciente.TabStop = false;
            this.grpConsultaPaciente.Enter += new System.EventHandler(this.GrpConsultaPaciente_Enter);
            // 
            // btnFecharPesqPac
            // 
            this.btnFecharPesqPac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnFecharPesqPac.TabIndex = 136;
            this.btnFecharPesqPac.UseVisualStyleBackColor = false;
            this.btnFecharPesqPac.Click += new System.EventHandler(this.BtnFecharPesqPac_Click);
            // 
            // lblConsFunc
            // 
            this.lblConsFunc.AutoSize = true;
            this.lblConsFunc.Font = new System.Drawing.Font("Arial", 18F);
            this.lblConsFunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConsFunc.Location = new System.Drawing.Point(515, 18);
            this.lblConsFunc.Name = "lblConsFunc";
            this.lblConsFunc.Size = new System.Drawing.Size(275, 27);
            this.lblConsFunc.TabIndex = 135;
            this.lblConsFunc.Text = "Consulta de Funcionário";
            // 
            // grpBar
            // 
            this.grpBar.Location = new System.Drawing.Point(7, 48);
            this.grpBar.Name = "grpBar";
            this.grpBar.Size = new System.Drawing.Size(1268, 10);
            this.grpBar.TabIndex = 134;
            this.grpBar.TabStop = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(545, 77);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(24, 24);
            this.btnAtualizar.TabIndex = 57;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lbl_TipoFuncionario
            // 
            this.lbl_TipoFuncionario.AutoSize = true;
            this.lbl_TipoFuncionario.Location = new System.Drawing.Point(579, 81);
            this.lbl_TipoFuncionario.Name = "lbl_TipoFuncionario";
            this.lbl_TipoFuncionario.Size = new System.Drawing.Size(103, 16);
            this.lbl_TipoFuncionario.TabIndex = 53;
            this.lbl_TipoFuncionario.Text = "Tipo Funcionario";
            // 
            // cboTipoFuncionario
            // 
            this.cboTipoFuncionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTipoFuncionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoFuncionario.FormattingEnabled = true;
            this.cboTipoFuncionario.Items.AddRange(new object[] {
            "Aluno",
            "Coordenador",
            "Professor",
            "Enfermeiro"});
            this.cboTipoFuncionario.Location = new System.Drawing.Point(688, 78);
            this.cboTipoFuncionario.Name = "cboTipoFuncionario";
            this.cboTipoFuncionario.Size = new System.Drawing.Size(121, 24);
            this.cboTipoFuncionario.TabIndex = 52;
            this.cboTipoFuncionario.Text = "Aluno";
            this.cboTipoFuncionario.SelectedIndexChanged += new System.EventHandler(this.CboTipoFuncionario_SelectedIndexChanged);
            this.cboTipoFuncionario.Enter += new System.EventHandler(this.cboTipoFuncionario_Enter);
            // 
            // dgv_Funcionarios
            // 
            this.dgv_Funcionarios.AllowUserToAddRows = false;
            this.dgv_Funcionarios.AllowUserToDeleteRows = false;
            this.dgv_Funcionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Funcionarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Funcionarios.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Funcionarios.Location = new System.Drawing.Point(11, 117);
            this.dgv_Funcionarios.Name = "dgv_Funcionarios";
            this.dgv_Funcionarios.ReadOnly = true;
            this.dgv_Funcionarios.Size = new System.Drawing.Size(1251, 428);
            this.dgv_Funcionarios.TabIndex = 51;
            this.dgv_Funcionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Funcionarios_CellContentClick);
            // 
            // btnExcluirFuncionario
            // 
            this.btnExcluirFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirFuncionario.Location = new System.Drawing.Point(173, 561);
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
            this.btnEditarFuncionario.Location = new System.Drawing.Point(89, 561);
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnEditarFuncionario.TabIndex = 49;
            this.btnEditarFuncionario.Text = "Editar";
            this.btnEditarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnIncuirFuncionario
            // 
            this.btnIncuirFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncuirFuncionario.Location = new System.Drawing.Point(5, 561);
            this.btnIncuirFuncionario.Name = "btnIncuirFuncionario";
            this.btnIncuirFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnIncuirFuncionario.TabIndex = 48;
            this.btnIncuirFuncionario.Text = "Cadastrar";
            this.btnIncuirFuncionario.UseVisualStyleBackColor = true;
            this.btnIncuirFuncionario.Click += new System.EventHandler(this.btnIncuirFuncionario_Click);
            // 
            // txbConsultarFuncionario
            // 
            this.txbConsultarFuncionario.ForeColor = System.Drawing.Color.Silver;
            this.txbConsultarFuncionario.Location = new System.Drawing.Point(11, 78);
            this.txbConsultarFuncionario.MaxLength = 50;
            this.txbConsultarFuncionario.Name = "txbConsultarFuncionario";
            this.txbConsultarFuncionario.Size = new System.Drawing.Size(534, 22);
            this.txbConsultarFuncionario.TabIndex = 47;
            this.txbConsultarFuncionario.Text = "Insira nome do funcionário";
            this.txbConsultarFuncionario.Click += new System.EventHandler(this.TxbConsultarFuncionario_Click);
            this.txbConsultarFuncionario.TextChanged += new System.EventHandler(this.TxbConsultarFuncionario_TextChanged);
            this.txbConsultarFuncionario.Enter += new System.EventHandler(this.txbConsultarFuncionario_Enter);
            // 
            // btnFecharPesqFunc
            // 
            this.btnFecharPesqFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFecharPesqFunc.BackColor = System.Drawing.Color.Transparent;
            this.btnFecharPesqFunc.BackgroundImage = global::enfunip.Properties.Resources.excluir;
            this.btnFecharPesqFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFecharPesqFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharPesqFunc.FlatAppearance.BorderSize = 0;
            this.btnFecharPesqFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharPesqFunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFecharPesqFunc.Location = new System.Drawing.Point(672, -87);
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
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.Controls.Add(this.grpConsultaPaciente);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmConsultarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmConsultarFuncionario";
            this.Load += new System.EventHandler(this.frmConsultarFuncionario_Load);
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
        private System.Windows.Forms.ComboBox cboTipoFuncionario;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblConsFunc;
        private System.Windows.Forms.GroupBox grpBar;
        private System.Windows.Forms.Button btnFecharPesqPac;
    }
}