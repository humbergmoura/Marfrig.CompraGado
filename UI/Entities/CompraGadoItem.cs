namespace UI.Entities;

public class CompraGadoItem
{
    public int Id { get; set; }
    public int IdCompraGado { get; set; }
    public int IdAnimal { get; set; }
    public int Quantidade { get; set; }
    public decimal Total { get; set; }
    public DateTime DataEntrega { get; set; }
    public decimal Preco { get; set; }
    public string Pecuarista { get; set; } = String.Empty;
    public string Animal { get; set; } = string.Empty;
    public CompraGado CompraGado { get; set; } = new CompraGado();
}
