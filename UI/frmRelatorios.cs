using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Entities;
using UI.Entities.Response;
using UI.Services;

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

        private async void frmRelatorios_Load(object sender, EventArgs e)
        {
            //string pathRelatorio = "UI.ReportDefinitions.CompraGado.rdlc";
            //string nomeDataSet = "dsCompraGado";
            //string query = "";

            //await Relatorio(pathRelatorio, query, nomeDataSet);
        }

        public async Task Relatorio(string pathRelatorio, string query, string nomeDataSet)
        {
            rpvVisualizador.LocalReport.ReportEmbeddedResource = pathRelatorio;
            rpvVisualizador.RefreshReport();

            var listCompraGadoItems = await new CompraGadoItemServices().GetAll($"CompraGadoItem/BuscarCompraGadoItems?pageSize=100&pageIndex=1{query}", "Não foi possível obter o animais: ");
            var listAnimais = await new AnimalServices().GetAll($"Animais/BuscarAnimais?pageSize=100&pageIndex=1", "Não foi possível obter o animais: ");
            var listPecuaristas = await new PecuaristaServices().GetAll($"Pecuarista/BuscarPecuaristas?pageSize=100&pageIndex=1", "Não foi possível obter o pecuarista: ");

            foreach (var item in listCompraGadoItems.Data)
            {
                item.DataEntrega = item.CompraGado.DataEntrega;
                item.Preco = listAnimais.Data.FirstOrDefault(x => x.Id == item.IdAnimal).Preco;
                item.Animal = listAnimais.Data.FirstOrDefault(x => x.Id == item.IdAnimal).Descricao;
                item.Pecuarista = listPecuaristas.Data.FirstOrDefault(x => x.Id == item.CompraGado.IdPecuarista).Nome;
                item.IdPecuarista = listPecuaristas.Data.FirstOrDefault(x => x.Id == item.CompraGado.IdPecuarista).Id;
                item.Total = Math.Round(item.Preco * item.Quantidade, 2);
            }

            DataTable table = ConverterParaDataTable(listCompraGadoItems);

            rpvVisualizador.LocalReport.ReportEmbeddedResource = pathRelatorio;
            var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource(nomeDataSet, table);
            this.rpvVisualizador.LocalReport.DataSources.Clear();
            this.rpvVisualizador.LocalReport.DataSources.Add(dataSource);
            this.rpvVisualizador.RefreshReport();
        }

        private static DataTable ConverterParaDataTable(ListResponse<CompraGadoItem> listCompraGadoItems)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(CompraGadoItem));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (CompraGadoItem item in listCompraGadoItems.Data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }

            return table;
        }
    }
}
