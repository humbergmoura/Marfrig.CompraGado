namespace UI
{
    partial class frmCadastroCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpAnimais = new System.Windows.Forms.GroupBox();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grvCompras = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbPecuarista = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAnimal = new System.Windows.Forms.ComboBox();
            this.lblAnimais = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtIdCompraGado = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCompraGado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPecuarista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompraGado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pecuarista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAnimais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCompras)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 32);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Cadastro de Compra de Gado";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpAnimais
            // 
            this.grpAnimais.Controls.Add(this.btnProximo);
            this.grpAnimais.Controls.Add(this.btnAnterior);
            this.grpAnimais.Controls.Add(this.btnLimpar);
            this.grpAnimais.Controls.Add(this.lblTotal);
            this.grpAnimais.Controls.Add(this.grvCompras);
            this.grpAnimais.Controls.Add(this.btnAlterar);
            this.grpAnimais.Controls.Add(this.btnExcluir);
            this.grpAnimais.Controls.Add(this.btnAdicionar);
            this.grpAnimais.Location = new System.Drawing.Point(12, 165);
            this.grpAnimais.Name = "grpAnimais";
            this.grpAnimais.Size = new System.Drawing.Size(776, 343);
            this.grpAnimais.TabIndex = 18;
            this.grpAnimais.TabStop = false;
            this.grpAnimais.Text = "Animais";
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(388, 308);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 7;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(261, 308);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 6;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(295, 22);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(623, 310);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(147, 21);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total R$ 210.000,00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grvCompras
            // 
            this.grvCompras.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdAnimal,
            this.IdCompraGado,
            this.IdPecuarista,
            this.Animal,
            this.Quantidade,
            this.DataEntrega,
            this.Preco,
            this.ValorTotal,
            this.CompraGado,
            this.Pecuarista});
            this.grvCompras.Location = new System.Drawing.Point(6, 57);
            this.grvCompras.Name = "grvCompras";
            this.grvCompras.RowTemplate.Height = 25;
            this.grvCompras.Size = new System.Drawing.Size(764, 240);
            this.grvCompras.TabIndex = 3;
            this.grvCompras.SelectionChanged += new System.EventHandler(this.grvCompras_SelectionChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(196, 22);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(101, 22);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(6, 22);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Location = new System.Drawing.Point(41, 22);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(273, 23);
            this.dtpEntrega.TabIndex = 25;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(24, 44);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(11, 25);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(24, 15);
            this.lblDe.TabIndex = 1;
            this.lblDe.Text = "De:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pecuarista";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(50, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(273, 23);
            this.txtId.TabIndex = 19;
            // 
            // cmbPecuarista
            // 
            this.cmbPecuarista.FormattingEnabled = true;
            this.cmbPecuarista.Location = new System.Drawing.Point(452, 41);
            this.cmbPecuarista.Name = "cmbPecuarista";
            this.cmbPecuarista.Size = new System.Drawing.Size(327, 23);
            this.cmbPecuarista.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDe);
            this.groupBox1.Controls.Add(this.dtpEntrega);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 51);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data de entrega";
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.Location = new System.Drawing.Point(452, 76);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.Size = new System.Drawing.Size(327, 23);
            this.cmbAnimal.TabIndex = 26;
            // 
            // lblAnimais
            // 
            this.lblAnimais.AutoSize = true;
            this.lblAnimais.Location = new System.Drawing.Point(396, 80);
            this.lblAnimais.Name = "lblAnimais";
            this.lblAnimais.Size = new System.Drawing.Size(50, 15);
            this.lblAnimais.TabIndex = 25;
            this.lblAnimais.Text = "Animais";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(452, 115);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(327, 23);
            this.txtQuantidade.TabIndex = 28;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(374, 118);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(72, 15);
            this.lblQuantidade.TabIndex = 27;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(63, 76);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(260, 23);
            this.txtPreco.TabIndex = 30;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(17, 80);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(40, 15);
            this.lblPreco.TabIndex = 29;
            this.lblPreco.Text = "Preço:";
            // 
            // txtIdCompraGado
            // 
            this.txtIdCompraGado.Enabled = false;
            this.txtIdCompraGado.Location = new System.Drawing.Point(268, 41);
            this.txtIdCompraGado.Name = "txtIdCompraGado";
            this.txtIdCompraGado.Size = new System.Drawing.Size(55, 23);
            this.txtIdCompraGado.TabIndex = 31;
            this.txtIdCompraGado.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // IdAnimal
            // 
            this.IdAnimal.DataPropertyName = "IdAnimal";
            this.IdAnimal.HeaderText = "IdAnimal";
            this.IdAnimal.Name = "IdAnimal";
            this.IdAnimal.Visible = false;
            // 
            // IdCompraGado
            // 
            this.IdCompraGado.DataPropertyName = "IdCompraGado";
            this.IdCompraGado.HeaderText = "IdCompraGado";
            this.IdCompraGado.Name = "IdCompraGado";
            this.IdCompraGado.Visible = false;
            // 
            // IdPecuarista
            // 
            this.IdPecuarista.DataPropertyName = "IdPecuarista";
            this.IdPecuarista.HeaderText = "IdPecuarista";
            this.IdPecuarista.Name = "IdPecuarista";
            this.IdPecuarista.Visible = false;
            // 
            // Animal
            // 
            this.Animal.DataPropertyName = "Animal";
            this.Animal.HeaderText = "Animal";
            this.Animal.Name = "Animal";
            this.Animal.Width = 200;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 30;
            // 
            // DataEntrega
            // 
            this.DataEntrega.DataPropertyName = "DataEntrega";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.DataEntrega.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataEntrega.HeaderText = "Data Entrega";
            this.DataEntrega.Name = "DataEntrega";
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Preco.DefaultCellStyle = dataGridViewCellStyle2;
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.Width = 120;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "Total";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.ValorTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Width = 120;
            // 
            // CompraGado
            // 
            this.CompraGado.DataPropertyName = "CompraGado";
            this.CompraGado.HeaderText = "CompraGado";
            this.CompraGado.Name = "CompraGado";
            this.CompraGado.Visible = false;
            // 
            // Pecuarista
            // 
            this.Pecuarista.DataPropertyName = "Pecuarista";
            this.Pecuarista.HeaderText = "Pecuarista";
            this.Pecuarista.Name = "Pecuarista";
            this.Pecuarista.Width = 200;
            // 
            // frmCadastroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.cmbAnimal);
            this.Controls.Add(this.lblAnimais);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbPecuarista);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpAnimais);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtIdCompraGado);
            this.Name = "frmCadastroCompra";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmCadastroCompra_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastroCompra_FormClosed);
            this.grpAnimais.ResumeLayout(false);
            this.grpAnimais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCompras)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private GroupBox grpAnimais;
        private Label lblTotal;
        private DataGridView grvCompras;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnAdicionar;
        private Label lblId;
        private Label lblDe;
        private Label label3;
        private TextBox txtId;
        private ComboBox cmbPecuarista;
        private GroupBox groupBox1;
        private Button btnProximo;
        private Button btnAnterior;
        private Button btnLimpar;
        private DateTimePicker dtpEntrega;
        private ComboBox cmbAnimal;
        private Label lblAnimais;
        private TextBox txtQuantidade;
        private Label lblQuantidade;
        private TextBox txtPreco;
        private Label lblPreco;
        private TextBox txtIdCompraGado;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdAnimal;
        private DataGridViewTextBoxColumn IdCompraGado;
        private DataGridViewTextBoxColumn IdPecuarista;
        private DataGridViewTextBoxColumn Animal;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn DataEntrega;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn ValorTotal;
        private DataGridViewTextBoxColumn CompraGado;
        private DataGridViewTextBoxColumn Pecuarista;
    }
}