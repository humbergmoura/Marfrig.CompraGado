namespace Relatorio.Visualizador
{
    partial class Visualizar
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
            this.rpvPrincipal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvPrincipal
            // 
            this.rpvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvPrincipal.LocalReport.ReportEmbeddedResource = "Relatorio.Relatorios.CompraGado.rdlc";
            this.rpvPrincipal.Location = new System.Drawing.Point(0, 0);
            this.rpvPrincipal.Name = "rpvPrincipal";
            this.rpvPrincipal.ServerReport.BearerToken = null;
            this.rpvPrincipal.Size = new System.Drawing.Size(642, 712);
            this.rpvPrincipal.TabIndex = 0;
            // 
            // Visualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 712);
            this.Controls.Add(this.rpvPrincipal);
            this.KeyPreview = true;
            this.Name = "Visualizar";
            this.Text = "Visualizar";
            this.Load += new System.EventHandler(this.Visualizar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvPrincipal;
    }
}