using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmRelatorios : Form
    {
        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void frmRelatorios_Activated(object sender, EventArgs e)
        {
            frmComprasGado frmComprasGado = (frmComprasGado)this.MdiParent;
            frmComprasGado.tssNomeFormulario.Text = this.lblTitulo.Text;
        }

        private void frmRelatorios_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmComprasGado frmComprasGado = (frmComprasGado)(this.MdiParent);
            frmComprasGado.mnuRelatoriosCompras.Enabled = true;
        }
    }
}
