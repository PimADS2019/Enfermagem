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
            this.grpSobre = new System.Windows.Forms.GroupBox();
            this.lblSobre = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.grpSobre.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSobre
            // 
            this.grpSobre.BackColor = System.Drawing.Color.Beige;
            this.grpSobre.Controls.Add(this.lblVersao);
            this.grpSobre.Controls.Add(this.lblSobre);
            this.grpSobre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSobre.Location = new System.Drawing.Point(4, -1);
            this.grpSobre.Name = "grpSobre";
            this.grpSobre.Size = new System.Drawing.Size(380, 300);
            this.grpSobre.TabIndex = 0;
            this.grpSobre.TabStop = false;
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.Location = new System.Drawing.Point(111, 123);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(144, 16);
            this.lblSobre.TabIndex = 0;
            this.lblSobre.Text = "Texto sobre o programa";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(273, 63);
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
            this.ClientSize = new System.Drawing.Size(386, 301);
            this.Controls.Add(this.grpSobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSobre";
            this.Text = "frmSobre";
            this.grpSobre.ResumeLayout(false);
            this.grpSobre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSobre;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblSobre;
    }
}