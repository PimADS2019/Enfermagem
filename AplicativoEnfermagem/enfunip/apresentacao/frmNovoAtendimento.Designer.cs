namespace enfunip.apresentacao
{
    partial class frmNovoAtendimento
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
            this.grpAtendimento = new System.Windows.Forms.GroupBox();
            this.btnPesqPac = new System.Windows.Forms.Button();
            this.lblObsAtendimento = new System.Windows.Forms.Label();
            this.txbObsAtendimento = new System.Windows.Forms.TextBox();
            this.lblDataAtendimento = new System.Windows.Forms.Label();
            this.dtpAtendimento = new System.Windows.Forms.DateTimePicker();
            this.lblPacienteAtendimento = new System.Windows.Forms.Label();
            this.txbPacienteAtendimento = new System.Windows.Forms.TextBox();
            this.mnsFunçõesCadastroPac = new System.Windows.Forms.MenuStrip();
            this.tsmiSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLimpar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAtendimento.SuspendLayout();
            this.mnsFunçõesCadastroPac.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAtendimento
            // 
            this.grpAtendimento.BackColor = System.Drawing.Color.Beige;
            this.grpAtendimento.Controls.Add(this.btnPesqPac);
            this.grpAtendimento.Controls.Add(this.lblObsAtendimento);
            this.grpAtendimento.Controls.Add(this.txbObsAtendimento);
            this.grpAtendimento.Controls.Add(this.lblDataAtendimento);
            this.grpAtendimento.Controls.Add(this.dtpAtendimento);
            this.grpAtendimento.Controls.Add(this.lblPacienteAtendimento);
            this.grpAtendimento.Controls.Add(this.txbPacienteAtendimento);
            this.grpAtendimento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAtendimento.Location = new System.Drawing.Point(3, 20);
            this.grpAtendimento.Name = "grpAtendimento";
            this.grpAtendimento.Size = new System.Drawing.Size(504, 418);
            this.grpAtendimento.TabIndex = 0;
            this.grpAtendimento.TabStop = false;
            // 
            // btnPesqPac
            // 
            this.btnPesqPac.BackgroundImage = global::enfunip.Properties.Resources.icons8_pesquisar_26;
            this.btnPesqPac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesqPac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqPac.Location = new System.Drawing.Point(465, 40);
            this.btnPesqPac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesqPac.Name = "btnPesqPac";
            this.btnPesqPac.Size = new System.Drawing.Size(22, 22);
            this.btnPesqPac.TabIndex = 44;
            this.btnPesqPac.Text = "...";
            this.btnPesqPac.UseVisualStyleBackColor = true;
            this.btnPesqPac.Click += new System.EventHandler(this.btnPesqPac_Click);
            // 
            // lblObsAtendimento
            // 
            this.lblObsAtendimento.AutoSize = true;
            this.lblObsAtendimento.Location = new System.Drawing.Point(13, 140);
            this.lblObsAtendimento.Name = "lblObsAtendimento";
            this.lblObsAtendimento.Size = new System.Drawing.Size(76, 16);
            this.lblObsAtendimento.TabIndex = 6;
            this.lblObsAtendimento.Text = "Observação";
            // 
            // txbObsAtendimento
            // 
            this.txbObsAtendimento.Location = new System.Drawing.Point(16, 159);
            this.txbObsAtendimento.MaxLength = 300;
            this.txbObsAtendimento.Multiline = true;
            this.txbObsAtendimento.Name = "txbObsAtendimento";
            this.txbObsAtendimento.Size = new System.Drawing.Size(471, 239);
            this.txbObsAtendimento.TabIndex = 5;
            // 
            // lblDataAtendimento
            // 
            this.lblDataAtendimento.AutoSize = true;
            this.lblDataAtendimento.Location = new System.Drawing.Point(13, 79);
            this.lblDataAtendimento.Name = "lblDataAtendimento";
            this.lblDataAtendimento.Size = new System.Drawing.Size(128, 16);
            this.lblDataAtendimento.TabIndex = 4;
            this.lblDataAtendimento.Text = "Data do atendimento";
            // 
            // dtpAtendimento
            // 
            this.dtpAtendimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpAtendimento.CustomFormat = "";
            this.dtpAtendimento.Location = new System.Drawing.Point(16, 98);
            this.dtpAtendimento.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpAtendimento.Name = "dtpAtendimento";
            this.dtpAtendimento.Size = new System.Drawing.Size(273, 22);
            this.dtpAtendimento.TabIndex = 3;
            // 
            // lblPacienteAtendimento
            // 
            this.lblPacienteAtendimento.AutoSize = true;
            this.lblPacienteAtendimento.Location = new System.Drawing.Point(13, 21);
            this.lblPacienteAtendimento.Name = "lblPacienteAtendimento";
            this.lblPacienteAtendimento.Size = new System.Drawing.Size(59, 16);
            this.lblPacienteAtendimento.TabIndex = 1;
            this.lblPacienteAtendimento.Text = "Paciente";
            // 
            // txbPacienteAtendimento
            // 
            this.txbPacienteAtendimento.Location = new System.Drawing.Point(16, 40);
            this.txbPacienteAtendimento.MaxLength = 50;
            this.txbPacienteAtendimento.Name = "txbPacienteAtendimento";
            this.txbPacienteAtendimento.Size = new System.Drawing.Size(449, 22);
            this.txbPacienteAtendimento.TabIndex = 0;
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
            this.mnsFunçõesCadastroPac.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnsFunçõesCadastroPac.Size = new System.Drawing.Size(513, 24);
            this.mnsFunçõesCadastroPac.TabIndex = 51;
            // 
            // tsmiSalvar
            // 
            this.tsmiSalvar.Image = global::enfunip.Properties.Resources.savedisk_floppydisk_guardar_1543;
            this.tsmiSalvar.Name = "tsmiSalvar";
            this.tsmiSalvar.Size = new System.Drawing.Size(69, 20);
            this.tsmiSalvar.Text = "Salvar";
            // 
            // tsmiLimpar
            // 
            this.tsmiLimpar.Image = global::enfunip.Properties.Resources.reply_all_button_icon_icons_com_72603;
            this.tsmiLimpar.Name = "tsmiLimpar";
            this.tsmiLimpar.Size = new System.Drawing.Size(74, 20);
            this.tsmiLimpar.Text = "Limpar";
            // 
            // tsmiCancelar
            // 
            this.tsmiCancelar.Image = global::enfunip.Properties.Resources.excluir;
            this.tsmiCancelar.Name = "tsmiCancelar";
            this.tsmiCancelar.Size = new System.Drawing.Size(85, 20);
            this.tsmiCancelar.Text = "Cancelar";
            this.tsmiCancelar.Click += new System.EventHandler(this.tsmiCancelar_Click);
            // 
            // frmNovoAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(513, 439);
            this.Controls.Add(this.mnsFunçõesCadastroPac);
            this.Controls.Add(this.grpAtendimento);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNovoAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmNovoAtendimento";
            this.grpAtendimento.ResumeLayout(false);
            this.grpAtendimento.PerformLayout();
            this.mnsFunçõesCadastroPac.ResumeLayout(false);
            this.mnsFunçõesCadastroPac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAtendimento;
        private System.Windows.Forms.Label lblPacienteAtendimento;
        private System.Windows.Forms.TextBox txbPacienteAtendimento;
        private System.Windows.Forms.Label lblObsAtendimento;
        private System.Windows.Forms.TextBox txbObsAtendimento;
        private System.Windows.Forms.Label lblDataAtendimento;
        private System.Windows.Forms.DateTimePicker dtpAtendimento;
        private System.Windows.Forms.MenuStrip mnsFunçõesCadastroPac;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalvar;
        private System.Windows.Forms.ToolStripMenuItem tsmiLimpar;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelar;
        private System.Windows.Forms.Button btnPesqPac;
    }
}