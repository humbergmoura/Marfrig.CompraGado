using System;

namespace Relatorio.Entities
{
    public class CompraGado
    {
        public int Id { get; set; }
        public int IdPecuarista { get; set; }
        public DateTime DataEntrega { get; set; }
        public decimal Preco { get; set; }
    }
}