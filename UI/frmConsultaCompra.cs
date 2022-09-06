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
    private string query = "";

    public frmConsultaCompra()
    {
        InitializeComponent();
        ListarCompraGadoAsync();
    }

    #region [Metodos]

    private async Task ListarCompraGadoAsync(string query = "")
    {
        var listCompraGadoItems = await new CompraGadoItemServices().GetAll($"CompraGadoItem/BuscarCompraGadoItems?pageSize=10&pageIndex={pagina}{query}", "Não foi possível obter o animais: ");
        var listAnimais = await new AnimalServices().GetAll($"Animais/BuscarAnimais?pageSize=100&pageIndex=1", "Não foi possível obter o animais: ");
        listPecuaristas = await new PecuaristaServices().GetAll($"Pecuarista/BuscarPecuaristas?pageSize=100&pageIndex=1", "Não foi possível obter o pecuarista: ");
        var listCompraGado = await new CompraGadoServices().GetAll($"CompraGado/BuscarCompraGado?pageSize=100&pageIndex=1", "Não foi possível obter o CompraGado: ");

        if (listCompraGadoItems.Data != null)
        {
            foreach (var item in listCompraGadoItems.Data)
            {
                item.CompraGado = listCompraGado.Data.FirstOrDefault(e => e.Id == item.IdCompraGado);
                item.DataEntrega = listCompraGado.Data.FirstOrDefault(e => e.Id == item.IdCompraGado).DataEntrega;
                item.Preco = listAnimais.Data.FirstOrDefault(e => e.Id == item.IdAnimal).Preco;
                item.Animal = listAnimais.Data.FirstOrDefault(e => e.Id == item.IdAnimal).Descricao;
                item.Pecuarista = listPecuaristas.Data.FirstOrDefault(e => e.id == item.CompraGado.IdPecuarista).nome;
                item.IdPecuarista = listPecuaristas.Data.FirstOrDefault(e => e.id == item.CompraGado.IdPecuarista).id;
                item.Total = Math.Round(item.Preco * item.Quantidade, 2);
            }
        }

        grvCompras.DataSource = listCompraGadoItems.Data;
        grvCompras.Refresh();
        ListarPecuaristasAsync();

        btnAnterior.Enabled = listCompraGadoItems.Pagination.HasPrevious;
        btnProximo.Enabled = listCompraGadoItems.Pagination.HasNext;
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
        query = "";
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
        if (!string.IsNullOrEmpty(cmbPecuarista.Text))
        {
            query += $"&Nome={cmbPecuarista.Text}";
        }
        if (!string.IsNullOrEmpty(txtId.Text))
        {
            query += $"&Id={txtId.Text}";
        }

        ListarCompraGadoAsync(query);
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

    private void dtpDe_ValueChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(dtpDe.Text))
        {
            query += $"&DataDe={DateTimeOffset.Parse(dtpDe.Text).UtcDateTime}";
        }
    }

    private void dtpAte_ValueChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(dtpAte.Text))
        {
            query += $"&DataAte={DateTimeOffset.Parse(dtpAte.Text).UtcDateTime}";
        }
    }
}
