namespace enfunip.apresentacao
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            this.grpSobre = new System.Windows.Forms.GroupBox();
            this.lblTituSobre = new System.Windows.Forms.Label();
            this.grpBar = new System.Windows.Forms.GroupBox();
            this.grpSobre2 = new System.Windows.Forms.GroupBox();
            this.lblSobre = new System.Windows.Forms.Label();
            this.btnFecharPesqPac = new System.Windows.Forms.Button();
            this.grpCriadores = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.grpSobre.SuspendLayout();
            this.grpSobre2.SuspendLayout();
            this.grpCriadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSobre
            // 
            this.grpSobre.BackColor = System.Drawing.Color.Beige;
            this.grpSobre.Controls.Add(this.lblTituSobre);
            this.grpSobre.Controls.Add(this.grpBar);
            this.grpSobre.Controls.Add(this.grpSobre2);
            this.grpSobre.Controls.Add(this.btnFecharPesqPac);
            this.grpSobre.Controls.Add(this.grpCriadores);
            this.grpSobre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSobre.Location = new System.Drawing.Point(4, 1);
            this.grpSobre.Name = "grpSobre";
            this.grpSobre.Size = new System.Drawing.Size(439, 375);
            this.grpSobre.TabIndex = 0;
            this.grpSobre.TabStop = false;
            this.grpSobre.Enter += new System.EventHandler(this.grpSobre_Enter);
            // 
            // lblTituSobre
            // 
            this.lblTituSobre.AutoSize = true;
            this.lblTituSobre.Font = new System.Drawing.Font("Arial", 18F);
            this.lblTituSobre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTituSobre.Location = new System.Drawing.Point(182, 18);
            this.lblTituSobre.Name = "lblTituSobre";
            this.lblTituSobre.Size = new System.Drawing.Size(76, 27);
            this.lblTituSobre.TabIndex = 139;
            this.lblTituSobre.Text = "Sobre";
            // 
            // grpBar
            // 
            this.grpBar.Location = new System.Drawing.Point(6, 46);
            this.grpBar.Name = "grpBar";
            this.grpBar.Size = new System.Drawing.Size(427, 10);
            this.grpBar.TabIndex = 138;
            this.grpBar.TabStop = false;
            // 
            // grpSobre2
            // 
            this.grpSobre2.BackColor = System.Drawing.Color.White;
            this.grpSobre2.Controls.Add(this.lblSobre);
            this.grpSobre2.Location = new System.Drawing.Point(10, 79);
            this.grpSobre2.Name = "grpSobre2";
            this.grpSobre2.Size = new System.Drawing.Size(422, 130);
            this.grpSobre2.TabIndex = 25;
            this.grpSobre2.TabStop = false;
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.Location = new System.Drawing.Point(24, 18);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(367, 80);
            this.lblSobre.TabIndex = 0;
            this.lblSobre.Text = resources.GetString("lblSobre.Text");
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
            this.btnFecharPesqPac.Location = new System.Drawing.Point(417, 5);
            this.btnFecharPesqPac.Name = "btnFecharPesqPac";
            this.btnFecharPesqPac.Size = new System.Drawing.Size(22, 23);
            this.btnFecharPesqPac.TabIndex = 22;
            this.btnFecharPesqPac.UseVisualStyleBackColor = false;
            this.btnFecharPesqPac.Click += new System.EventHandler(this.BtnFecharPesqPac_Click);
            // 
            // grpCriadores
            // 
            this.grpCriadores.BackColor = System.Drawing.Color.White;
            this.grpCriadores.Controls.Add(this.label1);
            this.grpCriadores.Controls.Add(this.lblVersao);
            this.grpCriadores.Location = new System.Drawing.Point(11, 233);
            this.grpCriadores.Name = "grpCriadores";
            this.grpCriadores.Size = new System.Drawing.Size(422, 131);
            this.grpCriadores.TabIndex = 23;
            this.grpCriadores.TabStop = false;
            this.grpCriadores.Text = "Criado por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = "- Bruno Henrique de Oliveira Machado\r\n- Isac Denis Chuab \r\n- Thiago de Souza Oliv" +
    "eira\r\n- Vinícius Guilherme dos Santos\r\n- Wellington Félix da Cruz \r\n";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(346, 112);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(70, 16);
            this.lblVersao.TabIndex = 1;
            this.lblVersao.Text = "Versão 1.0";
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(448, 383);
            this.Controls.Add(this.grpSobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSobre";
            this.grpSobre.ResumeLayout(false);
            this.grpSobre.PerformLayout();
            this.grpSobre2.ResumeLayout(false);
            this.grpSobre2.PerformLayout();
            this.grpCriadores.ResumeLayout(false);
            this.grpCriadores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSobre;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFecharPesqPac;
        private System.Windows.Forms.GroupBox grpSobre2;
        private System.Windows.Forms.GroupBox grpCriadores;
        private System.Windows.Forms.Label lblTituSobre;
        private System.Windows.Forms.GroupBox grpBar;
    }
}