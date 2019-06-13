namespace enfunip.apresentacao
{
    partial class frmCadastrarProduto
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
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.dtpEntradaProduto = new System.Windows.Forms.DateTimePicker();
            this.lblDataEntradaProduto = new System.Windows.Forms.Label();
            this.mnsFunçõesCadastroPac = new System.Windows.Forms.MenuStrip();
            this.tsmiSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLimpar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCadastrarProduto = new System.Windows.Forms.GroupBox();
            this.lblCadProduto = new System.Windows.Forms.Label();
            this.grpBar = new System.Windows.Forms.GroupBox();
            this.lbl_idProduto = new System.Windows.Forms.Label();
            this.idProduto_BD = new System.Windows.Forms.ListBox();
            this.lblObservaçãoProduto = new System.Windows.Forms.Label();
            this.lblQuantidadeProduto = new System.Windows.Forms.Label();
            this.nudQtdProduto = new System.Windows.Forms.NumericUpDown();
            this.txbObsProduto = new System.Windows.Forms.TextBox();
            this.mnsFunçõesCadastroPac.SuspendLayout();
            this.grpCadastrarProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // txbProduto
            // 
            this.txbProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProduto.Location = new System.Drawing.Point(21, 172);
            this.txbProduto.MaxLength = 50;
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(446, 22);
            this.txbProduto.TabIndex = 0;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.BackColor = System.Drawing.Color.Beige;
            this.lblProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(17, 151);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(53, 16);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto";
            // 
            // dtpEntradaProduto
            // 
            this.dtpEntradaProduto.CustomFormat = "";
            this.dtpEntradaProduto.Enabled = false;
            this.dtpEntradaProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntradaProduto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntradaProduto.Location = new System.Drawing.Point(519, 85);
            this.dtpEntradaProduto.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpEntradaProduto.Name = "dtpEntradaProduto";
            this.dtpEntradaProduto.Size = new System.Drawing.Size(123, 22);
            this.dtpEntradaProduto.TabIndex = 3;
            this.dtpEntradaProduto.UseWaitCursor = true;
            // 
            // lblDataEntradaProduto
            // 
            this.lblDataEntradaProduto.AutoSize = true;
            this.lblDataEntradaProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntradaProduto.Location = new System.Drawing.Point(515, 64);
            this.lblDataEntradaProduto.Name = "lblDataEntradaProduto";
            this.lblDataEntradaProduto.Size = new System.Drawing.Size(110, 16);
            this.lblDataEntradaProduto.TabIndex = 4;
            this.lblDataEntradaProduto.Text = "Data de entrada";
            // 
            // mnsFunçõesCadastroPac
            // 
            this.mnsFunçõesCadastroPac.BackColor = System.Drawing.Color.LightGray;
            this.mnsFunçõesCadastroPac.Font = new System.Drawing.Font("Arial", 9F);
            this.mnsFunçõesCadastroPac.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSalvar,
            this.tsmiLimpar,
            this.tsmiCancelar});
            this.mnsFunçõesCadastroPac.Location = new System.Drawing.Point(0, 0);
            this.mnsFunçõesCadastroPac.Name = "mnsFunçõesCadastroPac";
            this.mnsFunçõesCadastroPac.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnsFunçõesCadastroPac.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnsFunçõesCadastroPac.Size = new System.Drawing.Size(677, 24);
            this.mnsFunçõesCadastroPac.TabIndex = 51;
            // 
            // tsmiSalvar
            // 
            this.tsmiSalvar.Image = global::enfunip.Properties.Resources.savedisk_floppydisk_guardar_1543;
            this.tsmiSalvar.Name = "tsmiSalvar";
            this.tsmiSalvar.Size = new System.Drawing.Size(69, 20);
            this.tsmiSalvar.Text = "Salvar";
            this.tsmiSalvar.Click += new System.EventHandler(this.tsmiSalvar_Click);
            // 
            // tsmiLimpar
            // 
            this.tsmiLimpar.Image = global::enfunip.Properties.Resources.reply_all_button_icon_icons_com_72603;
            this.tsmiLimpar.Name = "tsmiLimpar";
            this.tsmiLimpar.Size = new System.Drawing.Size(74, 20);
            this.tsmiLimpar.Text = "Limpar";
            this.tsmiLimpar.Click += new System.EventHandler(this.tsmiLimpar_Click);
            // 
            // tsmiCancelar
            // 
            this.tsmiCancelar.Image = global::enfunip.Properties.Resources.excluir;
            this.tsmiCancelar.Name = "tsmiCancelar";
            this.tsmiCancelar.Size = new System.Drawing.Size(85, 20);
            this.tsmiCancelar.Text = "Cancelar";
            this.tsmiCancelar.Click += new System.EventHandler(this.tsmiCancelar_Click);
            // 
            // grpCadastrarProduto
            // 
            this.grpCadastrarProduto.BackColor = System.Drawing.Color.Beige;
            this.grpCadastrarProduto.Controls.Add(this.lblCadProduto);
            this.grpCadastrarProduto.Controls.Add(this.grpBar);
            this.grpCadastrarProduto.Controls.Add(this.lbl_idProduto);
            this.grpCadastrarProduto.Controls.Add(this.idProduto_BD);
            this.grpCadastrarProduto.Controls.Add(this.lblObservaçãoProduto);
            this.grpCadastrarProduto.Controls.Add(this.lblProduto);
            this.grpCadastrarProduto.Controls.Add(this.lblQuantidadeProduto);
            this.grpCadastrarProduto.Controls.Add(this.txbProduto);
            this.grpCadastrarProduto.Controls.Add(this.nudQtdProduto);
            this.grpCadastrarProduto.Controls.Add(this.txbObsProduto);
            this.grpCadastrarProduto.Controls.Add(this.lblDataEntradaProduto);
            this.grpCadastrarProduto.Controls.Add(this.dtpEntradaProduto);
            this.grpCadastrarProduto.Location = new System.Drawing.Point(8, 28);
            this.grpCadastrarProduto.Name = "grpCadastrarProduto";
            this.grpCadastrarProduto.Size = new System.Drawing.Size(660, 444);
            this.grpCadastrarProduto.TabIndex = 52;
            this.grpCadastrarProduto.TabStop = false;
            this.grpCadastrarProduto.Enter += new System.EventHandler(this.grpCadastrarProduto_Enter);
            // 
            // lblCadProduto
            // 
            this.lblCadProduto.AutoSize = true;
            this.lblCadProduto.Font = new System.Drawing.Font("Arial", 18F);
            this.lblCadProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCadProduto.Location = new System.Drawing.Point(209, 14);
            this.lblCadProduto.Name = "lblCadProduto";
            this.lblCadProduto.Size = new System.Drawing.Size(235, 27);
            this.lblCadProduto.TabIndex = 131;
            this.lblCadProduto.Text = "Cadastro de Produto";
            // 
            // grpBar
            // 
            this.grpBar.Location = new System.Drawing.Point(6, 44);
            this.grpBar.Name = "grpBar";
            this.grpBar.Size = new System.Drawing.Size(646, 10);
            this.grpBar.TabIndex = 130;
            this.grpBar.TabStop = false;
            // 
            // lbl_idProduto
            // 
            this.lbl_idProduto.AutoSize = true;
            this.lbl_idProduto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_idProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_idProduto.Location = new System.Drawing.Point(10, 63);
            this.lbl_idProduto.Name = "lbl_idProduto";
            this.lbl_idProduto.Size = new System.Drawing.Size(28, 23);
            this.lbl_idProduto.TabIndex = 63;
            this.lbl_idProduto.Text = "ID";
            // 
            // idProduto_BD
            // 
            this.idProduto_BD.Font = new System.Drawing.Font("Arial", 8.25F);
            this.idProduto_BD.ForeColor = System.Drawing.Color.DarkGray;
            this.idProduto_BD.FormattingEnabled = true;
            this.idProduto_BD.ItemHeight = 14;
            this.idProduto_BD.Location = new System.Drawing.Point(45, 66);
            this.idProduto_BD.Name = "idProduto_BD";
            this.idProduto_BD.Size = new System.Drawing.Size(79, 18);
            this.idProduto_BD.TabIndex = 64;
            // 
            // lblObservaçãoProduto
            // 
            this.lblObservaçãoProduto.AutoSize = true;
            this.lblObservaçãoProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaçãoProduto.Location = new System.Drawing.Point(17, 227);
            this.lblObservaçãoProduto.Name = "lblObservaçãoProduto";
            this.lblObservaçãoProduto.Size = new System.Drawing.Size(76, 16);
            this.lblObservaçãoProduto.TabIndex = 62;
            this.lblObservaçãoProduto.Text = "Observação";
            // 
            // lblQuantidadeProduto
            // 
            this.lblQuantidadeProduto.AutoSize = true;
            this.lblQuantidadeProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeProduto.Location = new System.Drawing.Point(499, 151);
            this.lblQuantidadeProduto.Name = "lblQuantidadeProduto";
            this.lblQuantidadeProduto.Size = new System.Drawing.Size(74, 16);
            this.lblQuantidadeProduto.TabIndex = 61;
            this.lblQuantidadeProduto.Text = "Quantidade";
            // 
            // nudQtdProduto
            // 
            this.nudQtdProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtdProduto.Location = new System.Drawing.Point(502, 172);
            this.nudQtdProduto.Name = "nudQtdProduto";
            this.nudQtdProduto.Size = new System.Drawing.Size(140, 22);
            this.nudQtdProduto.TabIndex = 58;
            // 
            // txbObsProduto
            // 
            this.txbObsProduto.Location = new System.Drawing.Point(21, 249);
            this.txbObsProduto.MaxLength = 300;
            this.txbObsProduto.Multiline = true;
            this.txbObsProduto.Name = "txbObsProduto";
            this.txbObsProduto.Size = new System.Drawing.Size(621, 180);
            this.txbObsProduto.TabIndex = 59;
            // 
            // frmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(677, 480);
            this.Controls.Add(this.mnsFunçõesCadastroPac);
            this.Controls.Add(this.grpCadastrarProduto);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmCadastrarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Produto";
            this.mnsFunçõesCadastroPac.ResumeLayout(false);
            this.mnsFunçõesCadastroPac.PerformLayout();
            this.grpCadastrarProduto.ResumeLayout(false);
            this.grpCadastrarProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.DateTimePicker dtpEntradaProduto;
        private System.Windows.Forms.Label lblDataEntradaProduto;
        private System.Windows.Forms.MenuStrip mnsFunçõesCadastroPac;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalvar;
        private System.Windows.Forms.ToolStripMenuItem tsmiLimpar;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelar;
        private System.Windows.Forms.GroupBox grpCadastrarProduto;
        private System.Windows.Forms.TextBox txbObsProduto;
        private System.Windows.Forms.Label lblQuantidadeProduto;
        private System.Windows.Forms.NumericUpDown nudQtdProduto;
        private System.Windows.Forms.Label lblObservaçãoProduto;
        private System.Windows.Forms.Label lbl_idProduto;
        private System.Windows.Forms.ListBox idProduto_BD;
        private System.Windows.Forms.Label lblCadProduto;
        private System.Windows.Forms.GroupBox grpBar;
    }
}