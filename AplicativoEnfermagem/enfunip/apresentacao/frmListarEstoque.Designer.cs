namespace enfunip.apresentacao
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
            this.components = new System.ComponentModel.Container();
            this.txbConsultarProdutos = new System.Windows.Forms.TextBox();
            this.grpConsultaPaciente = new System.Windows.Forms.GroupBox();
            this.dgv_ListaProdutos = new System.Windows.Forms.DataGridView();
            this.estoquesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pimEnfermagem2019DataSet1 = new enfunip.PimEnfermagem2019DataSet1();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.btnFecharPesqPac = new System.Windows.Forms.Button();
            this.estoquesTableAdapter = new enfunip.PimEnfermagem2019DataSet1TableAdapters.EstoquesTableAdapter();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHrCadastroProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpConsultaPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoquesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pimEnfermagem2019DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbConsultarProdutos
            // 
            this.txbConsultarProdutos.ForeColor = System.Drawing.Color.Silver;
            this.txbConsultarProdutos.Location = new System.Drawing.Point(9, 30);
            this.txbConsultarProdutos.MaxLength = 50;
            this.txbConsultarProdutos.Name = "txbConsultarProdutos";
            this.txbConsultarProdutos.Size = new System.Drawing.Size(550, 22);
            this.txbConsultarProdutos.TabIndex = 44;
            this.txbConsultarProdutos.Text = "Insira nome do produto";
            this.txbConsultarProdutos.TextChanged += new System.EventHandler(this.TxbConsultarProdutos_TextChanged);
            // 
            // grpConsultaPaciente
            // 
            this.grpConsultaPaciente.BackColor = System.Drawing.Color.Beige;
            this.grpConsultaPaciente.Controls.Add(this.dgv_ListaProdutos);
            this.grpConsultaPaciente.Controls.Add(this.btnFecharPesqPac);
            this.grpConsultaPaciente.Controls.Add(this.btnExcluirProduto);
            this.grpConsultaPaciente.Controls.Add(this.btnEditarProduto);
            this.grpConsultaPaciente.Controls.Add(this.btnCadProduto);
            this.grpConsultaPaciente.Controls.Add(this.txbConsultarProdutos);
            this.grpConsultaPaciente.Location = new System.Drawing.Point(3, -4);
            this.grpConsultaPaciente.Name = "grpConsultaPaciente";
            this.grpConsultaPaciente.Size = new System.Drawing.Size(566, 517);
            this.grpConsultaPaciente.TabIndex = 47;
            this.grpConsultaPaciente.TabStop = false;
            this.grpConsultaPaciente.Enter += new System.EventHandler(this.GrpConsultaPaciente_Enter);
            // 
            // dgv_ListaProdutos
            // 
            this.dgv_ListaProdutos.AllowUserToAddRows = false;
            this.dgv_ListaProdutos.AllowUserToDeleteRows = false;
            this.dgv_ListaProdutos.AutoGenerateColumns = false;
            this.dgv_ListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.quantidadeProdutoDataGridViewTextBoxColumn,
            this.descricaoProdutoDataGridViewTextBoxColumn,
            this.dataHrCadastroProdutoDataGridViewTextBoxColumn});
            this.dgv_ListaProdutos.DataSource = this.estoquesBindingSource;
            this.dgv_ListaProdutos.Location = new System.Drawing.Point(9, 76);
            this.dgv_ListaProdutos.Name = "dgv_ListaProdutos";
            this.dgv_ListaProdutos.ReadOnly = true;
            this.dgv_ListaProdutos.Size = new System.Drawing.Size(550, 392);
            this.dgv_ListaProdutos.TabIndex = 54;
            this.dgv_ListaProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListaProdutos_CellContentClick);
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
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirProduto.Location = new System.Drawing.Point(178, 483);
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
            this.btnEditarProduto.Location = new System.Drawing.Point(93, 483);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnEditarProduto.TabIndex = 52;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadProduto.Location = new System.Drawing.Point(9, 483);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(75, 23);
            this.btnCadProduto.TabIndex = 51;
            this.btnCadProduto.Text = "Cadastrar";
            this.btnCadProduto.UseVisualStyleBackColor = true;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
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
            // estoquesTableAdapter
            // 
            this.estoquesTableAdapter.ClearBeforeFill = true;
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
            // frmListarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(575, 517);
            this.Controls.Add(this.grpConsultaPaciente);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmListarEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmListarEstoque";
            this.Load += new System.EventHandler(this.frmListarEstoque_Load);
            this.Enter += new System.EventHandler(this.frmListarEstoque_Enter);
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
    }
}