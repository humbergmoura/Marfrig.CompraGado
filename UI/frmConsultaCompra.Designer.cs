namespace UI
{
    partial class frmConsultaCompra
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPecuarista = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbPecuarista = new System.Windows.Forms.ComboBox();
            this.grvCompras = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.lblAte = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pecuarista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCompraGado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompraGado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvCompras)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Enabled = false;
            this.btnPesquisar.Location = new System.Drawing.Point(10, 49);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(103, 49);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(245, 407);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 5;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(326, 407);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 6;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(25, 93);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Id:";
            // 
            // lblPecuarista
            // 
            this.lblPecuarista.AutoSize = true;
            this.lblPecuarista.Location = new System.Drawing.Point(361, 93);
            this.lblPecuarista.Name = "lblPecuarista";
            this.lblPecuarista.Size = new System.Drawing.Size(64, 15);
            this.lblPecuarista.TabIndex = 9;
            this.lblPecuarista.Text = "Pecuarista:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(51, 87);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(249, 23);
            this.txtId.TabIndex = 11;
            // 
            // cmbPecuarista
            // 
            this.cmbPecuarista.FormattingEnabled = true;
            this.cmbPecuarista.Location = new System.Drawing.Point(431, 87);
            this.cmbPecuarista.Name = "cmbPecuarista";
            this.cmbPecuarista.Size = new System.Drawing.Size(239, 23);
            this.cmbPecuarista.TabIndex = 14;
            // 
            // grvCompras
            // 
            this.grvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Pecuarista,
            this.DataEntrega,
            this.IdCompraGado,
            this.IdAnimal,
            this.Quantidade,
            this.Total,
            this.Preco,
            this.Animal,
            this.CompraGado});
            this.grvCompras.Location = new System.Drawing.Point(10, 197);
            this.grvCompras.Name = "grvCompras";
            this.grvCompras.RowTemplate.Height = 25;
            this.grvCompras.Size = new System.Drawing.Size(670, 204);
            this.grvCompras.TabIndex = 15;
            this.grvCompras.SelectionChanged += new System.EventHandler(this.grvCompras_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(695, 32);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Consulta de Compra de Gado";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpAte);
            this.groupBox1.Controls.Add(this.lblAte);
            this.groupBox1.Controls.Add(this.lblDe);
            this.groupBox1.Controls.Add(this.dtpDe);
            this.groupBox1.Location = new System.Drawing.Point(10, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 56);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data de entrega";
            // 
            // dtpAte
            // 
            this.dtpAte.Location = new System.Drawing.Point(422, 22);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(238, 23);
            this.dtpAte.TabIndex = 26;
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(388, 25);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(28, 15);
            this.lblAte.TabIndex = 22;
            this.lblAte.Text = "Até:";
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
            // dtpDe
            // 
            this.dtpDe.Location = new System.Drawing.Point(41, 22);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(249, 23);
            this.dtpDe.TabIndex = 25;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(196, 49);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // Pecuarista
            // 
            this.Pecuarista.DataPropertyName = "Pecuarista";
            this.Pecuarista.HeaderText = "Pecuarista";
            this.Pecuarista.Name = "Pecuarista";
            this.Pecuarista.Width = 300;
            // 
            // DataEntrega
            // 
            this.DataEntrega.DataPropertyName = "DataEntrega";
            this.DataEntrega.HeaderText = "DataEntrega";
            this.DataEntrega.Name = "DataEntrega";
            this.DataEntrega.Width = 150;
            // 
            // IdCompraGado
            // 
            this.IdCompraGado.DataPropertyName = "IdCompraGado";
            this.IdCompraGado.HeaderText = "IdCopraGado";
            this.IdCompraGado.Name = "IdCompraGado";
            this.IdCompraGado.Visible = false;
            // 
            // IdAnimal
            // 
            this.IdAnimal.DataPropertyName = "IdAnimal";
            this.IdAnimal.HeaderText = "IdAnimal";
            this.IdAnimal.Name = "IdAnimal";
            this.IdAnimal.Visible = false;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Visible = false;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Valor Total";
            this.Total.Name = "Total";
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.HeaderText = "Preco";
            this.Preco.Name = "Preco";
            this.Preco.Visible = false;
            // 
            // Animal
            // 
            this.Animal.DataPropertyName = "Animal";
            this.Animal.HeaderText = "Animal";
            this.Animal.Name = "Animal";
            this.Animal.Visible = false;
            // 
            // CompraGado
            // 
            this.CompraGado.DataPropertyName = "CompraGado";
            this.CompraGado.HeaderText = "CompraGado";
            this.CompraGado.Name = "CompraGado";
            this.CompraGado.Visible = false;
            // 
            // frmConsultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 444);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grvCompras);
            this.Controls.Add(this.cmbPecuarista);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPecuarista);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "frmConsultaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmConsultaCompra_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConsultaCompra_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.grvCompras)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPesquisar;
        private Button btnImprimir;
        private Button btnAnterior;
        private Button btnProximo;
        private Label lblId;
        private Label lblPecuarista;
        private TextBox txtId;
        private ComboBox cmbPecuarista;
        private DataGridView grvCompras;
        private Label lblTitulo;
        private GroupBox groupBox1;
        private DateTimePicker dtpAte;
        private Label lblAte;
        private Label lblDe;
        private DateTimePicker dtpDe;
        private Button btnLimpar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Pecuarista;
        private DataGridViewTextBoxColumn DataEntrega;
        private DataGridViewTextBoxColumn IdCompraGado;
        private DataGridViewTextBoxColumn IdAnimal;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Animal;
        private DataGridViewTextBoxColumn CompraGado;
    }
}