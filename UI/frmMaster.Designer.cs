namespace UI
{
    partial class frmComprasGado
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuCadasros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroPecuarista = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatoriosCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultasCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobreAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.strBarra = new System.Windows.Forms.StatusStrip();
            this.tssNomeFormulario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspProgresso = new System.Windows.Forms.ToolStripProgressBar();
            this.tssDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuPrincipal.SuspendLayout();
            this.strBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadasros,
            this.mnuRelatorios,
            this.mnuConsultas,
            this.mnuSobre});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(1340, 24);
            this.mnuPrincipal.TabIndex = 1;
            // 
            // mnuCadasros
            // 
            this.mnuCadasros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroCompras,
            this.mnuCadastroPecuarista,
            this.mnuCadastroAnimal,
            this.toolStripMenuItem1,
            this.mnuSair});
            this.mnuCadasros.Name = "mnuCadasros";
            this.mnuCadasros.Size = new System.Drawing.Size(71, 20);
            this.mnuCadasros.Text = "Cadastros";
            // 
            // mnuCadastroCompras
            // 
            this.mnuCadastroCompras.Name = "mnuCadastroCompras";
            this.mnuCadastroCompras.Size = new System.Drawing.Size(160, 22);
            this.mnuCadastroCompras.Text = "Compras";
            this.mnuCadastroCompras.Click += new System.EventHandler(this.mnuCadastroCompras_Click);
            // 
            // mnuCadastroPecuarista
            // 
            this.mnuCadastroPecuarista.Name = "mnuCadastroPecuarista";
            this.mnuCadastroPecuarista.Size = new System.Drawing.Size(160, 22);
            this.mnuCadastroPecuarista.Text = "Pecuarista";
            this.mnuCadastroPecuarista.Click += new System.EventHandler(this.mnuCadastroPecuarista_Click);
            // 
            // mnuCadastroAnimal
            // 
            this.mnuCadastroAnimal.Name = "mnuCadastroAnimal";
            this.mnuCadastroAnimal.Size = new System.Drawing.Size(160, 22);
            this.mnuCadastroAnimal.Text = "Animal";
            this.mnuCadastroAnimal.Click += new System.EventHandler(this.mnuCadastroAnimal_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.mnuSair.Size = new System.Drawing.Size(160, 22);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // mnuRelatorios
            // 
            this.mnuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRelatoriosCompras});
            this.mnuRelatorios.Name = "mnuRelatorios";
            this.mnuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.mnuRelatorios.Text = "Relatórios";
            // 
            // mnuRelatoriosCompras
            // 
            this.mnuRelatoriosCompras.Name = "mnuRelatoriosCompras";
            this.mnuRelatoriosCompras.Size = new System.Drawing.Size(122, 22);
            this.mnuRelatoriosCompras.Text = "Compras";
            this.mnuRelatoriosCompras.Click += new System.EventHandler(this.mnuRelatoriosCompras_Click);
            // 
            // mnuConsultas
            // 
            this.mnuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConsultasCompras});
            this.mnuConsultas.Name = "mnuConsultas";
            this.mnuConsultas.Size = new System.Drawing.Size(71, 20);
            this.mnuConsultas.Text = "Consultas";
            // 
            // mnuConsultasCompras
            // 
            this.mnuConsultasCompras.Name = "mnuConsultasCompras";
            this.mnuConsultasCompras.Size = new System.Drawing.Size(180, 22);
            this.mnuConsultasCompras.Text = "Compras";
            this.mnuConsultasCompras.Click += new System.EventHandler(this.mnuConsultasCompras_Click);
            // 
            // mnuSobre
            // 
            this.mnuSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSobreAjuda});
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(49, 20);
            this.mnuSobre.Text = "Sobre";
            // 
            // mnuSobreAjuda
            // 
            this.mnuSobreAjuda.Name = "mnuSobreAjuda";
            this.mnuSobreAjuda.Size = new System.Drawing.Size(180, 22);
            this.mnuSobreAjuda.Text = "Ajuda";
            this.mnuSobreAjuda.Click += new System.EventHandler(this.mnuSobreAjuda_Click);
            // 
            // strBarra
            // 
            this.strBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssNomeFormulario,
            this.tspProgresso,
            this.tssDataHora});
            this.strBarra.Location = new System.Drawing.Point(0, 700);
            this.strBarra.Name = "strBarra";
            this.strBarra.Size = new System.Drawing.Size(1340, 22);
            this.strBarra.TabIndex = 3;
            this.strBarra.Text = "strBarra";
            // 
            // tssNomeFormulario
            // 
            this.tssNomeFormulario.Name = "tssNomeFormulario";
            this.tssNomeFormulario.Size = new System.Drawing.Size(0, 17);
            // 
            // tspProgresso
            // 
            this.tspProgresso.Name = "tspProgresso";
            this.tspProgresso.Size = new System.Drawing.Size(100, 16);
            // 
            // tssDataHora
            // 
            this.tssDataHora.Name = "tssDataHora";
            this.tssDataHora.Size = new System.Drawing.Size(0, 17);
            // 
            // frmComprasGado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1340, 722);
            this.Controls.Add(this.strBarra);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.Name = "frmComprasGado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras Gado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.strBarra.ResumeLayout(false);
            this.strBarra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStripMenuItem mnuCadasros;
        private ToolStripMenuItem mnuSobre;
        private ToolStripMenuItem mnuRelatorios;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuSair;
        private ToolStripMenuItem mnuConsultas;
        public StatusStrip strBarra;
        public ToolStripStatusLabel tssNomeFormulario;
        public ToolStripProgressBar tspProgresso;
        public ToolStripStatusLabel tssDataHora;
        public MenuStrip mnuPrincipal;
        public ToolStripMenuItem mnuCadastroAnimal;
        public ToolStripMenuItem mnuCadastroCompras;
        public ToolStripMenuItem mnuSobreAjuda;
        public ToolStripMenuItem mnuRelatoriosCompras;
        public ToolStripMenuItem mnuCadastroPecuarista;
        public ToolStripMenuItem mnuConsultasCompras;
    }
}