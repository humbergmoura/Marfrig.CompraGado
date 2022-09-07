using System.Globalization;
using System.Text.RegularExpressions;
using UI.Entities;
using UI.Entities.Response;
using UI.Services;

namespace UI;

public partial class frmAnimal : Form
{
    private int? _id = null;
    private string pagina = "1";
    private ListResponse<Pecuarista> listPecuaristas;
    private static int countlength = 0;

    public frmAnimal()
    {
        InitializeComponent();
        ListarAnimalAsync();
    }

    #region [Metodos]

    private async Task ListarAnimalAsync()
    {
        var listAnimals = await new AnimalServices().GetAll($"Animais/BuscarAnimais?pageSize=10&pageIndex={pagina}", "Não foi possível obter o animais: ");
        listPecuaristas = await new PecuaristaServices().GetAll($"Pecuarista/BuscarPecuaristas?pageSize=1000&pageIndex=1", "Não foi possível obter o pecuarista: ");
        foreach (var item in listAnimals.Data)
        {
            item.Pecuarista = listPecuaristas.Data.FirstOrDefault(e => e.Id == item.IdPecuarista).Nome;
        }
        dgvAnimal.DataSource = listAnimals.Data;
        dgvAnimal.Refresh();
        btnAnterior.Enabled = listAnimals.Pagination.HasPrevious;
        btnProximo.Enabled = listAnimals.Pagination.HasNext;
        ListarPecuaristasAsync();
        LimparCampos();
        DesativarCampos();
    }

    private async void GravarAnimalAsync()
    {
        try
        {
            if (txtDescricao.Text.Length < 4)
            {
                MessageBox.Show("Informe o Descrição do Animal!");
                return;
            }

            ListResponse<Animal> listResponse = new ListResponse<Animal>();
            listResponse.Data = new List<Animal>();
            if (_id != null)
            {
                listResponse.Data.Add(new Animal { Id = (int)_id, Descricao = txtDescricao.Text, Preco = Convert.ToDecimal(txtPreco.Text.Replace("R$ ", "")), Quantidade = Convert.ToInt32(txtQuantidade.Text), IdPecuarista = listPecuaristas.Data.FirstOrDefault(e => e.Nome == cmbPecuarista.Text).Id });
            }
            else
            {
                listResponse.Data.Add(new Animal { Descricao = txtDescricao.Text, Preco = Convert.ToDecimal(txtPreco.Text.Replace("R$ ", "")), Quantidade = Convert.ToInt32(txtQuantidade.Text), IdPecuarista = listPecuaristas.Data.FirstOrDefault(e => e.Nome == cmbPecuarista.Text).Id });
            }

            await new AnimalServices().Save(listResponse, "Animais/SalvarAnimal", "Não foi possível gravar o animal: ");

            ListarAnimalAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao Gravar!\n\n" + ex.Message, "Gravando", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task ListarPecuaristasAsync()
    {
        cmbPecuarista.ValueMember = "id";
        cmbPecuarista.DisplayMember = "nome";

        cmbPecuarista.DataSource = listPecuaristas.Data;
        cmbPecuarista.Items.Add("Selecione");
        cmbPecuarista.Refresh();
    }

    private void dgvAnimal_SelectionChanged(object sender, EventArgs e)
    {
        DataGridView? dgv = sender as DataGridView;
        if (dgv != null && dgv.SelectedRows.Count > 0)
        {
            DataGridViewRow row = dgv.SelectedRows[0];
            if (row != null)
            {
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtDescricao.Text = row.Cells["Descricao"].Value.ToString();
                txtPreco.Text = row.Cells["Preco"].Value.ToString();
                txtQuantidade.Text = row.Cells["Quantidade"].Value.ToString();
                cmbPecuarista.SelectedValue = (int)row.Cells["IdPecuarista"].Value;
            }
        }
        AtivarCampos();
    }

    private void LimparCampos()
    {
        dgvAnimal.ClearSelection();
        txtId.Text = "";
        txtDescricao.Text = "";
        txtPreco.Text = "";
        txtQuantidade.Text = "";
        txtDescricao.Focus();
        cmbPecuarista.SelectedItem = null;
        _id = null;
        DesativarCampos();
    }

    private void AtivarCampos()
    {
        btnAlterar.Enabled = true;
        btnExcluir.Enabled = true;
        btnAdicionar.Enabled = false;
        txtDescricao.Focus();
    }

    private void DesativarCampos()
    {
        btnAlterar.Enabled = false;
        btnExcluir.Enabled = false;
        btnAdicionar.Enabled = true;
    }
    #endregion

    #region [Eventos]

    #endregion
    private void frmAnimal_Activated(object sender, EventArgs e)
    {
        frmComprasGado frmComprasGado = (frmComprasGado)this.MdiParent;
        frmComprasGado.tssNomeFormulario.Text = this.lblTitulo.Text;
    }

    private void frmAnimal_FormClosed(object sender, FormClosedEventArgs e)
    {
        frmComprasGado frmComprasGado = (frmComprasGado)(this.MdiParent);
        frmComprasGado.mnuCadastroAnimal.Enabled = true;
    }

    private void btnAnterior_Click(object sender, EventArgs e)
    {
        int _pagina = Convert.ToInt32(pagina);
        _pagina = _pagina - 1;
        pagina = _pagina.ToString();
        ListarAnimalAsync();
    }

    private void btnProximo_Click(object sender, EventArgs e)
    {
        int _pagina = Convert.ToInt32(pagina);
        _pagina = _pagina + 1;
        pagina = _pagina.ToString();
        ListarAnimalAsync();
    }

    private async void btnExcluir_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtId.Text, out int id))
        {
            await new AnimalServices().Delete(id, "Animais/ExcluirAnimal?id=", "Não foi possível excluir o animal: ");
            ListarAnimalAsync();
        }
        else
        {
            MessageBox.Show("Id inválido!");
        }
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtId.Text, out int id))
        {
            _id = id;
            GravarAnimalAsync();
        }
        else
        {
            MessageBox.Show("Id inválido!");
        }
    }

    private void btnAdicionar_Click(object sender, EventArgs e)
    {
        GravarAnimalAsync();
    }

    private void btnLimpar_Click(object sender, EventArgs e)
    {
        LimparCampos();
    }

    private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) || !char.IsDigit(e.KeyChar) || (e.KeyChar != ','))
        {
            e.Handled = true;
        }
    }

    private void txtPreco_Leave(object sender, EventArgs e)
    {
        var regex = new Regex(@"^\d+(\.\d{2})?$");
        if (regex.IsMatch(txtPreco.Text))
        {
            var culture = new CultureInfo("pt-BR");
            var valor = Convert.ToDecimal(txtPreco.Text, culture);
            txtPreco.Text = valor.ToString("C2");
        }
    }
}
