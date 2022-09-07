using UI.Entities;
using UI.Entities.Response;
using UI.Services;

namespace UI;

public partial class frmPecuarista : Form
{
    private int? _id = null;
    private string pagina = "1";

    public frmPecuarista()
    {
        InitializeComponent();
        ListarPecuaristasAsync();
    }

    #region [Metodos]

    private async Task ListarPecuaristasAsync()
    {
        var listPecuaristas = await new PecuaristaServices().GetAll($"Pecuarista/BuscarPecuaristas?pageSize=10&pageIndex={pagina}", "Não foi possível obter o pecuarista: ");
        dgvPecuarista.DataSource = listPecuaristas.Data;
        dgvPecuarista.Refresh();
        btnAnterior.Enabled = listPecuaristas.Pagination.HasPrevious;
        btnProximo.Enabled = listPecuaristas.Pagination.HasNext;
        LimparCampos();
        DesativarCampos();
    }

    private async void GravarPecuaristaAsync()
    {
        try
        {
            if (txtNome.Text.Length < 4)
            {
                MessageBox.Show("Informe o nome do Pecuarista!");
                return;
            }

            ListResponse<Pecuarista> listResponse = new ListResponse<Pecuarista>();
            listResponse.Data = new List<Pecuarista>();
            if (_id != null)
            {
                listResponse.Data.Add(new Pecuarista { Id = (int)_id, Nome = txtNome.Text });
            }
            else
            {
                listResponse.Data.Add(new Pecuarista { Nome = txtNome.Text });
            }

            await new PecuaristaServices().Save(listResponse, "Pecuarista/SalvarPecuarista", "Não foi possível gravar o pecuarista: ");

            ListarPecuaristasAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao Gravar!\n\n" + ex.Message, "Gravando", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LimparCampos()
    {
        dgvPecuarista.ClearSelection();
        txtId.Text = "";
        txtNome.Text = "";
        txtNome.Focus();
        DesativarCampos();
    }

    private void AtivarCampos()
    {
        btnAlterar.Enabled = true;
        btnExcluir.Enabled = true;
        btnAdicionar.Enabled = false;
        txtNome.Focus();
    }

    private void DesativarCampos()
    {
        btnAlterar.Enabled = false;
        btnExcluir.Enabled = false;
        btnAdicionar.Enabled = true;
    }
    #endregion

    #region [Eventos]

    private void frmPecuarista_Activated(object sender, EventArgs e)
    {
        frmComprasGado frmComprasGado = (frmComprasGado)this.MdiParent;
        frmComprasGado.tssNomeFormulario.Text = this.lblTitulo.Text;
    }

    private void frmPecuarista_FormClosed(object sender, FormClosedEventArgs e)
    {
        frmComprasGado frmComprasGado = (frmComprasGado)(this.MdiParent);
        frmComprasGado.mnuCadastroPecuarista.Enabled = true;
    }

    private void btnAdicionar_Click(object sender, EventArgs e)
    {
        GravarPecuaristaAsync();
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtId.Text, out int id))
        {
            _id = id;
            GravarPecuaristaAsync();
        }
        else
        {
            MessageBox.Show("Id inválido!");
        }
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtId.Text, out int id))
        {
            await new PecuaristaServices().Delete(id, "Pecuarista/ExcluirPecuarista?id=", "Não foi possível excluir o pecuarista: ");
            ListarPecuaristasAsync();
        }
        else
        {
            MessageBox.Show("Id inválido!");
        }
    }

    private async void btnAnterior_Click(object sender, EventArgs e)
    {
        int _pagina = Convert.ToInt32(pagina);
        _pagina = _pagina - 1;
        pagina = _pagina.ToString();
        ListarPecuaristasAsync();
    }

    private async void btnProximo_Click(object sender, EventArgs e)
    {
        int _pagina = Convert.ToInt32(pagina);
        _pagina = _pagina + 1;
        pagina = _pagina.ToString();
        ListarPecuaristasAsync();
    }

    private void btnLimpar_Click(object sender, EventArgs e)
    {
        LimparCampos();
    }

    private void dgvPecuarista_SelectionChanged(object sender, EventArgs e)
    {
        DataGridView? dgv = sender as DataGridView;
        if (dgv != null && dgv.SelectedRows.Count > 0)
        {
            DataGridViewRow row = dgv.SelectedRows[0];
            if (row != null)
            {
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtNome.Text = row.Cells["Nome"].Value.ToString();
            }
        }
        AtivarCampos();
    }
    #endregion
}
