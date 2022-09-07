using UI.Entities;
using UI.Entities.Response;
using UI.Services;

namespace UI;

public partial class frmCadastroCompra : Form
{
    private int? _id = null;
    private string pagina = "1";
    private ListResponse<Pecuarista> listPecuaristas;
    private ListResponse<Animal> listAnimais;
    private ListResponse<CompraGadoItem> listCompraGadoItems;

    public frmCadastroCompra()
    {
        InitializeComponent();
        ListarCompraGadoAsync();
    }

    #region [Metodos]

    private async Task ListarCompraGadoAsync()
    {
        listCompraGadoItems = await new CompraGadoItemServices().GetAll($"CompraGadoItem/BuscarCompraGadoItems?pageSize=10&pageIndex={pagina}", "Não foi possível obter o animais: ");
        listAnimais = await new AnimalServices().GetAll($"Animais/BuscarAnimais?pageSize=100&pageIndex=1", "Não foi possível obter o animais: ");
        listPecuaristas = await new PecuaristaServices().GetAll($"Pecuarista/BuscarPecuaristas?pageSize=100&pageIndex=1", "Não foi possível obter o pecuarista: ");
        //var listCompraGado = await new CompraGadoServices().GetAll($"CompraGado/BuscarCompraGado?pageSize=100&pageIndex=1", "Não foi possível obter o CompraGado: ");
        decimal total = 0;
        foreach (var item in listCompraGadoItems.Data)
        {
            //item.CompraGado = listCompraGado.Data.FirstOrDefault(e => e.Id == item.IdCompraGado);
            item.DataEntrega = item.CompraGado.DataEntrega;
            item.Preco = listAnimais.Data.FirstOrDefault(e => e.Id == item.IdAnimal).Preco;
            item.Animal = listAnimais.Data.FirstOrDefault(e => e.Id == item.IdAnimal).Descricao;
            item.Pecuarista = listPecuaristas.Data.FirstOrDefault(e => e.Id == item.CompraGado.IdPecuarista).Nome;
            item.IdPecuarista = listPecuaristas.Data.FirstOrDefault(e => e.Id == item.CompraGado.IdPecuarista).Id;
            item.Total = Math.Round(item.Preco * item.Quantidade, 2);
            total += item.Total;
        }
        lblTotal.Text = "Total: " + total.ToString("c");

        grvCompras.DataSource = listCompraGadoItems.Data;
        grvCompras.Refresh();
        ListarAnimalAsync();
        ListarPecuaristasAsync();
        btnAnterior.Enabled = listCompraGadoItems.Pagination.HasPrevious;
        btnProximo.Enabled = listCompraGadoItems.Pagination.HasNext;
        LimparCampos();
        DesativarCampos();
    }

    private async Task ListarAnimalAsync()
    {
        cmbAnimal.ValueMember = "Id";
        cmbAnimal.DisplayMember = "Descricao";
        cmbAnimal.DataSource = listAnimais.Data;
        cmbAnimal.Refresh();
    }

    private async Task ListarPecuaristasAsync()
    {
        cmbPecuarista.ValueMember = "id";
        cmbPecuarista.DisplayMember = "nome";

        cmbPecuarista.DataSource = listPecuaristas.Data;
        cmbPecuarista.Items.Add("Selecione");
        cmbPecuarista.Refresh();
    }

