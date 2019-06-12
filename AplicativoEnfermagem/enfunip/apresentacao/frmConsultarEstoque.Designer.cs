namespace enfunip.apresentacao
{
    partial class frmConsultarEstoque
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarEstoque));
            this.txbConsultarProdutos = new System.Windows.Forms.TextBox();
            this.grpConsultaPaciente = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dgv_ListaProdutos = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHrCadastroProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoquesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pimEnfermagem2019DataSet1 = new enfunip.PimEnfermagem2019DataSet1();
            this.btnFecharPesqPac = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.estoquesTableAdapter = new enfunip.PimEnfermagem2019DataSet1TableAdapters.EstoquesTableAdapter();
            this.lblConsProd = new System.Windows.Forms.Label();
            this.grpBar = new System.Windows.Forms.GroupBox();
            this.grpConsultaPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoquesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pimEnfermagem2019DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbConsultarProdutos
            // 
            this.txbConsultarProdutos.ForeColor = System.Drawing.Color.Silver;
            this.txbConsultarProdutos.Location = new System.Drawing.Point(9, 70);
            this.txbConsultarProdutos.MaxLength = 50;
            this.txbConsultarProdutos.Name = "txbConsultarProdutos";
            this.txbConsultarProdutos.Size = new System.Drawing.Size(443, 22);
            this.txbConsultarProdutos.TabIndex = 44;
            this.txbConsultarProdutos.Text = "Insira nome do produto";
            this.txbConsultarProdutos.TextChanged += new System.EventHandler(this.TxbConsultarProdutos_TextChanged);
            // 
            // grpConsultaPaciente
            // 
            this.grpConsultaPaciente.BackColor = System.Drawing.Color.Beige;
            this.grpConsultaPaciente.Controls.Add(this.lblConsProd);
            this.grpConsultaPaciente.Controls.Add(this.grpBar);
            this.grpConsultaPaciente.Controls.Add(this.btnAtualizar);
            this.grpConsultaPaciente.Controls.Add(this.dgv_ListaProdutos);
            this.grpConsultaPaciente.Controls.Add(this.btnFecharPesqPac);
            this.grpConsultaPaciente.Controls.Add(this.btnExcluirProduto);
            this.grpConsultaPaciente.Controls.Add(this.btnEditarProduto);
            this.grpConsultaPaciente.Controls.Add(this.btnCadProduto);
            this.grpConsultaPaciente.Controls.Add(this.txbConsultarProdutos);
            this.grpConsultaPaciente.Location = new System.Drawing.Point(3, -1);
            this.grpConsultaPaciente.Name = "grpConsultaPaciente";
            this.grpConsultaPaciente.Size = new System.Drawing.Size(566, 556);
            this.grpConsultaPaciente.TabIndex = 47;
            this.grpConsultaPaciente.TabStop = false;
            this.grpConsultaPaciente.Enter += new System.EventHandler(this.GrpConsultaPaciente_Enter);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(452, 69);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(24, 24);
            this.btnAtualizar.TabIndex = 58;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dgv_ListaProdutos
            // 
            this.dgv_ListaProdutos.AllowUserToAddRows = false;
            this.dgv_ListaProdutos.AllowUserToDeleteRows = false;
            this.dgv_ListaProdutos.AutoGenerateColumns = false;
            this.dgv_ListaProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_ListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.quantidadeProdutoDataGridViewTextBoxColumn,
            this.descricaoProdutoDataGridViewTextBoxColumn,
            this.dataHrCadastroProdutoDataGridViewTextBoxColumn});
            this.dgv_ListaProdutos.DataSource = this.estoquesBindingSource;
            this.dgv_ListaProdutos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_ListaProdutos.Location = new System.Drawing.Point(9, 116);
            this.dgv_ListaProdutos.Name = "dgv_ListaProdutos";
            this.dgv_ListaProdutos.ReadOnly = true;
            this.dgv_ListaProdutos.Size = new System.Drawing.Size(550, 392);
            this.dgv_ListaProdutos.TabIndex = 54;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "id";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdutoDataGridViewTextBoxColumn.Width = 43;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Nome do Produto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeProdutoDataGridViewTextBoxColumn.Width = 123;
            // 
            // quantidadeProdutoDataGridViewTextBoxColumn
            // 
            this.quantidadeProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.quantidadeProdutoDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeProduto";
            this.quantidadeProdutoDataGridViewTextBoxColumn.HeaderText = "Quantidade do Produto";
            this.quantidadeProdutoDataGridViewTextBoxColumn.Name = "quantidadeProdutoDataGridViewTextBoxColumn";
            this.quantidadeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeProdutoDataGridViewTextBoxColumn.Width = 111;
            // 
            // descricaoProdutoDataGridViewTextBoxColumn
            // 
            this.descricaoProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.descricaoProdutoDataGridViewTextBoxColumn.DataPropertyName = "DescricaoProduto";
            this.descricaoProdutoDataGridViewTextBoxColumn.HeaderText = "Descrição do Produto";
            this.descricaoProdutoDataGridViewTextBoxColumn.Name = "descricaoProdutoDataGridViewTextBoxColumn";
            this.descricaoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoProdutoDataGridViewTextBoxColumn.Width = 104;
            // 
            // dataHrCadastroProdutoDataGridViewTextBoxColumn
            // 
            this.dataHrCadastroProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataHrCadastroProdutoDataGridViewTextBoxColumn.DataPropertyName = "DataHrCadastroProduto";
            this.dataHrCadastroProdutoDataGridViewTextBoxColumn.HeaderText = "Data do Cadastro";
            this.dataHrCadastroProdutoDataGridViewTextBoxColumn.Name = "dataHrCadastroProdutoDataGridViewTextBoxColumn";
            this.dataHrCadastroProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataHrCadastroProdutoDataGridViewTextBoxColumn.Width = 123;
            // 
            // estoquesBindingSource
            // 
            this.estoquesBindingSource.DataMember = "Estoques";
            this.estoquesBindingSource.DataSource = this.pimEnfermagem2019DataSet1;
            // 
            // pimEnfermagem2019DataSet1
            // 
            this.pimEnfermagem2019DataSet1.DataSetName = "PimEnfermagem2019DataSet1";
            this.pimEnfermagem2019DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnFecharPesqPac.Location = new System.Drawing.Point(544, 4);
            this.btnFecharPesqPac.Name = "btnFecharPesqPac";
            this.btnFecharPesqPac.Size = new System.Drawing.Size(22, 23);
            this.btnFecharPesqPac.TabIndex = 21;
            this.btnFecharPesqPac.UseVisualStyleBackColor = false;
            this.btnFecharPesqPac.Click += new System.EventHandler(this.btnFecharPesqPac_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirProduto.Location = new System.Drawing.Point(171, 528);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirProduto.TabIndex = 53;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.BtnExcluirProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProduto.Location = new System.Drawing.Point(90, 528);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnEditarProduto.TabIndex = 52;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadProduto.Location = new System.Drawing.Point(9, 527);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(75, 23);
            this.btnCadProduto.TabIndex = 51;
            this.btnCadProduto.Text = "Cadastrar";
            this.btnCadProduto.UseVisualStyleBackColor = true;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
            // 
            // estoquesTableAdapter
            // 
            this.estoquesTableAdapter.ClearBeforeFill = true;
            // 
            // lblConsProd
            // 
            this.lblConsProd.AutoSize = true;
            this.lblConsProd.Font = new System.Drawing.Font("Arial", 18F);
            this.lblConsProd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConsProd.Location = new System.Drawing.Point(166, 18);
            this.lblConsProd.Name = "lblConsProd";
            this.lblConsProd.Size = new System.Drawing.Size(234, 27);
            this.lblConsProd.TabIndex = 133;
            this.lblConsProd.Text = "Consulta de Produto";
            // 
            // grpBar
            // 
            this.grpBar.Location = new System.Drawing.Point(5, 48);
            this.grpBar.Name = "grpBar";
            this.grpBar.Size = new System.Drawing.Size(556, 10);
            this.grpBar.TabIndex = 132;
            this.grpBar.TabStop = false;
            // 
            // frmConsultarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(572, 562);
            this.Controls.Add(this.grpConsultaPaciente);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmConsultarEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmListarEstoque";
            this.Load += new System.EventHandler(this.frmListarEstoque_Load);
            this.grpConsultaPaciente.ResumeLayout(false);
            this.grpConsultaPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoquesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pimEnfermagem2019DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbConsultarProdutos;
        private System.Windows.Forms.GroupBox grpConsultaPaciente;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnCadProduto;
        private System.Windows.Forms.Button btnFecharPesqPac;
        private System.Windows.Forms.DataGridView dgv_ListaProdutos;
        private PimEnfermagem2019DataSet1 pimEnfermagem2019DataSet1;
        private System.Windows.Forms.BindingSource estoquesBindingSource;
        private PimEnfermagem2019DataSet1TableAdapters.EstoquesTableAdapter estoquesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHrCadastroProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblConsProd;
        private System.Windows.Forms.GroupBox grpBar;
    }
}