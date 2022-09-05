using System.Data;
using UI.Entities;
using UI.Entities.Response;
using UI.Services;

namespace UI;

public partial class frmConsultaCompra : Form
{
    private int? _id = null;
    private string pagina = "1";
    private ListResponse<Pecuarista> listPecuaristas;

    public frmConsultaCompra()
    {
        InitializeComponent();
        ListarCompraGadoAsync();
    }

    #region [Metodos]

    private async Task ListarCompraGadoAsync()
    {
        var listCompraGadoItems = await new CompraGadoItemServices().GetAll($"CompraGadoItem/BuscarCompraGadoItems?pageSize=10&pageIndex={pagina}", "Não foi possível obter o animais: ");
        var listAnimais = await new AnimalServices().GetAll($"Animais/BuscarAnimais?pageSize=10&pageIndex={pagina}", "Não foi possível obter o animais: ");
        listPecuaristas = await new PecuaristaServices().GetAll($"Pecuarista/BuscarPecuaristas?pageSize=100&pageIndex=1", "Não foi possível obter o pecuarista: ");
        var listCompraGado = await new CompraGadoServices().GetAll($"CompraGado/BuscarCompraGado?pageSize=10&pageIndex={pagina}", "Não foi possível obter o CompraGado: ");

        listCompraGadoItems.Data.Where(x => x.Id == x.Id ||
                                            x.Id == Convert.ToInt32(txtId.Text) &&
                                            x.Pecuarista == x.Pecuarista ||
                                            x.Pecuarista == cmbPecuarista.Text &&
                                            x.DataEntrega >= Convert.ToDateTime(dtpDe.Text) ||
                                            x.DataEntrega == x.DataEntrega &&
                                            x.DataEntrega <= Convert.ToDateTime(dtpAte.Text) ||
                                            x.DataEntrega == x.DataEntrega).ToList();

        foreach (var item in listCompraGadoItems.Data)
        {
            item.CompraGado = listCompraGado.Data.FirstOrDefault(e => e.Id == item.IdCompraGado);
            item.DataEntrega = listCompraGado.Data.FirstOrDefault(e => e.Id == item.IdCompraGado).DataEntrega;
            item.Preco = listAnimais.Data.FirstOrDefault(e => e.Id == item.IdAnimal).Preco;
            item.Animal = listAnimais.Data.FirstOrDefault(e => e.Id == item.IdAnimal).Descricao;
            item.Pecuarista = listPecuaristas.Data.FirstOrDefault(e => e.id == item.CompraGado.IdPecuarista).nome;
            item.Total = Math.Round(item.Preco * item.Quantidade, 2);
        }

        grvCompras.DataSource = listCompraGadoItems.Data;
        grvCompras.Refresh();
        ListarPecuaristasAsync();

        btnAnterior.Enabled = listCompraGado.Pagination.HasPrevious;
        btnProximo.Enabled = listCompraGado.Pagination.HasNext;
        LimparCampos();
    }

    private async Task ListarPecuaristasAsync()
    {
        cmbPecuarista.ValueMember = "id";
        cmbPecuarista.DisplayMember = "nome";

        cmbPecuarista.DataSource = listPecuaristas.Data;
        cmbPecuarista.Items.Add("Selecione");
        cmbPecuarista.Refresh();
    }

    private void LimparCampos()
    {
        grvCompras.ClearSelection();
        txtId.Text = "";
        cmbPecuarista.SelectedItem = null;
        dtpDe.Text = DateTime.Now.AddMonths(-1).ToString();
        dtpAte.Text = DateTime.Now.ToString();
        _id = null;
    }

    #endregion

    #region [Eventos]
    private void frmConsultaCompra_Activated(object sender, EventArgs e)
    {
        frmComprasGado frmComprasGado = (frmComprasGado)this.MdiParent;
        frmComprasGado.tssNomeFormulario.Text = this.lblTitulo.Text;
    }

    private void frmConsultaCompra_FormClosed(object sender, FormClosedEventArgs e)
    {
        frmComprasGado frmComprasGado = (frmComprasGado)(this.MdiParent);
        frmComprasGado.mnuConsultasCompras.Enabled = true;
    }
    #endregion

    private void btnPesquisar_Click(object sender, EventArgs e)
    {

    }

    private void btnImprimir_Click(object sender, EventArgs e)
    {

    }

    private void btnLimpar_Click(object sender, EventArgs e)
    {
        LimparCampos();
    }

    private void grvCompras_SelectionChanged(object sender, EventArgs e)
    {
        DataGridView? dgv = sender as DataGridView;
        if (dgv != null && dgv.SelectedRows.Count > 0)
        {
            DataGridViewRow row = dgv.SelectedRows[0];
            if (row != null)
            {
                txtId.Text = row.Cells["Id"].Value.ToString();
                dtpDe.Text = row.Cells["DataEntrega"].Value.ToString();
                dtpAte.Text = row.Cells["DataEntrega"].Value.ToString();
                cmbPecuarista.SelectedValue = (int)row.Cells["IdPecuarista"].Value;
            }
        }
    }
}
