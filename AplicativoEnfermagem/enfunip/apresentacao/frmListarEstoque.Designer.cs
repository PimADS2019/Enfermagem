﻿namespace enfunip.apresentacao
{
    partial class frmListarEstoque
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
            this.txbConsultarProdutos = new System.Windows.Forms.TextBox();
            this.btnPesqPac = new System.Windows.Forms.Button();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.grpConsultaPaciente = new System.Windows.Forms.GroupBox();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnIncuirProduto = new System.Windows.Forms.Button();
            this.btnFecharPesqPac = new System.Windows.Forms.Button();
            this.grpConsultaPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbConsultarProdutos
            // 
            this.txbConsultarProdutos.ForeColor = System.Drawing.Color.Silver;
            this.txbConsultarProdutos.Location = new System.Drawing.Point(6, 39);
            this.txbConsultarProdutos.MaxLength = 50;
            this.txbConsultarProdutos.Name = "txbConsultarProdutos";
            this.txbConsultarProdutos.Size = new System.Drawing.Size(514, 22);
            this.txbConsultarProdutos.TabIndex = 44;
            this.txbConsultarProdutos.Text = "Insira nome do produto";
            // 
            // btnPesqPac
            // 
            this.btnPesqPac.BackgroundImage = global::enfunip.Properties.Resources.icons8_pesquisar_26;
            this.btnPesqPac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesqPac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqPac.Location = new System.Drawing.Point(519, 39);
            this.btnPesqPac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesqPac.Name = "btnPesqPac";
            this.btnPesqPac.Size = new System.Drawing.Size(22, 22);
            this.btnPesqPac.TabIndex = 43;
            this.btnPesqPac.Text = "...";
            this.btnPesqPac.UseVisualStyleBackColor = true;
            this.btnPesqPac.Click += new System.EventHandler(this.btnPesqPac_Click);
            // 
            // lstProdutos
            // 
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.ItemHeight = 16;
            this.lstProdutos.Location = new System.Drawing.Point(6, 74);
            this.lstProdutos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(534, 388);
            this.lstProdutos.TabIndex = 1;
            // 
            // grpConsultaPaciente
            // 
            this.grpConsultaPaciente.BackColor = System.Drawing.Color.Beige;
            this.grpConsultaPaciente.Controls.Add(this.btnExcluirProduto);
            this.grpConsultaPaciente.Controls.Add(this.btnEditarProduto);
            this.grpConsultaPaciente.Controls.Add(this.btnIncuirProduto);
            this.grpConsultaPaciente.Controls.Add(this.txbConsultarProdutos);
            this.grpConsultaPaciente.Controls.Add(this.btnFecharPesqPac);
            this.grpConsultaPaciente.Controls.Add(this.btnPesqPac);
            this.grpConsultaPaciente.Controls.Add(this.lstProdutos);
            this.grpConsultaPaciente.Location = new System.Drawing.Point(3, -4);
            this.grpConsultaPaciente.Name = "grpConsultaPaciente";
            this.grpConsultaPaciente.Size = new System.Drawing.Size(550, 495);
            this.grpConsultaPaciente.TabIndex = 47;
            this.grpConsultaPaciente.TabStop = false;
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirProduto.Location = new System.Drawing.Point(175, 470);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirProduto.TabIndex = 53;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProduto.Location = new System.Drawing.Point(90, 470);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnEditarProduto.TabIndex = 52;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            // 
            // btnIncuirProduto
            // 
            this.btnIncuirProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncuirProduto.Location = new System.Drawing.Point(6, 470);
            this.btnIncuirProduto.Name = "btnIncuirProduto";
            this.btnIncuirProduto.Size = new System.Drawing.Size(75, 23);
            this.btnIncuirProduto.TabIndex = 51;
            this.btnIncuirProduto.Text = "Incluir";
            this.btnIncuirProduto.UseVisualStyleBackColor = true;
            this.btnIncuirProduto.Click += new System.EventHandler(this.btnIncuirProduto_Click);
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
            this.btnFecharPesqPac.Location = new System.Drawing.Point(528, 9);
            this.btnFecharPesqPac.Name = "btnFecharPesqPac";
            this.btnFecharPesqPac.Size = new System.Drawing.Size(22, 23);
            this.btnFecharPesqPac.TabIndex = 21;
            this.btnFecharPesqPac.UseVisualStyleBackColor = false;
            this.btnFecharPesqPac.Click += new System.EventHandler(this.btnFecharPesqPac_Click);
            // 
            // frmListarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(556, 492);
            this.Controls.Add(this.grpConsultaPaciente);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmListarEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmListarEstoque";
            this.grpConsultaPaciente.ResumeLayout(false);
            this.grpConsultaPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbConsultarProdutos;
        private System.Windows.Forms.Button btnPesqPac;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.GroupBox grpConsultaPaciente;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnIncuirProduto;
        private System.Windows.Forms.Button btnFecharPesqPac;
    }
}