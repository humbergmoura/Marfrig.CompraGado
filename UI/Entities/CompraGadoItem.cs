using Newtonsoft.Json;

namespace UI.Entities;

public class CompraGadoItem
{
    public int Id { get; set; }
    public int IdCompraGado { get; set; }
    public int IdAnimal { get; set; }
    [JsonIgnore]
    public int IdPecuarista { get; set; }
    public int Quantidade { get; set; }
    [JsonIgnore]
    public decimal Total { get; set; }
    [JsonIgnore]
    public DateTime DataEntrega { get; set; }
    [JsonIgnore]
    public decimal Preco { get; set; }
    [JsonIgnore]
    public string Pecuarista { get; set; }
    [JsonIgnore]
    public string Animal { get; set; } = string.Empty;
    public CompraGado CompraGado { get; set; }
}
