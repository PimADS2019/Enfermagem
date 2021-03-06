﻿namespace enfunip.apresentacao
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mnsMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPacientes = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFuncionarios = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAgenda = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEstoque = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAjuda = new System.Windows.Forms.ToolStripDropDownButton();
            this.tmiManual = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLogout = new System.Windows.Forms.Button();
            this.imglogo = new System.Windows.Forms.PictureBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.mnsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imglogo)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.BackColor = System.Drawing.Color.LightGray;
            this.mnsMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnsMenu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.tsmiPacientes,
            this.toolStripSeparator2,
            this.tsmiFuncionarios,
            this.toolStripSeparator7,
            this.tsmiAgenda,
            this.toolStripSeparator3,
            this.tsmiEstoque,
            this.toolStripSeparator4,
            this.tsmiAjuda,
            this.toolStripSeparator1});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(151, 733);
            this.mnsMenu.TabIndex = 8;
            this.mnsMenu.Text = "menu";
            this.mnsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tspMenu_ItemClicked);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(148, 6);
            // 
            // tsmiPacientes
            // 
            this.tsmiPacientes.AutoToolTip = false;
            this.tsmiPacientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiPacientes.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPacientes.Image")));
            this.tsmiPacientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiPacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiPacientes.Name = "tsmiPacientes";
            this.tsmiPacientes.ShowDropDownArrow = false;
            this.tsmiPacientes.Size = new System.Drawing.Size(148, 36);
            this.tsmiPacientes.Text = "Pacientes";
            this.tsmiPacientes.Click += new System.EventHandler(this.tsmiPacientes_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // tsmiFuncionarios
            // 
            this.tsmiFuncionarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFuncionarios.Image")));
            this.tsmiFuncionarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiFuncionarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiFuncionarios.Name = "tsmiFuncionarios";
            this.tsmiFuncionarios.ShowDropDownArrow = false;
            this.tsmiFuncionarios.Size = new System.Drawing.Size(148, 40);
            this.tsmiFuncionarios.Text = "Funcionários";
            this.tsmiFuncionarios.Click += new System.EventHandler(this.tsmiFuncionarios_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(148, 6);
            // 
            // tsmiAgenda
            // 
            this.tsmiAgenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiAgenda.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAgenda.Image")));
            this.tsmiAgenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAgenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiAgenda.Name = "tsmiAgenda";
            this.tsmiAgenda.ShowDropDownArrow = false;
            this.tsmiAgenda.Size = new System.Drawing.Size(148, 36);
            this.tsmiAgenda.Text = "Agenda";
            this.tsmiAgenda.Click += new System.EventHandler(this.tsmiAgenda_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(148, 6);
            // 
            // tsmiEstoque
            // 
            this.tsmiEstoque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiEstoque.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEstoque.Image")));
            this.tsmiEstoque.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEstoque.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiEstoque.Name = "tsmiEstoque";
            this.tsmiEstoque.ShowDropDownArrow = false;
            this.tsmiEstoque.Size = new System.Drawing.Size(148, 36);
            this.tsmiEstoque.Text = "Estoque";
            this.tsmiEstoque.Click += new System.EventHandler(this.tsmiEstoque_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(148, 6);
            // 
            // tsmiAjuda
            // 
            this.tsmiAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiManual,
            this.tmiSobre});
            this.tsmiAjuda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiAjuda.Image = global::enfunip.Properties.Resources._2;
            this.tsmiAjuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAjuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiAjuda.Name = "tsmiAjuda";
            this.tsmiAjuda.Size = new System.Drawing.Size(148, 36);
            this.tsmiAjuda.Text = "Ajuda";
            // 
            // tmiManual
            // 
            this.tmiManual.Name = "tmiManual";
            this.tmiManual.Size = new System.Drawing.Size(133, 24);
            this.tmiManual.Text = "Manual";
            this.tmiManual.Click += new System.EventHandler(this.tmiManual_Click);
            // 
            // tmiSobre
            // 
            this.tmiSobre.Name = "tmiSobre";
            this.tmiSobre.Size = new System.Drawing.Size(133, 24);
            this.tmiSobre.Text = "Sobre";
            this.tmiSobre.Click += new System.EventHandler(this.tmiSobre_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.LightGray;
            this.btnLogout.BackgroundImage = global::enfunip.Properties.Resources.logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogout.Location = new System.Drawing.Point(48, 651);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(48, 66);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnTrocarUsuario_Click);
            // 
            // imglogo
            // 
            this.imglogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imglogo.BackColor = System.Drawing.Color.Transparent;
            this.imglogo.Enabled = false;
            this.imglogo.Image = global::enfunip.Properties.Resources.logounip3;
            this.imglogo.ImageLocation = "";
            this.imglogo.Location = new System.Drawing.Point(515, 298);
            this.imglogo.Name = "imglogo";
            this.imglogo.Size = new System.Drawing.Size(456, 193);
            this.imglogo.TabIndex = 0;
            this.imglogo.TabStop = false;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.LightGray;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnLogout);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.mnsMenu);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(154, 733);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(154, 733);
            this.toolStripContainer1.TabIndex = 21;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 729);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.imglogo);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enfermagem Unip";
            this.Load += new System.EventHandler(this.Mainmenu_Load);
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imglogo)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imglogo;
        private System.Windows.Forms.ToolStrip mnsMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton tsmiAjuda;
        private System.Windows.Forms.ToolStripMenuItem tmiManual;
        private System.Windows.Forms.ToolStripMenuItem tmiSobre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripDropDownButton tsmiFuncionarios;
        private System.Windows.Forms.ToolStripDropDownButton tsmiAgenda;
        private System.Windows.Forms.ToolStripDropDownButton tsmiEstoque;
        private System.Windows.Forms.ToolStripDropDownButton tsmiPacientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}