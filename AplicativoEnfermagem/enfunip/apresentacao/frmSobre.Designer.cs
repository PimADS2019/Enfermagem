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
            this.btnFecharPesqPac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblSobre = new System.Windows.Forms.Label();
            this.grpCriadores = new System.Windows.Forms.GroupBox();
            this.grpSobre2 = new System.Windows.Forms.GroupBox();
            this.grpSobre.SuspendLayout();
            this.grpCriadores.SuspendLayout();
            this.grpSobre2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSobre
            // 
            this.grpSobre.BackColor = System.Drawing.Color.Beige;
            this.grpSobre.Controls.Add(this.grpSobre2);
            this.grpSobre.Controls.Add(this.btnFecharPesqPac);
            this.grpSobre.Controls.Add(this.grpCriadores);
            this.grpSobre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSobre.Location = new System.Drawing.Point(4, -1);
            this.grpSobre.Name = "grpSobre";
            this.grpSobre.Size = new System.Drawing.Size(439, 335);
            this.grpSobre.TabIndex = 0;
            this.grpSobre.TabStop = false;
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
            this.btnFecharPesqPac.Location = new System.Drawing.Point(415, 6);
            this.btnFecharPesqPac.Name = "btnFecharPesqPac";
            this.btnFecharPesqPac.Size = new System.Drawing.Size(22, 23);
            this.btnFecharPesqPac.TabIndex = 22;
            this.btnFecharPesqPac.UseVisualStyleBackColor = false;
            this.btnFecharPesqPac.Click += new System.EventHandler(this.BtnFecharPesqPac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = "- Alisson Sena Feitosa\r\n- Isac Denis Chuab \r\n- Thiago de Souza Oliveira\r\n- Viníci" +
    "us Guilherme dos Santos\r\n- Wellington Félix da Cruz \r\n";
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
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.Location = new System.Drawing.Point(24, 18);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(367, 80);
            this.lblSobre.TabIndex = 0;
            this.lblSobre.Text = resources.GetString("lblSobre.Text");
            // 
            // grpCriadores
            // 
            this.grpCriadores.BackColor = System.Drawing.Color.White;
            this.grpCriadores.Controls.Add(this.label1);
            this.grpCriadores.Controls.Add(this.lblVersao);
            this.grpCriadores.Location = new System.Drawing.Point(11, 193);
            this.grpCriadores.Name = "grpCriadores";
            this.grpCriadores.Size = new System.Drawing.Size(422, 131);
            this.grpCriadores.TabIndex = 23;
            this.grpCriadores.TabStop = false;
            this.grpCriadores.Text = "Criado por:";
            // 
            // grpSobre2
            // 
            this.grpSobre2.BackColor = System.Drawing.Color.White;
            this.grpSobre2.Controls.Add(this.lblSobre);
            this.grpSobre2.Location = new System.Drawing.Point(10, 39);
            this.grpSobre2.Name = "grpSobre2";
            this.grpSobre2.Size = new System.Drawing.Size(422, 130);
            this.grpSobre2.TabIndex = 25;
            this.grpSobre2.TabStop = false;
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(448, 337);
            this.Controls.Add(this.grpSobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSobre";
            this.grpSobre.ResumeLayout(false);
            this.grpCriadores.ResumeLayout(false);
            this.grpCriadores.PerformLayout();
            this.grpSobre2.ResumeLayout(false);
            this.grpSobre2.PerformLayout();
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
    }
}