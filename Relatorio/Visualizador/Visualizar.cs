using Relatorio.Entities;
using Relatorio.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Relatorio.Visualizador
{
    public partial class Visualizar : Form
    {
        public Visualizar()
        {
            InitializeComponent();
        }

        private async void Visualizar_Load(object sender, EventArgs e)
        {
            var listCompraGadoItems = await new CompraGadoItemServices().GetAll($"CompraGadoItem/BuscarCompraGadoItems?pageSize=10&pageIndex=1", "Não foi possível obter o animais: ");
            var listAnimais = await new AnimalServices().GetAll($"Animais/BuscarAnimais?pageSize=10&pageIndex=1", "Não foi possível obter o animais: ");
            var listPecuaristas = await new PecuaristaServices().GetAll($"Pecuarista/BuscarPecuaristas?pageSize=100&pageIndex=1", "Não foi possível obter o pecuarista: ");

            foreach (var item in listCompraGadoItems)
            {
                item.DataEntrega = item.CompraGado.DataEntrega;
                item.Preco = listAnimais.FirstOrDefault(x => x.Id == item.IdAnimal).Preco;
                item.Animal = listAnimais.FirstOrDefault(x => x.Id == item.IdAnimal).Descricao;
                item.Pecuarista = listPecuaristas.FirstOrDefault(x => x.id == item.CompraGado.IdPecuarista).nome;
                item.IdPecuarista = listPecuaristas.FirstOrDefault(x => x.id == item.CompraGado.IdPecuarista).id;
                item.Total = Math.Round(item.Preco * item.Quantidade, 2);
            }

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(CompraGadoItem));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (CompraGadoItem item in listCompraGadoItems)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }

            var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource("dsCompraGado", table);
            this.rpvPrincipal.LocalReport.DataSources.Clear();
            this.rpvPrincipal.LocalReport.DataSources.Add(dataSource);
            this.rpvPrincipal.RefreshReport();
        }
    }
}
