namespace UI
{
    public partial class frmComprasGado : Form
    {
        public frmComprasGado()
        {
            InitializeComponent();
            tssDataHora.Text = DateTime.Now.ToString("F");
        }

        private void mnuCadastroAnimal_Click(object sender, EventArgs e)
        {
            mnuCadastroAnimal.Enabled = false;
            frmAnimal animal = new frmAnimal();
            animal.MdiParent = this;
            animal.Show();
        }

        private void mnuCadastroCompras_Click(object sender, EventArgs e)
        {
            mnuCadastroCompras.Enabled = false;
            frmCadastroCompra cadastroCompra = new frmCadastroCompra();
            cadastroCompra.MdiParent = this;
            cadastroCompra.Show();
        }

        private void mnuCadastroPecuarista_Click(object sender, EventArgs e)
        {
            mnuCadastroPecuarista.Enabled = false;
            frmPecuarista pecuarista = new frmPecuarista();
            pecuarista.MdiParent = this;
            pecuarista.Show();
        }

        private void mnuConsultasCompras_Click(object sender, EventArgs e)
        {
            mnuConsultasCompras.Enabled = false;
            frmConsultaCompra consultaCompra = new frmConsultaCompra();
            consultaCompra.MdiParent = this;
            consultaCompra.Show();
        }

        private async void mnuRelatoriosCompras_Click(object sender, EventArgs e)
        {
            string pathRelatorio = "UI.ReportDefinitions.CompraGado.rdlc";
            string nomeDataSet = "dsCompraGado";
            string query = "";

            mnuRelatoriosCompras.Enabled = false;
            frmRelatorios compras = new frmRelatorios();
            await compras.Relatorio(pathRelatorio, query, nomeDataSet);
            compras.MdiParent = this;
            compras.Show();


        }

        private void mnuSobreAjuda_Click(object sender, EventArgs e)
        {
            mnuSobreAjuda.Enabled = false;
            frmAjuda ajuda = new frmAjuda();
            ajuda.MdiParent = this;
            ajuda.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}