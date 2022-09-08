namespace UI
{
    partial class frmAnimal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPecuarista = new System.Windows.Forms.Label();
            this.cmbPecuarista = new System.Windows.Forms.ComboBox();
            this.pecuaristaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.dgvAnimal = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pecuarista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPecuarista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.MaskedTextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pecuaristaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(88, 82);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(264, 23);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(792, 32);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Cadastro Animal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(21, 85);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(61, 15);
            this.lblDescricao.TabIndex = 7;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(62, 56);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Id:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(42, 114);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(40, 15);
            this.lblPreco.TabIndex = 11;
            this.lblPreco.Text = "Preço:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(407, 85);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(72, 15);
            this.lblQuantidade.TabIndex = 13;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblPecuarista
            // 
            this.lblPecuarista.AutoSize = true;
            this.lblPecuarista.Location = new System.Drawing.Point(415, 114);
            this.lblPecuarista.Name = "lblPecuarista";
            this.lblPecuarista.Size = new System.Drawing.Size(64, 15);
            this.lblPecuarista.TabIndex = 15;
            this.lblPecuarista.Text = "Pecuarista:";
            // 
            // cmbPecuarista
            // 
            this.cmbPecuarista.FormattingEnabled = true;
            this.cmbPecuarista.Location = new System.Drawing.Point(485, 111);
            this.cmbPecuarista.Name = "cmbPecuarista";
            this.cmbPecuarista.Size = new System.Drawing.Size(264, 23);
            this.cmbPecuarista.TabIndex = 5;
            this.cmbPecuarista.Text = "Selecione";
            // 
            // pecuaristaBindingSource
            // 
            this.pecuaristaBindingSource.DataSource = typeof(UI.Entities.Pecuarista);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnterior.Location = new System.Drawing.Point(277, 460);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 10;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProximo.Location = new System.Drawing.Point(407, 460);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 11;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // dgvAnimal
            // 
            this.dgvAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAnimal.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descricao,
            this.Quantidade,
            this.Preco,
            this.Pecuarista,
            this.IdPecuarista});
            this.dgvAnimal.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.animalBindingSource, "Preco", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.dgvAnimal.DataBindings.Add(new System.Windows.Forms.Binding("AccessibleName", this.pecuaristaBindingSource, "nome", true));
            this.dgvAnimal.Location = new System.Drawing.Point(12, 174);
            this.dgvAnimal.MultiSelect = false;
            this.dgvAnimal.Name = "dgvAnimal";
            this.dgvAnimal.RowTemplate.Height = 25;
            this.dgvAnimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimal.Size = new System.Drawing.Size(765, 280);
            this.dgvAnimal.TabIndex = 12;
            this.dgvAnimal.SelectionChanged += new System.EventHandler(this.dgvAnimal_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 330;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 50;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Preco.DefaultCellStyle = dataGridViewCellStyle1;
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            // 
            // Pecuarista
            // 
            this.Pecuarista.DataPropertyName = "Pecuarista";
            this.Pecuarista.HeaderText = "Pecuarista";
            this.Pecuarista.Name = "Pecuarista";
            this.Pecuarista.Width = 210;
            // 
            // IdPecuarista
            // 
            this.IdPecuarista.DataPropertyName = "IdPecuarista";
            this.IdPecuarista.HeaderText = "IdPecuarista";
            this.IdPecuarista.Name = "IdPecuarista";
            this.IdPecuarista.Visible = false;
            this.IdPecuarista.Width = 5;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataSource = typeof(UI.Entities.Animal);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(186, 145);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(99, 145);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 145);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(277, 145);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtQuantidade.HidePromptOnLeave = true;
            this.txtQuantidade.Location = new System.Drawing.Point(485, 82);
            this.txtQuantidade.Mask = "00000000";
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(264, 23);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtQuantidade.ValidatingType = typeof(int);
            // 
            // txtId
            // 
            this.txtId.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtId.Enabled = false;
            this.txtId.HidePromptOnLeave = true;
            this.txtId.Location = new System.Drawing.Point(88, 53);
            this.txtId.Mask = "00000000";
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(264, 23);
            this.txtId.TabIndex = 1;
            this.txtId.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtId.ValidatingType = typeof(int);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(88, 111);
            this.txtPreco.MaxLength = 10;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(264, 23);
            this.txtPreco.TabIndex = 4;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            this.txtPreco.Leave += new System.EventHandler(this.txtPreco_Leave);
            // 
            // frmAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 491);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvAnimal);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.cmbPecuarista);
            this.Controls.Add(this.lblPecuarista);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblId);
            this.Name = "frmAnimal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmAnimal_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAnimal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pecuaristaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDescricao;
        private Label lblTitulo;
        private Label lblDescricao;
        private Label lblId;
        private Label lblPreco;
        private Label lblQuantidade;
        private Label lblPecuarista;
        private ComboBox cmbPecuarista;
        private Button btnAnterior;
        private Button btnProximo;
        private DataGridView dgvAnimal;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnAdicionar;
        private Button btnLimpar;
        private BindingSource pecuaristaBindingSource;
        private BindingSource animalBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Pecuarista;
        private DataGridViewTextBoxColumn IdPecuarista;
        private MaskedTextBox txtQuantidade;
        private MaskedTextBox txtId;
        private TextBox txtPreco;
    }
}