    private async void GravarCompraGadoAsync()
    {
        try
        {
            if (txtQuantidade.Text.Length < 1)
            {
                MessageBox.Show("Informe o Quantidade do CompraGado!");
                return;
            }

            ListResponse<CompraGado> listResponse = new ListResponse<CompraGado>();
            listResponse.Data = new List<CompraGado>();
            IList<CompraGadoItem> compraGadoItem = GetCompraGadoItem();
            if (_id != null)
            {
                listResponse.Data.Add(new CompraGado { Id = (int)_id, compraGadoItemDTO = compraGadoItem, DataEntrega = Convert.ToDateTime(dtpEntrega.Text), IdPecuarista = Convert.ToInt32(cmbPecuarista.SelectedValue) }); 
            }
            else
            {
                listResponse.Data.Add(new CompraGado { compraGadoItemDTO = compraGadoItem, DataEntrega = Convert.ToDateTime(dtpEntrega.Text), IdPecuarista = Convert.ToInt32(cmbPecuarista.SelectedValue) });
            }

            await new CompraGadoServices().Save(listResponse, "CompraGado/SalvarCompraGado", "Não foi possível gravar o Compra Gado: ");

            ListarCompraGadoAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao Gravar!\n\n" + ex.Message, "Gravando", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private IList<CompraGadoItem> GetCompraGadoItem()
    {
        IList<CompraGadoItem> compraGadoItems = new List<CompraGadoItem>();
        CompraGadoItem compraGadoItem = new CompraGadoItem();
        if (!string.IsNullOrEmpty(txtId.Text))
            compraGadoItem.Id = Convert.ToInt32(txtId.Text);
        if (_id != null)
            compraGadoItem.IdCompraGado = (int)_id;
        compraGadoItem.IdAnimal = Convert.ToInt32(cmbAnimal.SelectedValue);
        compraGadoItem.Quantidade = Convert.ToInt32(txtQuantidade.Text);
        compraGadoItems.Add(compraGadoItem);
        return compraGadoItems;
    }

    private void LimparCampos()
    {
        grvCompras.ClearSelection();
        txtId.Text = "";
        txtPreco.Text = "";
        txtQuantidade.Text = "";
        txtQuantidade.Focus();
        cmbPecuarista.SelectedItem = null;
        cmbAnimal.SelectedItem = null;
        _id = null;
    }

    private void AtivarCampos()
    {
        btnAlterar.Enabled = true;
        btnExcluir.Enabled = true;
        txtQuantidade.Focus();
    }

    private void DesativarCampos()
    {
        btnAlterar.Enabled = false;
        btnExcluir.Enabled = false;
    }
    #endregion

    #region [Eventos]
    private void frmCadastroCompra_Activated(object sender, EventArgs e)
    {
        frmComprasGado frmComprasGado = (frmComprasGado)this.MdiParent;
        frmComprasGado.tssNomeFormulario.Text = this.lblTitulo.Text;
    }

    private void frmCadastroCompra_FormClosed(object sender, FormClosedEventArgs e)
    {
        frmComprasGado frmComprasGado = (frmComprasGado)(this.MdiParent);
        frmComprasGado.mnuCadastroCompras.Enabled = true;
    }

    private void btnAdicionar_Click(object sender, EventArgs e)
    {
        GravarCompraGadoAsync();
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtId.Text, out int id))
        {
            await new AnimalServices().Delete(id, "CompraGadoItem/ExcluirCompraGadoItem?id=", "Não foi possível excluir o animal: ");
            ListarCompraGadoAsync();
        }
        else
        {
            MessageBox.Show("Id inválido!");
        }
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtIdCompraGado.Text, out int id))
        {
            _id = id;
            GravarCompraGadoAsync();
        }
        else
        {
            MessageBox.Show("Id inválido!");
        }
    }

    private void btnLimpar_Click(object sender, EventArgs e)
    {
        LimparCampos();
    }

    private void btnAnterior_Click(object sender, EventArgs e)
    {
        int _pagina = Convert.ToInt32(pagina);
        _pagina = _pagina - 1;
        pagina = _pagina.ToString();
        ListarCompraGadoAsync();
    }

    private void btnProximo_Click(object sender, EventArgs e)
    {
        int _pagina = Convert.ToInt32(pagina);
        _pagina = _pagina + 1;
        pagina = _pagina.ToString();
        ListarCompraGadoAsync();
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
                txtIdCompraGado.Text = row.Cells["IdCompraGado"].Value.ToString();
                txtPreco.Text = row.Cells["Preco"].Value.ToString();
                txtQuantidade.Text = row.Cells["Quantidade"].Value.ToString();
                dtpEntrega.Text = row.Cells["DataEntrega"].Value.ToString();
                cmbPecuarista.SelectedValue = (int)row.Cells["IdPecuarista"].Value;
                cmbAnimal.SelectedValue = (int)row.Cells["IdAnimal"].Value;
            }
        }
        AtivarCampos();
    }
    #endregion
}
