using System;

namespace Relatorio.Entities
{
    public class CompraGadoItem
    {
        public int Id { get; set; }
        public int IdCompraGado { get; set; }
        public int IdAnimal { get; set; }
        public int IdPecuarista { get; set; }
        public int Quantidade { get; set; }
        public decimal Total { get; set; }
        public DateTime DataEntrega { get; set; }
        public decimal Preco { get; set; }
        public string Pecuarista { get; set; }
        public string Animal { get; set; } = string.Empty;
        public CompraGado CompraGado { get; set; }
    }
}