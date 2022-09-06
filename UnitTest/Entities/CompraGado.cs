using Newtonsoft.Json;

namespace UnitTest.Entities;
public class CompraGado 
{
    public int Id { get; set; }
    public int IdPecuarista { get; set; }
    public DateTime DataEntrega { get; set; }
    [JsonIgnore]
    public decimal Preco { get; set; }

    public IList<CompraGadoItem> compraGadoItemDTO { get; set; } = new List<CompraGadoItem>();
}